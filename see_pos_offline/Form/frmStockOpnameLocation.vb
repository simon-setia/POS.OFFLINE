Imports genLib.General
Imports sqlLib.Sql

Public Class frmStockOpnameLocation
    Private Sub frmStockOpnameLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = Cursors.WaitCursor
            table = New DataTable

            table = GetStockOpnameLocation(Trim(txtSearch.Text))

            If table.Rows.Count > 0 Then

                With GridStockOpnameLocation
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "no"
                    .Columns(1).DataPropertyName = "location"
                    .Columns(2).DataPropertyName = "item"
                    .Columns(3).DataPropertyName = "name"
                    .Columns(4).DataPropertyName = "qty"

                End With

                GridStockOpnameLocation.DataSource = table

            Else
                GridStockOpnameLocation.DataSource = Nothing


            End If
            Me.Cursor = Cursors.Default

        End If
    End Sub

End Class