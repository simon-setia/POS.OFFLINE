Imports genLib.General
Imports sqlLib.Sql
Imports proLib.Process
Imports mainlib

Public Class frmDisplay

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmDisplay_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadImage()
    End Sub

    Private Sub LoadImage()

    End Sub
    '
    Private Sub RefreshRack()
        Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub


    Private Sub txtSearch_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus

        If txtSearch.Text = "Search..." Then
            txtSearch.Text = ""
        End If

        txtSearch.SelectAll()
    End Sub

    Private Sub txtSearch_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search..."
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            txtSearch.Text = "Search..."
        End If
    End Sub

    Private Sub txtSearch_MouseEnter(sender As Object, e As EventArgs) Handles txtSearch.MouseEnter
        tooltipDisplay.SetToolTip(txtSearch, "Search product here...")

    End Sub

    Private Sub txtItem_DoubleClick(sender As Object, e As EventArgs) Handles txtItem.DoubleClick
        If frmListItem.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtItem.Text = frmListItem.GridListItem.SelectedCells(0).Value
            frmListItem.Close()
        End If
    End Sub
End Class