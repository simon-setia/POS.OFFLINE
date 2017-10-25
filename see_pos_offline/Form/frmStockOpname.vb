Imports genLib.General
Imports sqlLib.Sql
Imports mainlib

Public Class frmStockOpname

#Region "Property"

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Private _locationArea As String
    Public Property LocationArea() As String
        Get
            Return _locationArea
        End Get
        Set(value As String)
            _locationArea = value
        End Set
    End Property

#End Region
    Private Sub frmStockOpname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "STOCK OPNAME : " & id
        lblLocation.Text = LocationArea
        RefreshData()
        txtItem.Focus()

        picSearch.Image = mainClass.imgList.ImgLabelSearch
        cmbFilter.SelectedIndex = 0

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItem.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then

            Try

                If Trim(txtItem.Text) = "" Then Exit Sub

                Dim sku As String = Trim(txtItem.Text)

                Me.Cursor = Cursors.WaitCursor

                'validate sku exists
                If (Not ItemExists(sku) = True) Then
                    MsgBox("Sku Not Found!!!", MsgBoxStyle.Exclamation, "NOT FOUND")
                    Exit Sub
                End If

                If chckScan.Checked = True Then
                    AddStockOpnameDetail(id, sku, logOn)
                    RefreshData()
                    txtItem.Clear()
                    txtItem.Focus()
                Else
                    txtQty.Focus()
                End If


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")

            Finally
                Me.Cursor = Cursors.Default
            End Try


        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            Try
                If Trim(txtItem.Text) = "" Then Exit Sub

                Dim sku As String = Trim(txtItem.Text)

                Me.Cursor = Cursors.WaitCursor


                'validate sku exists
                If (Not ItemExists(sku) = True) Then
                    MsgBox("Sku Not Found!!!", MsgBoxStyle.Exclamation, "NOT FOUND")
                    Exit Sub
                End If

                If Trim(txtQty.Text) = "" Then Exit Sub

                AddStockOpnameDetail(id, sku, logOn, CInt(txtQty.Text))
                RefreshData()

                txtQty.Text = 1
                txtItem.Clear()
                txtItem.Focus()

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "ERROR")
            Finally
                Me.Cursor = Cursors.Default
            End Try

        End If
    End Sub

    Private Sub RefreshData()

        Try
            table = New DataTable

            table = GetStockOpnameDetailByUser(logOn, id)

            With GridStockOpnameDetail
                .AutoGenerateColumns = False
                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "sku"
                .Columns(2).DataPropertyName = "name"
                .Columns(3).DataPropertyName = "quantity"

            End With

            GridStockOpnameDetail.DataSource = table

            lblTotalQty.Text = TotalQty()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)

        End Try
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

        If Trim(txtQty.Text) = "" Then txtQty.Text = 1
        If Trim(txtQty.Text) = 0 Then txtQty.Text = 1
    End Sub

    Private Sub txtQty_GotFocus(sender As Object, e As EventArgs) Handles txtQty.GotFocus
        txtQty.SelectAll()

    End Sub

    Private Sub txtItem_GotFocus(sender As Object, e As EventArgs) Handles txtItem.GotFocus
        txtItem.SelectAll()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        If GridStockOpnameDetail.SelectedCells(0).Value <> vbEmpty Then

            If MsgBox("Are you sure Remove Item " & GridStockOpnameDetail.Rows(GridStockOpnameDetail.CurrentRow.Index).Cells(1).Value & " - " & GridStockOpnameDetail.Rows(GridStockOpnameDetail.CurrentRow.Index).Cells(2).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, Title) = MsgBoxResult.No Then Exit Sub
            Try
                DeleteStockOpnameDetail(GridStockOpnameDetail.SelectedCells(0).Value)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
            Finally
                RefreshData()
            End Try
        End If

    End Sub

    Private Function TotalQty() As Integer
        Dim tot As Integer = 0

        For i As Integer = 0 To GridStockOpnameDetail.RowCount - 1
            tot = tot + GridStockOpnameDetail.Rows(i).Cells(3).Value
        Next

        Return tot
    End Function

    Private Sub chckScan_Click(sender As Object, e As EventArgs) Handles chckScan.Click
        If chckScan.Checked = True Then
            txtQty.Enabled = False
            txtQty.Text = 1
            txtItem.Focus()
        Else
            txtQty.Enabled = True
            txtQty.Text = 1
            txtItem.Focus()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then

            Try
                Me.Cursor = Cursors.WaitCursor
                table = New DataTable

                table = GetStockOpnameDetailByFilter(id, Trim(txtSearch.Text), cmbFilter.SelectedIndex + 1, logOn)

                If table.Rows.Count > 0 Then

                    With GridStockOpnameDetail
                        .AutoGenerateColumns = False
                        .Columns(0).DataPropertyName = "id"
                        .Columns(1).DataPropertyName = "sku"
                        .Columns(2).DataPropertyName = "name"
                        .Columns(3).DataPropertyName = "quantity"

                    End With

                    GridStockOpnameDetail.DataSource = table

                Else
                    GridStockOpnameDetail.DataSource = Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
            Finally

                lblTotalQty.Text = TotalQty()
                Me.Cursor = Cursors.Default
            End Try


        End If
    End Sub
End Class