Imports System.Drawing.Drawing2D
Imports connLib.DBConnection
Imports genLib.General
Imports proLib.Process
Imports saveLib.Save
Imports System.IO
Imports mainlib
Imports sqlLib.Sql
Imports System.ComponentModel

Public Class frmListingSalesAll
    Private firstLoad As Boolean
    Private seqnum As Integer

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            firstLoad = False

            table = New DataTable

            table = ListingSalesAll(cmbSalesOrgPOS.SelectedValue,
                                       dtFrom.Value, dtTo.Value)

            With GridHeader
                .AutoGenerateColumns = False
                .Columns(0).DataPropertyName = "Invoice"
                .Columns(1).DataPropertyName = "Date"
                .Columns(2).DataPropertyName = "Customer"
                .Columns(3).DataPropertyName = "Gross"
                .Columns(4).DataPropertyName = "DPP"
                .Columns(5).DataPropertyName = "PPN"
                .Columns(6).DataPropertyName = "Total"
                .Columns(7).DataPropertyName = "Emp"
                .Columns(8).DataPropertyName = "wh"
            End With
            GridHeader.DataSource = table

            CalculateTotal()

            If GridHeader.RowCount > 0 Then
                GetDetailInvoice()
                firstLoad = True
            Else
                gridDetail.DataSource = Nothing
                firstLoad = False

            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try

    End Sub

    Private Sub GetDetailInvoice()
        Try
            Me.Cursor = Cursors.WaitCursor

            table = New DataTable

            table = ListingSalesDetail(GridHeader.SelectedCells(0).Value)

            With gridDetail
                .AutoGenerateColumns = False
                .Columns(0).DataPropertyName = "iden"
                .Columns(1).DataPropertyName = "item"
                .Columns(2).DataPropertyName = "description"
                .Columns(3).DataPropertyName = "uom"
                .Columns(4).DataPropertyName = "qty"
                .Columns(5).DataPropertyName = "amount"

            End With

            gridDetail.DataSource = table


            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub CalculateTotal()
        Dim total As Decimal


        If GridHeader.RowCount > 0 Then
            For i As Integer = 0 To GridHeader.RowCount - 1
                total = total + (GridHeader.Rows(i).Cells(6).Value)


            Next
        End If

        lblTotal.Text = String.Format("{0:#,##0}", Math.Floor(total))
        lblTotalTransaction.Text = "Total Transaction : " & GridHeader.RowCount


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
                    MsgBox("Export Finish", MsgBoxStyle.Information, Title)

                End If
            Else
                Call ExporttoCSV(table, strFileName, vbTab)
                MsgBox("Export Finish", MsgBoxStyle.Information, Title)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)

        End Try

    End Sub

    Private Sub frmListingSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadImage()
        LoadSalesOrg(cmbSalesOrgPOS, gridAll, 0)

    End Sub

    Private Sub LoadImage()

        btnRefresh.Image = mainClass.imgList.ImgBtnRefresh

        btnExport.Image = mainClass.imgList.ImgBtnExport

    End Sub

    Private Sub cmbEmployee_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSalesOrgPOS.Click
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
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub gridAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAll.Click


        Select Case gridAll.Tag
            Case "CASHIER"

            Case Else
                cmbSalesOrgPOS.SelectedValue = gridAll.SelectedCells(0).Value
        End Select

        gridAll.Visible = False
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub GridHeader_Click(sender As Object, e As EventArgs) Handles GridHeader.Click
        If firstLoad = False Then Exit Sub

        GetDetailInvoice()

    End Sub
End Class