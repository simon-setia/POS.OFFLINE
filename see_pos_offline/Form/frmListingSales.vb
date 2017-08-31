Imports System.Drawing.Drawing2D
Imports connLib.DBConnection
Imports genLib.General
Imports prolib.Process
Imports saveLib.Save
Imports System.IO
Imports mainlib
Imports sqlLib.Sql
Imports System.ComponentModel


Public Class frmListingSales

    Private firstLoad As Boolean
    Private seqnum As Integer

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            firstLoad = False

            table = New DataTable

            table = ListingSalesHeader(IIf(cmbEmployeeID.Text <> "Any", cmbEmployeeID.SelectedValue, "Any"),
                                       dtFrom.Value, dtTo.Value, cmbPayment.SelectedIndex)

            With GridHeader
                .AutoGenerateColumns = False
                .Columns(0).DataPropertyName = "Invoice"
                .Columns(1).DataPropertyName = "Date"
                .Columns(2).DataPropertyName = "Customer"
                .Columns(3).DataPropertyName = "Gross"
                .Columns(4).DataPropertyName = "DPP"
                .Columns(5).DataPropertyName = "PPN"
                .Columns(6).DataPropertyName = "Total"
                .Columns(7).DataPropertyName = "Rounding"
                .Columns(8).DataPropertyName = "Cash"
                .Columns(9).DataPropertyName = "Card"
                .Columns(10).DataPropertyName = "Charges"
                .Columns(11).DataPropertyName = "Emp"
            End With
            GridHeader.DataSource = table

            CalculateTotal()

            'If GridHeader.RowCount > 0 Then
            '    GetDetailInvoice()
            '    firstLoad = True
            'Else
            '    gridDetail.Rows.Clear()
            '    firstLoad = False

            'End If
            'End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.Title)
        End Try

    End Sub

    Private Sub CalculateTotal()
        Dim total, totalCash, totalCard, totalRounding As Decimal

        total = 0
        totalCash = 0
        totalCard = 0
        totalRounding = 0

        If GridHeader.RowCount > 0 Then
            For i As Integer = 0 To GridHeader.RowCount - 1
                total = total + (GridHeader.Rows(i).Cells(8).Value + GridHeader.Rows(i).Cells(9).Value)
                totalCash += GridHeader.Rows(i).Cells(8).Value
                totalCard += GridHeader.Rows(i).Cells(9).Value
                totalRounding += GridHeader.Rows(i).Cells(7).Value

            Next
        End If

        lblTotal.Text = String.Format("{0:#,##0}", Math.Floor(total))
        lblTotalCash.Text = String.Format("{0:#,##0}", Math.Round(totalCash, 0))
        lblTotalCard.Text = String.Format("{0:#,##0}", Math.Round(totalCard, 0))
        lblTotalRounding.Text = String.Format("{0:#,##0}", Math.Round(totalRounding, 0))

        lblTotalTransaction.Text = "Total Transaction : " & GridHeader.RowCount

        Dim empID As String = ""
        If Trim(cmbEmployeeID.Text) = "Any" Then
            empID = ""
        Else
            empID = Trim(cmbEmployeeID.SelectedValue)
        End If


        'Charges from Card
        lblTotalCharge.Text = String.Format("{0:#,##0}", CDec(GetCharge(empID, dtFrom.Value, dtTo.Value)))


    End Sub

    Private Sub CalculateTotalDetail()
        Dim total As Decimal = 0
        If GridHeader.RowCount > 0 Then
            For i As Integer = 0 To GridHeader.RowCount - 1
                total = total + GridHeader.Rows(i).Cells(5).Value
            Next
        End If

        'If chckAll.Checked = True And rdbAll.Checked = True Then
        '    lblTotal.Text = String.Format("{0:#,##0}", total + GetRoundingAmt())
        'Else
        '    lblTotal.Text = String.Format("{0:#,##0}", total)
        'End If

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Dim SFD As New SaveFileDialog
        Dim strFileName As String = ""
        Dim mDataset As DataSet


        Try
            SFD.InitialDirectory = "C:\"
            SFD.Title = "Save Your File Spreadsheet"
            SFD.Filter = "Microsoft Excel(*.xls)|*.xls|Comma Delimited File(*.csv)|*.Csv"
            SFD.OverwritePrompt = True
            SFD.ShowDialog()
            strFileName = SFD.FileName
            table = New DataTable
            table = GridHeader.DataSource

            ' If SFD.ShowDialog() = DialogResult.OK Then
            If SFD.FilterIndex = 1 Then
                mDataset = New DataSet("Data")

                mDataset.Tables.Add(table.Copy)
                If WriteXLSFile(strFileName, mDataset) Then
                    MsgBox("Export Finish", MsgBoxStyle.Information, applicationSettings.Title)

                End If
            Else
                Call ExporttoCSV(table, strFileName, vbTab)
                MsgBox("Export Finish", MsgBoxStyle.Information, applicationSettings.Title)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.Title)

        End Try

    End Sub

    Private Sub frmListingSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadImage()
        LoadSalesOrg(cmbSalesOrgPOS, gridAll, 0)
        cmbEmployeeID.Text = "Any"
    End Sub

    Private Sub LoadImage()

        btnRefresh.Image = mainClass.imgList.ImgBtnRefresh

        btnExport.Image = mainClass.imgList.ImgBtnExport

    End Sub

    Private Sub cmbEmployee_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmployeeID.Click, cmbSalesOrgPOS.Click
        Try

            Dim senderCmb As ComboBox = DirectCast(sender, ComboBox)


            Select Case senderCmb.Tag
                Case "CASHIER"
                    LoadCashier(senderCmb, dtFrom.Value, dtTo.Value, gridAll)
                    gridAll.Location = New Point(senderCmb.Left, senderCmb.Location.Y + 22)
                Case Else
                    LoadSalesOrg(cmbSalesOrgPOS, gridAll, 1)
                    gridAll.Location = New Point(senderCmb.Left, senderCmb.Location.Y + 22)
            End Select





            gridAll.Size = New Point(GetColumnWidth(gridAll.Columns.Count, gridAll) +
                                           (senderCmb.Width - GetColumnWidth(gridAll.Columns.Count, gridAll)) + 60,
                                           GetRowHeight(gridAll.Rows.Count, gridAll))


            senderCmb.DroppedDown = False

            If gridAll.Visible = True Then
                gridAll.Visible = False
                senderCmb.Focus()
            Else
                If gridAll.RowCount > 0 Then gridAll.Visible = True
                senderCmb.DroppedDown = False
                gridAll.Focus()

            End If

            gridAll.Tag = senderCmb.Tag

            gridAll.Columns(0).Width = 60
            gridAll.Columns(1).Width = gridAll.Width - 64

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.Title)
        End Try
    End Sub

    Private Sub gridAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAll.Click


        Select Case gridAll.Tag
            Case "CASHIER"
                cmbEmployeeID.SelectedValue = gridAll.SelectedCells(0).Value
            Case Else
                cmbSalesOrgPOS.SelectedValue = gridAll.SelectedCells(0).Value
        End Select

        gridAll.Visible = False
    End Sub

    Private Sub cmbEmployeeID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEmployeeID.TextChanged
        If cmbEmployeeID.Text = "" Or cmbEmployeeID.Text.Length = 0 Then
            cmbEmployeeID.Text = "Any"
        End If
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class