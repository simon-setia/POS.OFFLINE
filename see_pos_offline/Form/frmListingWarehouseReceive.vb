﻿Imports genLib.General
Imports proLib.Process
Imports sqlLib.Sql
Imports saveLib.Save
Imports mainlib
Imports Microsoft.Reporting.WinForms

Public Class frmListingWarehouseReceive

    Private firstLoad As Boolean = False
    Private seqnum As Integer

    Private Sub frmListingWarehouseReceive_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadImage()
        cmbStatus.SelectedIndex = 0
        cmbOption.SelectedIndex = 0

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub LoadImage()

        btnRefresh.Image = mainClass.imgList.ImgBtnRefresh

        btnExport.Image = mainClass.imgList.ImgBtnExport

        btnPrint.Image = mainClass.imgList.ImgBtnPrint

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try

            Me.Cursor = Cursors.WaitCursor


            table = New DataTable

            If cmbOption.SelectedIndex = 0 Then
                table = RptListingWarehouseReceive(cmbSupplier.SelectedValue, dtFrom.Value, dtTo.Value, cmbStatus.SelectedIndex)

                With GridHeader
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "docno"
                    .Columns(1).DataPropertyName = "pono"
                    .Columns(2).DataPropertyName = "docdate"
                    .Columns(3).DataPropertyName = "trnid"
                    .Columns(4).DataPropertyName = "dn"
                    .Columns(5).DataPropertyName = "dndate"
                    .Columns(6).DataPropertyName = "note"
                    .Columns(7).DataPropertyName = "sts"

                End With


                GridHeader.DataSource = table
            Else
                table = ListingReceiveDetail(cmbSupplier.SelectedValue, dtFrom.Value, dtTo.Value, cmbStatus.SelectedIndex)

                With gridDetail
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "docno"
                    .Columns(1).DataPropertyName = "pono"
                    .Columns(2).DataPropertyName = "docdate"
                    .Columns(3).DataPropertyName = "item"
                    .Columns(4).DataPropertyName = "description"
                    .Columns(5).DataPropertyName = "uom"
                    .Columns(6).DataPropertyName = "qty"


                End With

                gridDetail.DataSource = table

            End If





            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)

        End Try
    End Sub

    Private Sub cmbSupplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSupplier.KeyPress
        If gridAll.Visible = True Then
            gridAll.Visible = False

        End If
    End Sub

    Private Sub cmbSupplier_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSupplier.KeyUp
        If e.KeyCode = Keys.Enter Then

            If Not cmbStatus.SelectedIndex = 0 Then Exit Sub

            If Trim(cmbSupplier.Text) <> "" Then
                LoadSupplier(cmbSupplier, gridAll, Trim(cmbSupplier.Text), 1)

                gridAll.Location = New Point(cmbSupplier.Left, cmbSupplier.Location.Y + 22)
                gridAll.Size = New Point(GetColumnWidth(gridAll.Columns.Count, gridAll) + _
                                         (cmbSupplier.Width - GetColumnWidth(gridAll.Columns.Count, gridAll)) + 60, _
                                         GetRowHeight(gridAll.Rows.Count, gridAll))
                cmbSupplier.DroppedDown = False

                If gridAll.Visible = True Then
                    gridAll.Visible = False
                    cmbSupplier.Focus()
                Else
                    If gridAll.RowCount > 0 Then gridAll.Visible = True
                    cmbSupplier.DroppedDown = False
                    gridAll.Focus()

                End If

                gridAll.Tag = cmbSupplier.Tag

                gridAll.Columns(0).Width = 50
                gridAll.Columns(1).Width = gridAll.Width - 54

            End If
        End If
    End Sub

    Private Sub gridAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAll.DoubleClick

        Select Case gridAll.Tag

            Case "WAREHOUSE"

            Case Else

                cmbSupplier.SelectedValue = gridAll.SelectedCells(0).Value

        End Select


        gridAll.Visible = False

    End Sub

    Private Sub gridAll_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAll.LostFocus
        If gridAll.Visible = True Then

            Select Case gridAll.Tag

                Case "WAREHOUSE"
               
                Case Else

                    If Not cmbSupplier.Focused = True Then gridAll.Visible = False

            End Select
        End If
    End Sub

    Private Sub cmbSupplier_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplier.DropDown
        Try

            Dim senderCmb As ComboBox = DirectCast(sender, ComboBox)


            If cmbStatus.SelectedIndex = 0 Then
                LoadSupplier(cmbSupplier, gridAll, "", 0)
            ElseIf cmbStatus.SelectedIndex = 1 Then             ',.
                LoadSupplier(cmbSupplier, gridAll, "Tmbookstore", 1)
            Else
                LoadWarehouse(cmbSupplier, gridAll, 0)
            End If


            gridAll.Location = New Point(senderCmb.Left, senderCmb.Location.Y + 22)

            gridAll.Size = New Point(GetColumnWidth(gridAll.Columns.Count, gridAll) + _
                                           (senderCmb.Width - GetColumnWidth(gridAll.Columns.Count, gridAll)) + 60, _
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

            If cmbStatus.SelectedIndex = 1 Then
                gridAll.Columns(0).Width = 65
                gridAll.Columns(1).Width = gridAll.Width - 69
            Else
                gridAll.Columns(0).Width = 50
                gridAll.Columns(1).Width = gridAll.Width - 54
            End If

           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged

        If cmbStatus.SelectedIndex = 0 Then
            lblReceive.Text = "Supplier"

        ElseIf cmbStatus.SelectedIndex = 1 Then
            lblReceive.Text = "Branch"
        Else
            lblReceive.Text = "Warehouse"

        End If
        cmbSupplier.Text = "Any"

    End Sub

    Private Sub cmbSupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplier.TextChanged
        If cmbSupplier.Text = "" Or cmbSupplier.Text.Length = 0 Then
            cmbSupplier.Text = "Any"
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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
            If cmbOption.SelectedIndex = 0 Then
                table = GridHeader.DataSource
            Else
                table = gridDetail.DataSource
            End If

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

    Private Sub cmbOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOption.SelectedIndexChanged
        If cmbOption.SelectedIndex = 0 Then
            GridHeader.Visible = True
            gridDetail.Visible = False
        Else
            GridHeader.Visible = False
            gridDetail.Visible = True
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim param As ReportParameter
        Dim params As New List(Of ReportParameter)
        Dim stsMovement As String = ""
        Dim ds As DataSet = New DataSet("Movement_Dataset")

        table = New DataTable

        Me.Cursor = Cursors.WaitCursor

        table = GetDetailBranch()

        param = New ReportParameter("branchNameParam", table.Rows(0).Item(1).ToString)
        params.Add(param)
        param = New ReportParameter("branchAddress1Param", table.Rows(0).Item(2).ToString)
        params.Add(param)
        param = New ReportParameter("branchAddress2Param", table.Rows(0).Item(3).ToString)
        params.Add(param)

        table = New DataTable

        If cmbOption.SelectedIndex = 0 Then 'header

            table = GetReceiveDetail(Trim(GridHeader.SelectedCells(0).Value), cmbStatus.SelectedIndex)
        Else 'detail
            table = GetReceiveDetail(Trim(gridDetail.SelectedCells(0).Value), cmbStatus.SelectedIndex)
        End If

        ds.Reset()
        ds.Tables.Add(table)

        param = New ReportParameter("documentParam", table.Rows(0).Item(0).ToString)
        params.Add(param)
        param = New ReportParameter("dateParam", table.Rows(0).Item(1).ToString)
        params.Add(param)
        param = New ReportParameter("dnParam", table.Rows(0).Item(3).ToString)
        params.Add(param)
        param = New ReportParameter("dnDateParam", table.Rows(0).Item(4).ToString)
        params.Add(param)
        param = New ReportParameter("transIdParam", table.Rows(0).Item(5).ToString)
        params.Add(param)
        param = New ReportParameter("fromParam", table.Rows(0).Item(6).ToString)
        params.Add(param)
        param = New ReportParameter("addressParam", table.Rows(0).Item(7).ToString)
        params.Add(param)
        param = New ReportParameter("noteParam", table.Rows(0).Item(12).ToString)
        params.Add(param)

        Me.Cursor = Cursors.Default

        frmReportViewer.Datasource = ds
        frmReportViewer.ReportDocument = "SEE_POS_OFFLINE.ReceiveForm.rdlc"
        frmReportViewer.ReportName = "ReceiveForm"
        frmReportViewer.ReportDatasetName = "Receive_Dataset"
        frmReportViewer.ReportParam = params
        frmReportViewer.ShowDialog()
    End Sub
End Class