Imports genLib.General
Imports proLib.Process
Imports sqlLib.Sql
Imports mainlib

Public Class frmMasterRack

    Private mstate As Integer
    Private positionSelected As Integer

    Private Sub frmMasterRack_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Dim iden As Integer = 0

        If gridRack.RowCount > 0 Then
            iden += 1

        Else
            iden = 1
        End If
        gridRack.Rows.Add()
        mstate = 1

        gridRack.Rows(gridRack.Rows.Count - 1).Cells(0).Value = iden

        gridRack.Refresh()
        gridRack.Rows(gridRack.Rows.Count - 1).Selected = True

        For i As Integer = 1 To gridRack.ColumnCount - 1
            gridRack.Rows(gridRack.Rows.Count - 1).Cells(i).ReadOnly = False
        Next

        gridRack.Rows(gridRack.Rows.Count - 1).Cells(1).Selected = True

        DetailClear(1)

    End Sub

    Private Sub DetailClear(state As Integer)

        Select Case state
            Case 1 'new

                btnNew.Enabled = False
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                btnSave.Enabled = True
                btnCancel.Enabled = True

            Case 2 'edit
                btnNew.Enabled = False
                btnEdit.Enabled = False
                btnDelete.Enabled = False
                btnSave.Enabled = True
                btnCancel.Enabled = True

            Case 0, 3 'cancel or delete
                btnNew.Enabled = True
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnSave.Enabled = True
                btnCancel.Enabled = True
        End Select
    End Sub

    Private Sub gridRack_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles gridRack.EditingControlShowing
        If (CType(sender, DataGridView).CurrentCell.ColumnIndex <> 0) Then

            If TypeOf e.Control Is TextBox Then
                DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Upper
            End If

        End If
    End Sub

    Private Sub gridRack_SelectionChanged(sender As Object, e As EventArgs) Handles gridRack.SelectionChanged
        If mstate = 1 Then

        ElseIf mstate = 2 Then

            If positionSelected <> gridRack.CurrentRow.Index Then
                Dim result As String = MsgBox("Are you sure you want to save your changes?", MsgBoxStyle.YesNo)
                If result = vbYes Then
                    mstate = 0
                    gridRack.ClearSelection()
                    gridRack.Rows.Clear()

                    'LoadRack(gridRack)

                    ColumnAllReadonly()


                Else
                    mstate = 0
                    gridRack.Rows(positionSelected).Selected = True
                    ColumnAllReadonly()
                End If
            End If

        End If
    End Sub

    Private Sub ColumnAllReadonly()
        For i As Integer = 0 To gridRack.Columns.Count - 1
            gridRack.Columns(i).ReadOnly = True
        Next
    End Sub

    Private Sub LoadImage()

        btnNew.Image = mainClass.imgList.ImgBtnNew

        btnDelete.Image = mainClass.imgList.ImgBtnVoid

        btnEdit.Image = mainClass.imgList.ImgBtnEdit

        btnSave.Image = mainClass.imgList.ImgBtnSave

        btnCancel.Image = mainClass.imgList.ImgBtnCancel


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmMasterRack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadImage()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DetailClear(0)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        DetailClear(2)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
End Class