Imports System.Drawing.Drawing2D
Imports connLib.DBConnection
Imports saveLib.Save
Imports SEE_POS_COMMON

Public Class frmListItem

    Private mWH As String = ""
    Private query As String = ""
    Private table As DataTable
    Private applicationsettings As ApplicationSetting
    Private parameterService As ParameterService = New ParameterService()

    Public WriteOnly Property List_WH As String
        Set(ByVal value As String)
            mWH = value

        End Set
    End Property

    Private Sub frmListItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSearch.Focus()
        cmbGroup.SelectedIndex = 1

    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyCode = Keys.Enter Then
            Try
                Cursor = Cursors.WaitCursor
                RefreshData(cmbGroup.SelectedIndex)
                GridListItem.Focus()
                Cursor = Cursors.Default
            Catch ex As Exception
                Cursor = Cursors.Default
                MsgBox(ex.Message, MsgBoxStyle.Critical, applicationsettings.applicationSettings.Title)
            End Try
        End If
    End Sub

    Private Sub RefreshData(ByVal state As Integer)
        Try
            Dim text As String
            text = "%" & Trim(txtSearch.Text) & "%"
            table = New DataTable
            If cn.State = ConnectionState.Closed Then cn.Open()

            'query = "EXECUTE " & DB & ".dbo.P_GETDETAILITEM '" & GetValueParamText("DEFAULT BRANCH") & "'," & _
            '            "'" & GetValueParamText("DEFAULT WH") & "','" & Trim(text) & "','" & state & "'," & _
            '            "'" & GetValueParamText("STOCK MINUS") & "'"

            query = "SELECT TOP 50 LTRIM(RTRIM(mtipe.type_partnumber)) item,mtipe.type_description judul," &
                    "CASE WHEN mtipe.type_materialtype in ('520','510','610') THEN 'Consignment' ELSE 'Credit' END sts," &
                    "CAST(ISNULL(mpart.part_rfsstock ,0)AS INT) AS stock,mtipe.type_materialinfo AS author " &
                    "FROM dbo.mtipe INNER JOIN dbo.mpart ON mpart.part_partnumber=mtipe.type_partnumber "

            If state = 0 Then
                query = query + "WHERE mtipe.type_partnumber LIKE '%' + '" & Trim(text) & "' + '%' AND mtipe.type_status<>1 "
            ElseIf state = 1 Then
                query = query + "WHERE mtipe.type_description LIKE '%' + '" & Trim(text) & "' + '%' AND mtipe.type_status<>1 "
            ElseIf state = 2 Then
                query = query + "WHERE mtipe.type_spl_material2 LIKE '%' + '" & Trim(text) & "' + '%' AND mtipe.type_status<>1 "
            Else
                query = query + "WHERE mtipe.type_materialinfo LIKE '%' + '" & Trim(text) & "' + '%' AND mtipe.type_status<>1 "
            End If

            query = query + "AND mpart.Part_WH='" & mWH & "' " &
                            "AND mpart.Part_Branch='" & ParameterService.GetValueParamText("DEFAULT BRANCH") & "' "

            If parameterService.GetValueParamText("STOCK MINUS") = 0 Then
                query = query + "AND mpart.part_rfsstock<>0 "
            End If

            '

            With cm
                .Connection = cn
                .CommandText = query
            End With

            With da
                .SelectCommand = cm
                .Fill(table)
            End With

            With GridListItem
                .AutoGenerateColumns = False
                .Columns(0).DataPropertyName = "item"
                .Columns(1).DataPropertyName = "judul"
                .Columns(2).DataPropertyName = "sts"
                .Columns(3).DataPropertyName = "stock"
                .Columns(4).DataPropertyName = "author"
            End With

            GridListItem.DataSource = table

            lblRecords.Text = GridListItem.RowCount & " records"

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub GridListItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridListItem.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub


    'Private Sub GridListItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GridListItem.KeyPress
    '    If e.KeyChar = ChrW(Keys.Enter) Then

    '        If GridListItem.SelectedCells(0).Value <> "" Then

    '            DialogResult = Windows.Forms.DialogResult.OK
    '        Else
    '            DialogResult = Windows.Forms.DialogResult.None
    '        End If

    '    End If

    'End Sub
End Class