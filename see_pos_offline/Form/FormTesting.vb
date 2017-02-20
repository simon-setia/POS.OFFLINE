Imports COMMON
Imports Microsoft.Reporting.WinForms
Imports Microsoft.VisualBasic

Public Class FormTesting
    Private _movementLine As New movementLine
    Private errorprov As New ErrorProvider

    Private Sub FormTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.DataBindings.Add("Text", _movementLine, "Qty", False, DataSourceUpdateMode.OnPropertyChanged)
        errorprov.ContainerControl = Me ' ** Here
        errorprov.DataSource = _movementLine

        EaN13Barcode1.ShowBarcodeText = True
        EaN13Barcode1.ShowCheckSum = True

        EaN13Barcode1.Value = "501000011518"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim param As ReportParameter
        Dim params As New List(Of ReportParameter)

        param = New ReportParameter("item1Param", "AL-QURAN TRANSLITERASI PER KATA AT-THAYYIB")
        params.Add(param)
        param = New ReportParameter("barcode1Param", "5030000020192")
        params.Add(param)
        param = New ReportParameter("item2Param", "QURAN AL-JAMIL TAJWID WARNA TERJEMAH PERKATA TERJEMAH INGGRI")
        params.Add(param)

        param = New ReportParameter("barcode2Param", "5030000020192")
        params.Add(param)

        frmReportViewer.Datasource = Nothing
        frmReportViewer.ReportDocument = "SEE_POS_OFFLINE.Barcode.rdlc"
        frmReportViewer.ReportName = "Barcode"
        frmReportViewer.ReportDatasetName = "Barcode_Dataset"
        frmReportViewer.ReportParam = params
        frmReportViewer.ShowDialog()
    End Sub



End Class