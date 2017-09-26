Imports genLib.General
Imports mainlib
Imports System.IO
Imports proLib.Process
Imports saveLib.Save
Imports sqlLib.Sql


Public Class frmWarehouseStockLevel

    Private Sub frmWarehouseStockLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadImage()
        LoadProducts(cmbProduct, gridAll, 0)
        LoadWarehouse(cmbWarehouse, gridAll, 0)
        LoadProductGroup(cmbGroup, gridAll, 0)

        cmbWarehouse.SelectedValue = GetValueParamText("DEFAULT WH")
        cmbFilter.SelectedIndex = 1

        cmbProduct.Text = "Any"
        cmbStatus.SelectedIndex = 0
        cmbStock.SelectedIndex = 0



    End Sub

    Private Sub gridAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAll.Click

        If gridAll.Tag = "GROUP" Then
            cmbGroup.SelectedValue = gridAll.SelectedCells(0).Value
        ElseIf gridAll.Tag = "WAREHOUSE" Then
            cmbWarehouse.SelectedValue = gridAll.SelectedCells(0).Value

        Else
            cmbProduct.SelectedValue = gridAll.SelectedCells(0).Value
        End If

        gridAll.Visible = False

    End Sub

  
    Private Sub LoadImage()

        btnExport.Image = mainClass.imgList.ImgBtnExport

        btnPrint.Image = mainClass.imgList.ImgBtnPrint

        btnRefresh.Image = mainClass.imgList.ImgBtnRefresh

        picSearch.Image = mainClass.imgList.ImgLabelSearch

        btnPasteClipboard.Image = mainClass.imgList.ImgBtnPasteClipboard
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Try

            Dim productcode As String
            Dim status As String

            Me.Cursor = Cursors.WaitCursor

            If cmbProduct.Text = "Any" Then
                productcode = ""
            Else
                productcode = cmbProduct.SelectedValue
            End If

            If cmbStatus.SelectedIndex = 0 Then
                status = "C"
            Else
                status = "G"
            End If



            table = New DataTable


            table = GetWarehouseStockLevel(Trim(cmbGroup.SelectedValue), status, productcode, cmbWarehouse.SelectedValue, 0, "", cmbStock.SelectedIndex)

            If table.Rows.Count > 0 Then

                With GridWarehouseStockLevel
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "vendor"
                    .Columns(1).DataPropertyName = "item"
                    .Columns(2).DataPropertyName = "name"
                    .Columns(3).DataPropertyName = "type"
                    .Columns(4).DataPropertyName = "product"
                    .Columns(5).DataPropertyName = "prodhier1"
                    .Columns(6).DataPropertyName = "prodhier2"
                    .Columns(7).DataPropertyName = "prodhier3"
                    .Columns(8).DataPropertyName = "prodhier4"
                    .Columns(9).DataPropertyName = "prodhier5"
                    .Columns(10).DataPropertyName = "author"
                    .Columns(11).DataPropertyName = "isbn"
                    .Columns(12).DataPropertyName = "purchase"
                    .Columns(13).DataPropertyName = "het"
                    .Columns(14).DataPropertyName = "stock"


                End With


                GridWarehouseStockLevel.DataSource = table

            Else
                GridWarehouseStockLevel.DataSource = Nothing


            End If

            lblRecords.Text = GridWarehouseStockLevel.RowCount & " records"
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub cmbGroup_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGroup.DropDown, cmbProduct.DropDown, cmbWarehouse.DropDown
        Try

            Dim senderCmb As ComboBox = DirectCast(sender, ComboBox)

            Select Case senderCmb.Tag
                Case "GROUP"
                    LoadProductGroup(senderCmb, gridAll, 1)
                Case "WAREHOUSE"
                    LoadWarehouse(senderCmb, gridAll, 1)
                Case Else
                    LoadProducts(senderCmb, gridAll, 1)
            End Select


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
                gridAll.Focus()
            End If

            gridAll.Tag = senderCmb.Tag

            gridAll.Columns(0).Width = 50
            gridAll.Columns(1).Width = gridAll.Width - 54

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub cmbProduct_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProduct.TextChanged
        If cmbProduct.Text = "" Then
            cmbProduct.Text = "Any"
        End If
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
            table = GridWarehouseStockLevel.DataSource

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

    Private Sub GridWarehouseStockLevel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridWarehouseStockLevel.DoubleClick
        If GridWarehouseStockLevel.SelectedCells(0).Value <> "" Then
            frmStockCard.ItemCode = GridWarehouseStockLevel.SelectedCells(1).Value
            frmStockCard.Description = GridWarehouseStockLevel.SelectedCells(2).Value
            frmStockCard.WHCode = cmbWarehouse.SelectedValue
            frmStockCard.WHName = cmbWarehouse.Text
            frmStockCard.ShowDialog()
        End If
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            table = New DataTable

            table = GetWarehouseStockLevel("", "", "", cmbWarehouse.SelectedValue, cmbFilter.SelectedIndex + 1, Trim(txtSearch.Text), "3")

            If table.Rows.Count > 0 Then

                With GridWarehouseStockLevel
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "vendor"
                    .Columns(1).DataPropertyName = "item"
                    .Columns(2).DataPropertyName = "name"
                    .Columns(3).DataPropertyName = "type"
                    .Columns(4).DataPropertyName = "product"
                    .Columns(5).DataPropertyName = "prodhier1"
                    .Columns(6).DataPropertyName = "prodhier2"
                    .Columns(7).DataPropertyName = "prodhier3"
                    .Columns(8).DataPropertyName = "prodhier4"
                    .Columns(9).DataPropertyName = "prodhier5"
                    .Columns(10).DataPropertyName = "author"
                    .Columns(11).DataPropertyName = "isbn"
                    .Columns(12).DataPropertyName = "purchase"
                    .Columns(13).DataPropertyName = "het"
                    .Columns(14).DataPropertyName = "stock"


                End With

                GridWarehouseStockLevel.DataSource = table

            Else
                GridWarehouseStockLevel.DataSource = Nothing


            End If

            lblRecords.Text = GridWarehouseStockLevel.RowCount & " records"
            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub CalculateStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateStockToolStripMenuItem.Click
        Try
            Dim temp As New DataTable
            Dim lastSaldo As Integer

            temp = GETStockCard(GridWarehouseStockLevel.SelectedCells(0).Value, cmbWarehouse.SelectedValue, "2012-06-01", Now)

            lastSaldo = temp.Rows(temp.Rows.Count - 1).Item(9)

            'REPAIR RFS
            RepairRFS(Trim(GridWarehouseStockLevel.SelectedCells(0).Value), cmbWarehouse.SelectedValue, lastSaldo)

            table = New DataTable

            table = GetWarehouseStockLevel("", "", "", cmbWarehouse.SelectedValue, 1, Trim(GridWarehouseStockLevel.SelectedCells(0).Value), "2")

            If table.Rows.Count > 0 Then

                With GridWarehouseStockLevel
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "part_partnumber"
                    .Columns(1).DataPropertyName = "type_description"
                    .Columns(2).DataPropertyName = "type_materialtype"
                    .Columns(3).DataPropertyName = "product_description"
                    .Columns(4).DataPropertyName = "part_consigmentstock"
                    .Columns(5).DataPropertyName = "part_rfsstock"
                    .Columns(6).DataPropertyName = "part_totalstock"


                End With

                GridWarehouseStockLevel.DataSource = table

            Else
                GridWarehouseStockLevel.DataSource = Nothing


            End If

            lblRecords.Text = GridWarehouseStockLevel.RowCount & " records"


            ''bs.Filter = String.Format("{0} LIKE '%{1}%'", "type_description", Trim(txtSearch.Text))


            ''bs.Sort = "type_description ASC"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If GridWarehouseStockLevel.RowCount > 0 Then
            CalculateStockToolStripMenuItem.Enabled = True
        Else
            CalculateStockToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub gridAll_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridAll.LostFocus
        If gridAll.Visible = True Then

            Select Case gridAll.Tag
                Case "PRODUCT"
                    If Not cmbProduct.Focused = True Then gridAll.Visible = False
                Case "WAREHOUSE"
                    If Not cmbWarehouse.Focused = True Then gridAll.Visible = False

                Case Else

                    If Not cmbGroup.Focused = True Then gridAll.Visible = False

            End Select



        End If
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
                        MsgBox("Data Clipboard Not Valid!!", MsgBoxStyle.Exclamation, Title)
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
                With GridWarehouseStockLevel
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "vendor"
                    .Columns(1).DataPropertyName = "item"
                    .Columns(2).DataPropertyName = "name"
                    .Columns(3).DataPropertyName = "type"
                    .Columns(4).DataPropertyName = "product"
                    .Columns(5).DataPropertyName = "prodhier1"
                    .Columns(6).DataPropertyName = "prodhier2"
                    .Columns(7).DataPropertyName = "prodhier3"
                    .Columns(8).DataPropertyName = "prodhier4"
                    .Columns(9).DataPropertyName = "prodhier5"
                    .Columns(10).DataPropertyName = "author"
                    .Columns(11).DataPropertyName = "isbn"
                    .Columns(12).DataPropertyName = "purchase"
                    .Columns(13).DataPropertyName = "het"
                    .Columns(14).DataPropertyName = "stock"


                End With
                GridWarehouseStockLevel.DataSource = ClipboardItemWarehouseStockLevel(d, cmbFilter.SelectedIndex, cmbWarehouse.SelectedValue)
            End If

            lblRecords.Text = GridWarehouseStockLevel.RowCount & " records"
            Me.Cursor = System.Windows.Forms.Cursors.Default

        Catch ex As Exception
            Me.Cursor = System.Windows.Forms.Cursors.Default
            'If Err.Number = 5 Then GoTo ReClipboard
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
        Clipboard.Clear()

    End Sub


End Class