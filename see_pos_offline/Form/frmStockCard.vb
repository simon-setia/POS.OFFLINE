Imports sqlLib.Sql
Imports genLib.General
Imports mainlib
Imports saveLib.Save

Public Class frmStockCard

    Private mItem As String
    Private mJudul As String
    Private mWHKode As String
    Private mWHName As String


    Public WriteOnly Property ItemCode As String
        Set(ByVal value As String)
            mItem = value
        End Set
    End Property

    Public WriteOnly Property Description As String
        Set(ByVal value As String)
            mJudul = value
        End Set
    End Property

    Public WriteOnly Property WHCode As String
        Set(ByVal value As String)
            mWHKode = value
        End Set
    End Property

    Public WriteOnly Property WHName As String
        Set(ByVal value As String)
            mWHName = value
        End Set
    End Property

    Private Sub frmStockCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0%

        lblItem.Text = mItem
        lblDescription.Text = mJudul
        lblWarehouse.Text = mWHName

        LoadStockCard(Format(Now, "yyyy") & "-" & Format(Now, "MM") & "-01")
        lblPeriod.Text = "01-" & Format(Now, "MMM") & "-" & Format(Now, "yyyy") & "   " & Format(Now, "dd-MMM-yyyy")
        chckAllPeriod.Checked = False
        Me.Timer1.Enabled = True

    End Sub

    Private Sub LoadStockCard(ByVal fperiod As Date)
        Try
            Dim temp As New DataTable

            temp = GETStockCard(Trim(mItem), mWHKode, fperiod, Now)

            If temp.Rows.Count > 0 Then
                With GridStockCard
                    .AutoGenerateColumns = False
                    .Columns(0).DataPropertyName = "Iden"
                    .Columns(1).DataPropertyName = "Date"
                    .Columns(2).DataPropertyName = "DocumentNo"
                    .Columns(3).DataPropertyName = "dn"
                    .Columns(4).DataPropertyName = "Transid"
                    .Columns(5).DataPropertyName = "TrnType"
                    .Columns(6).DataPropertyName = "Conterpart"
                    .Columns(7).DataPropertyName = "CounterpartName"
                    .Columns(8).DataPropertyName = "Qty"
                    .Columns(9).DataPropertyName = "Saldo"

                End With

                GridStockCard.DataSource = temp
            Else
                GridStockCard.DataSource = Nothing

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub chckAllPeriod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckAllPeriod.CheckedChanged

        If chckAllPeriod.Checked = True Then
            LoadStockCard("2012-06-01")
            lblPeriod.Text = "...   " & Format(Now, "dd-MMM-yyyy")

        Else
            LoadStockCard(Format(Now, "yyyy") & "-" & Format(Now, "MM") & "-01")
            lblPeriod.Text = "01-" & Format(Now, "MMM") & "-" & Format(Now, "yyyy") & "   " & Format(Now, "dd-MMM-yyyy")

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Opacity = Me.Opacity + 0.2

        If Me.Opacity >= 1 Then
            Timer1.Enabled = False
            Me.Opacity = 1

        End If

    End Sub

    Private Sub ExportExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportExcelToolStripMenuItem.Click
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
            table = GridStockCard.DataSource

            If SFD.ShowDialog() = DialogResult.OK Then
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
            Else
                DialogResult = DialogResult.None

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class