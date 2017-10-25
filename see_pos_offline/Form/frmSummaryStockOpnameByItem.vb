Imports mainlib
Imports sqlLib.Sql
Imports genLib.General
Imports saveLib.Save

Public Class frmSummaryStockOpnameByItem

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmSummaryStockOpnameByItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImage()
    End Sub

    Private Sub LoadImage()

        btnRefresh.Image = mainClass.imgList.ImgBtnRefresh

        btnExport.Image = mainClass.imgList.ImgBtnExport

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Try

            Dim startDate As Date = CDate(dtFrom.Value)
            Dim endDate As Date = CDate(dtTo.Value)

            Me.Cursor = Cursors.WaitCursor

            table = New DataTable
            table = ReportSummaryStockOpnameByItem(startDate, endDate, Default_WH)

            If table.Rows.Count > 0 Then

                With GridSummaryStockOpname
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "no"
                    .Columns(1).DataPropertyName = "sku"
                    .Columns(2).DataPropertyName = "name"
                    .Columns(3).DataPropertyName = "supply_price"
                    .Columns(4).DataPropertyName = "purchase_discount"
                    .Columns(5).DataPropertyName = "quantity"
                    .Columns(6).DataPropertyName = "average_cost"
                    .Columns(7).DataPropertyName = "Stock"

                End With


                GridSummaryStockOpname.DataSource = table

            Else
                GridSummaryStockOpname.DataSource = Nothing


            End If

            lblRecords.Text = GridSummaryStockOpname.RowCount & " records"

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        Finally
            Me.Cursor = Cursors.Default
        End Try
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
            table = GridSummaryStockOpname.DataSource

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

    Private Sub GridSummaryStockOpname_DoubleClick(sender As Object, e As EventArgs) Handles GridSummaryStockOpname.DoubleClick
        If GridSummaryStockOpname.SelectedCells(1).Value <> "" Then

            frmStockCard.ItemCode = GridSummaryStockOpname.SelectedCells(1).Value
            frmStockCard.Description = GridSummaryStockOpname.SelectedCells(2).Value
            frmStockCard.WHCode = Default_WH
            frmStockCard.WHName = GetDetailWH(Default_WH)
            frmStockCard.ShowDialog()
        End If
    End Sub
End Class