Imports Microsoft.Reporting.WinForms
Imports genLib.General
Imports sqlLib.Sql
Imports System.Drawing.Printing

Class frmReportViewer

    Private mReport As String
    Private mReportPath As String
    Private mReportDatasetName As String
    Private mReportName As String
    Private mDataSource As DataSet
    Private mFormName As String
    Private mReportParam As List(Of ReportParameter)
    Private myPageSettings As New System.Drawing.Printing.PageSettings()

    Public WriteOnly Property Datasource As DataSet
        Set(ByVal value As DataSet)
            mDataSource = value
        End Set
    End Property

    Public WriteOnly Property ReportDocument As String
        Set(ByVal value As String)
            mReport = value
        End Set
    End Property

    Public WriteOnly Property ReportDatasetName As String
        Set(ByVal value As String)
            mReportDatasetName = value
        End Set
    End Property

    Public WriteOnly Property ReportPath As String
        Set(ByVal value As String)
            mReportPath = value
        End Set
    End Property

    Public WriteOnly Property ReportName As String
        Set(ByVal value As String)
            mReportName = value
        End Set
    End Property

    Public WriteOnly Property FormName As String
        Set(ByVal value As String)
            mFormName = value
        End Set
    End Property

    Public WriteOnly Property ReportParam As List(Of ReportParameter)
        Set(ByVal value As List(Of ReportParameter))
            mReportParam = value
        End Set
    End Property

    Private Sub frmReportViewer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ReportViewer1.LocalReport.ReleaseSandboxAppDomain()
    End Sub

    Private Sub frmReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            ReportViewer1.Reset()


            With ReportViewer1.LocalReport
                .ReportEmbeddedResource = mReport
                .DataSources.Clear()
            End With

            For i As Integer = 0 To mReportParam.Count - 1
                ReportViewer1.LocalReport.SetParameters(mReportParam(i))
            Next

            ReportViewer1.ProcessingMode = ProcessingMode.Local

            If Not IsNothing(mDataSource) Then
                ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource(mReportDatasetName, mDataSource.Tables(0)))
            End If

            ReportViewer1.DocumentMapCollapsed = True

            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 100

            ReportViewer1.LocalReport.Refresh()
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Title)

        End Try

    End Sub

    Private Sub DefaultPaperSize()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class