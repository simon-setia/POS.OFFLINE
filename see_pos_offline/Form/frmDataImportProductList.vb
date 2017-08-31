Imports genLib.General
Imports mainlib
Imports System.IO
Imports proLib.Process
Imports saveLib.Save
Imports sqlLib.Sql

Public Class frmDataImportProductList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub btnPasteClipboard_Click(sender As Object, e As EventArgs) Handles btnPasteClipboard.Click
        Me.Cursor = Cursors.WaitCursor

        Try
ReClipboard:

            Dim c As IDataObject = Clipboard.GetDataObject
            Dim arrSplitData As Array = Nothing
            Dim ClipToArray As Array = Nothing

            Dim text As String = ""
            Dim sFormattedData As String
            Dim d As New DataTable

            If IsNothing(Clipboard.GetDataObject) Then Exit Sub

            If (c.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                Dim sr As New StreamReader(CType(c.GetData(DataFormats.CommaSeparatedValue), Stream))

                While (sr.Peek() > 0)


                    sFormattedData = sr.ReadLine()


                    arrSplitData = sFormattedData.Split(",")

                    If d.Columns.Count <= 0 Then
                        For i As Integer = 0 To arrSplitData.GetUpperBound(0)
                            d.Columns.Add()
                        Next
                    End If

                    If d.Columns.Count > 1 Then
                        MsgBox("Data Clipboard Not Valid!!", MsgBoxStyle.Exclamation, applicationSettings.Title)
                        Exit Sub

                    End If

                    Dim iLoopCounter As Integer
                    Dim rowNew As DataRow

                    rowNew = d.NewRow()

                    For iLoopCounter = 0 To arrSplitData.GetUpperBound(0)
                        rowNew(iLoopCounter) = arrSplitData.GetValue(iLoopCounter)


                    Next
                    d.Rows.Add(rowNew)
                End While


            ElseIf (c.GetDataPresent(DataFormats.Text)) Then
                d.Columns.Add("code", GetType(String))

                text = c.GetData(DataFormats.Text, True).ToString
                text = Replace(text, vbCr, "")
                ClipToArray = Split(text, vbLf)

                For i As Integer = 0 To ClipToArray.Length - 1

                    If Not i = 1000 Then
                        If ClipToArray(i).ToString <> "" Then
                            d.Rows.Add(ClipToArray(i))
                        End If

                    End If

                Next

            End If

            If d.Rows.Count <> 0 Then
                With GridDataImportProductList
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "sku"
                    .Columns(1).DataPropertyName = "product_name"
                    .Columns(2).DataPropertyName = "brand_name"
                    .Columns(3).DataPropertyName = "type_name"
                    .Columns(4).DataPropertyName = "tag_name"
                    .Columns(5).DataPropertyName = "track_inventory"
                    .Columns(6).DataPropertyName = "store_supply_price"
                    .Columns(7).DataPropertyName = "store_retail_price"
                    .Columns(8).DataPropertyName = "tax_name"
                    .Columns(9).DataPropertyName = "company_supply_price"
                    .Columns(10).DataPropertyName = "wholesale_price"
                    .Columns(11).DataPropertyName = "product_code"
                    .Columns(12).DataPropertyName = "can_be_ordered"
                    .Columns(13).DataPropertyName = "is_consignment"
                    .Columns(14).DataPropertyName = "supplier_code"


                End With
                GridDataImportProductList.DataSource = ClipboardDataImportProductList(d)
            End If

            lblRecords.Text = GridDataImportProductList.RowCount & " records"
            Me.Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            'If Err.Number = 5 Then GoTo ReClipboard
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.Title)
        End Try
        Clipboard.Clear()

    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
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
            table = GridDataImportProductList.DataSource

            ' If SFD.ShowDialog() = DialogResult.OK Then
            If SFD.FilterIndex = 1 Then
                mDataset = New DataSet("Data")

                mDataset.Tables.Add(table.Copy)
                If WriteXLSFile(strFileName, mDataset) Then
                    MsgBox("Export Finish", MsgBoxStyle.Information, applicationSettings.Title)

                End If
            Else
                Call ExporttoCSV(table, strFileName, "|")
                MsgBox("Export Finish", MsgBoxStyle.Information, applicationSettings.Title)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.Title)

        End Try
    End Sub
End Class