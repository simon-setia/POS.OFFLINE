Public Class ApplicationSetting

    Public ProjectID As String
    Public Title As String = "System Administrator"
    Public Connect As Boolean = False
    Public Online As Boolean = False
    'Public formatDate As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern()
    Public formatDate As String = "yyyy-MM-dd"
    Public logOn As String = ""
    Public UserName As String = ""
    Public UserGroup As String = ""
    Public Default_WH As String = ""
    Public Default_Branch As String = ""
    Public Default_PPN As Decimal = 0
    Public DB As String = ""
    Public tblParam As DataTable
    Public tblMenuAccess As DataTable
    Public srcPath As String
    Public posPrinter As String
    Public mainHeight As Integer = 0
    Public mainWidth As Integer = 0

    Public Enum MyCrypt
        EnCrypt
        Decrypt
    End Enum

    Public Enum Status
        No
        Yes
    End Enum

    Public Sub New()


    End Sub
End Class
