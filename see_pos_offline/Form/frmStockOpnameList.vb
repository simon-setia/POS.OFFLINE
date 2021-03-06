﻿Imports mainlib
Imports genLib.General
Imports sqlLib.Sql
Imports saveLib.Save

Public Class frmStockOpnameList
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmStockOpnameList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImage()
        RefreshData()
    End Sub

    Private Sub LoadImage()

        btnNew.Image = mainClass.imgList.ImgBtnNew
        btnDelete.Image = mainClass.imgList.ImgBtnVoid

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As New frmCreateStockOpname

        If (frm.ShowDialog = DialogResult.OK) Then
            If frm.txtLocation.TextLength > 0 Then
                AddStockOpname(frm.dtFrom.Value, frm.txtLocation.Text, cmbStatus.SelectedIndex, logOn)
                RefreshData()
            End If


        End If
    End Sub

    Private Sub RefreshData()
        Try
            table = New DataTable

            If chckViewOtherLocation.Checked Then
                table = GetStockTakeList(cmbStatus.SelectedValue)
            Else
                table = GetStockTakeList(cmbStatus.SelectedValue, logOn)
            End If


            With GridStockOpnameList
                .AutoGenerateColumns = False
                .Columns(0).DataPropertyName = "id"
                .Columns(1).DataPropertyName = "location"
                .Columns(2).DataPropertyName = "description"
                .Columns(3).DataPropertyName = "created_at"

            End With

            GridStockOpnameList.DataSource = table

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
        End Try
    End Sub

    Private Sub GridStockOpnameList_DoubleClick(sender As Object, e As EventArgs) Handles GridStockOpnameList.DoubleClick
        If GridStockOpnameList.SelectedCells(0).Value <> vbEmpty Then
            Dim frm As New frmStockOpname

            frm.id = GridStockOpnameList.SelectedCells(0).Value
            frm.LocationArea = GridStockOpnameList.SelectedCells(1).Value
            If (frm.ShowDialog = DialogResult.OK) Then
                RefreshData()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If GridStockOpnameList.SelectedCells(0).Value <> vbEmpty Then
            If MsgBox("Are you sure Remove Stock Opname Document " & GridStockOpnameList.Rows(GridStockOpnameList.CurrentRow.Index).Cells(0).Value & " - " & GridStockOpnameList.Rows(GridStockOpnameList.CurrentRow.Index).Cells(1).Value & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, Title) = MsgBoxResult.No Then Exit Sub

            Try
                Cursor = Cursors.WaitCursor

                RemoveStockTake(GridStockOpnameList.SelectedCells(0).Value)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, Title)
            Finally
                RefreshData()
                Cursor = Cursors.Default
            End Try

        End If
    End Sub

    Private Sub chckViewOtherLocation_CheckedChanged(sender As Object, e As EventArgs) Handles chckViewOtherLocation.CheckedChanged
        RefreshData()
    End Sub
End Class