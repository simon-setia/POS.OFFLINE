Imports System.IO
Imports System.Drawing.Drawing2D
Imports secuLib.Security
Imports connLib.DBConnection
Imports SEE_POS_COMMON

Public Class MDIMain
    Private konek As Boolean = False
    Private server As String
    Private hostname As String
    Private authentication As Integer
    Private database As String
    Private user As String
    Private password As String

    Private port As Integer
    Private query As String
    Private count As Integer
    Private data As DataTable

    Dim _imgHitArea As Point = New Point(13, 2)
    Dim _imageLocation As Point = New Point(15, 3)
    Private FILE_NAME As String = ""
    Private firstLoad As Boolean = False

    Private iniFactory As IniFactory = New IniFactory()
    Private applicationSettings As ApplicationSetting
    Private parameterService As ParameterService = New ParameterService()
    Private appData As New AppData()

    Public Sub New()

        ''    ' This call is required by the designer.
        InitializeComponent()

        ''Set the Mode of Drawing as Owner Drawn
        'TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed

        ''Add the Handler to draw the Image on Tab Pages
        'AddHandler TabControl1.DrawItem, AddressOf TabControl1_DrawItem
    End Sub

    Private Sub btnMnuSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSales.Click

        Try

            ClearButtonStyle()
            mnuSales.BackColor = Color.White
            mnuSales.ForeColor = Color.Black
            mnuSales.Font = New Font("Tahoma", 8, FontStyle.Bold)
            SubMenuSales(mnuStripSub)
            Me.Text = "TMBookstore - Sales"
            mnuStripSub.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.applicationSettings.Title)

        End Try

    End Sub

    Private Sub btnMnuInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInventory.Click
        'set focus
        ClearButtonStyle()
        mnuInventory.BackColor = Color.White
        mnuInventory.ForeColor = Color.Black
        mnuInventory.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuInventory(mnuStripSub)
        Me.Text = "TMBookstore - Inventory"
        mnuStripSub.Visible = True
    End Sub

    Public Sub ClearButtonStyle()
        For Each StripButton As ToolStripItem In Me.mnuMain.Items

            If TypeOf StripButton Is ToolStripButton Then
                If StripButton.Equals(StripButton) Then
                    StripButton.BackColor = Color.SteelBlue
                    StripButton.ForeColor = Color.White
                    StripButton.Font = New Font("Tahoma", 8, FontStyle.Regular)
                End If
            End If


        Next
    End Sub

    Private Sub MDIMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing Then
            TabControl1.Visible = False
        Else

            'Me.ActiveMdiChild.WindowState = FormWindowState.Maximized

            If Not Exists(Me.ActiveMdiChild.Text) Then

                Dim tp As New TabPage(Me.ActiveMdiChild.Text)
                tp.Tag = Me.ActiveMdiChild

                tp.Parent = TabControl1

                ActiveMdiChild.Height = applicationSettings.mainHeight - 125
                ActiveMdiChild.Width = applicationSettings.mainWidth - 30

                ActiveMdiChild.Location = New Point((applicationSettings.mainWidth - 25) / 2 - ActiveMdiChild.Width / 2, (ActiveMdiChild.Height + 5) / 2 - ActiveMdiChild.Height / 2)


                TabControl1.SelectedTab = tp

                Me.ActiveMdiChild.Tag = tp
                'Me.ActiveMdiChild.FormClosed += New FormClosedEventHandler(ActiveMdiChild_FormClosed)
            End If




            If Not TabControl1.Visible Then
                TabControl1.Visible = True

            End If
        End If
    End Sub

    Private Function Exists(ByVal frm As String) As Boolean
        For Each tb As TabPage In TabControl1.TabPages
            If tb.Text = frm Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If (TabControl1.SelectedTab IsNot Nothing) Then
            TryCast(TabControl1.SelectedTab.Tag, Form).[Select]()
        End If
    End Sub

    Private Sub MiddleProfile()
        'Dim x As Integer = (Me.Width / 2) - (Panel2.Width / 2)
        'Dim y As Integer = (Me.Height / 2.2) - (Panel2.Height / 2)
        'Dim m As Integer = (Me.Width / 2) - (Panel1.Width / 2)
        'Dim n As Integer = (Me.Height / 2.2) - (Panel1.Height / 2)

        'Panel2.Location = New Point(x, y)
        'Panel1.Location = New Point(m, n)

    End Sub

    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mnuStripSub.Visible = False

        If File.Exists(Application.StartupPath & "\Wallpaper.jpg") Then
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Wallpaper.jpg")
        Else
            Me.BackgroundImage = Nothing
        End If

        Me.Hide()

        Dim temp As String = ""

        applicationSettings.ProjectID = Environment.MachineName.ToString

        applicationSettings.srcPath = Application.StartupPath & "\config.ini"
        If File.Exists(applicationSettings.srcPath) Then
            temp = iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "Server", "")

            If temp = "" Then
                GoTo konek
            End If

            server = temp
            hostname = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "HostName", ""))
            database = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "Database", ""))
            authentication = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "Authentication", "0"))
            port = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "Port", "0"))
            user = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "User", ""))
            password = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "Password", ""))
            applicationSettings.posPrinter = decryptString(iniFactory.INIRead(applicationSettings.srcPath, applicationSettings.ProjectID, "PosPrinter", ""))
            Try

                If authentication = 0 Then
                    Call OpenConnectionWindows(hostname, database)
                Else
                    Call OpenConnectionSQL(hostname, database, user, password)
                End If


                applicationSettings.Connect = True

            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Exclamation, applicationSettings.applicationSettings.Title)
                applicationSettings.Connect = False
                frmSetupSQL.ShowDialog()
            End Try

        Else
konek:
            applicationSettings.Connect = False
            frmSetupSQL.ShowDialog()
        End If


        If frmLogin.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            If Not applicationSettings.Online = True Then
                End
            Else
                GoTo ShowMainMenu
            End If

        End If

ShowMainMenu:

        Me.Show()

        Try
            applicationSettings.tblParam = New DataTable

            applicationSettings.tblParam = appData.GetParameter()

            applicationSettings.DB = database
            Call StatusBar()
            applicationSettings.Default_WH = parameterService.GetValueParamText("DEFAULT WH")


            applicationSettings.Default_Branch = parameterService.GetValueParamText("DEFAULT BRANCH")

            applicationSettings.Default_PPN = parameterService.GetValueParamMoney("DEFAULT PPN")


            applicationSettings.tblMenuAccess = New DataTable
            applicationSettings.tblMenuAccess = appData.GetMenuAccess(applicationSettings.UserGroup)

            'LoadMenuParent First
            MenuParent(applicationSettings.tblMenuAccess)

            mnuUserMenu.Text = applicationSettings.UserName

            'close voucher
            Call appData.CloseVoucher()

            'check best price
            If parameterService.GetValueParamNumber("BEST PRICE") = 1 Then
                If Not appData.BestPriceExists() = True Then

                    Dim docBestPrice As String = ""

                    docBestPrice = GetLastTransNo("MP")
                    'Check Best Price Promo Exists Today
                    appData.CreateBestPrice(docBestPrice)

                    appData.UpdateHistoryPOS(docBestPrice, "MP")

                End If
            End If

            Dim ctl As Control
            Dim ctlMDI As MdiClient
            ' Loop through all of the form's controls looking ' for the control of type MdiClient. 
            For Each ctl In Me.Controls
                Try ' Attempt to cast the control to type MdiClient. 
                    ctlMDI = CType(ctl, MdiClient) ' Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = Me.BackColor
                Catch exc As InvalidCastException
                End Try
            Next


            Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
            Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height


            applicationSettings.mainHeight = screenHeight - 45
            applicationSettings.mainWidth = screenWidth

            Me.Height = applicationSettings.mainHeight
            Me.Width = applicationSettings.mainWidth


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.applicationSettings.Title)
        End Try

    End Sub

    Private Sub MenuParent(dt As DataTable)
        Try
            For i As Integer = 0 To dt.Rows.Count - 2
                If dt.Rows(i).Item(2) = "app" Then
                    For Each c As ToolStripItem In mnuMain.Items

                        If TypeOf c Is ToolStripButton Then
                            If c.Name = dt.Rows(i).Item(3) Then

                                c.Visible = dt.Rows(i).Item(10)

                            End If
                        End If


                    Next
                End If

            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub StatusBar()
        Dim systemdate As Date
        Dim today As Date = CDate(Format(Now, "yyyy-MM-dd"))

        systemdate = CDate(parameterService.GetValueParamDate("SYSTEM DATE"))
        'GETSystemDate()

        If today > systemdate Then
            appData.UpdateSystemDate(today, "SYSTEM DATE")

            applicationSettings.tblParam = appData.GetParameter()
        Else

        End If
        statusComp.Text = "  " & ParameterService.GetComputerName()
        statusServer.Text = "  " & hostname & " - " & applicationSettings.DB
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        statusTime.Text = "  " & Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub btnMnuReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReport.Click
        'set focus
        ClearButtonStyle()
        mnuReport.BackColor = Color.White
        mnuReport.ForeColor = Color.Black
        mnuReport.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuReport(mnuStripSub)
        Me.Text = "TMBookstore - Report"
        mnuStripSub.Visible = True
    End Sub

    Private Sub mnuStripSub_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles mnuStripSub.Paint
        Dim bounds As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)
        Dim topPoint As New Point((Me.ClientSize.Width - 1) \ 2, 0)
        Dim bottomPoint As New Point((Me.ClientSize.Width - 1) \ 2, Me.ClientSize.Height - 1)
        Dim colors As Color() = {Color.White, Color.White, Color.Silver, Color.Silver}
        Dim positions As Single() = {0.0F, 0.15F, 0.85F, 1.0F}
        Dim blend As New ColorBlend
        blend.Colors = colors
        blend.Positions = positions
        Using lgb As New LinearGradientBrush(topPoint, bottomPoint, Color.White, Color.White)
            lgb.InterpolationColors = blend
            e.Graphics.FillRectangle(lgb, bounds)
        End Using
    End Sub

    Private Sub btnMnuProducts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProducts.Click
        'set focus
        ClearButtonStyle()
        mnuProducts.BackColor = Color.White
        mnuProducts.ForeColor = Color.Black
        mnuProducts.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuProducts(mnuStripSub)
        Me.Text = "TMBookstore - Products"
        mnuStripSub.Visible = True
    End Sub

    Private Sub btnMnuSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetup.Click

        'set focus
        ClearButtonStyle()
        mnuSetup.BackColor = Color.White
        mnuSetup.ForeColor = Color.Black
        mnuSetup.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuSetup(mnuStripSub)
        Me.Text = "TMBookstore - Setup"
        mnuStripSub.Visible = True
    End Sub


    ''Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
    ''    Try
    ''        'Close Image to draw
    ''        Dim img As Image = New Bitmap(Application.StartupPath & "\image\close.gif")
    ''        Dim r As Rectangle = e.Bounds

    ''        r = Me.TabControl1.GetTabRect(e.Index)
    ''        r.Offset(2, 2)
    ''        Dim applicationSettings.TitleBrush As Brush = New SolidBrush(Color.Black)
    ''        Dim f As Font = Me.Font
    ''        Dim applicationSettings.Title As String = Me.TabControl1.TabPages(e.Index).Text

    ''        e.Graphics.DrawString(applicationSettings.Title, f, applicationSettings.TitleBrush, New PointF(r.X, r.Y))
    ''        e.Graphics.DrawImage(img, New Point(r.X + (Me.TabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y))

    ''    Catch ex As Exception
    ''        MsgBox(ex.Message)
    ''    End Try
    ''End Sub

    ''Private Sub TabControl1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseClick
    ''    Dim tc As TabControl = CType(sender, TabControl)
    ''    Dim p As Point = e.Location
    ''    Dim _tabWidth As Integer
    ''    Dim frm As New Form

    ''    _tabWidth = Me.TabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X)
    ''    Dim r As Rectangle = Me.TabControl1.GetTabRect(tc.SelectedIndex)
    ''    r.Offset(_tabWidth, _imgHitArea.Y)
    ''    r.Width = 16
    ''    r.Height = 16
    ''    If r.Contains(p) Then
    ''        frm = TryCast(TabControl1.TabPages.Item(tc.SelectedIndex).Tag, Form)
    ''        Dim TabP As TabPage = DirectCast(tc.TabPages.Item(tc.SelectedIndex), TabPage)
    ''        tc.TabPages.Remove(TabP)
    ''        frm.Close()

    ''    End If


    ''End Sub

    Private Sub mnuHRDGA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHRDGA.Click
        ClearButtonStyle()
        mnuHRDGA.BackColor = Color.White
        mnuHRDGA.ForeColor = Color.Black
        mnuHRDGA.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuHRD(mnuStripSub)
        Me.Text = "TMBookstore - HRD/GA"
        mnuStripSub.Visible = True
    End Sub

    Private Sub mnuFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinance.Click
        ClearButtonStyle()
        mnuFinance.BackColor = Color.White
        mnuFinance.ForeColor = Color.Black
        mnuFinance.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuFinance(mnuStripSub)
        Me.Text = "TMBookstore - Finance"
        mnuStripSub.Visible = True
    End Sub

    Private Sub mnuTools_Click(sender As Object, e As EventArgs) Handles mnuTools.Click
        'set focus
        ClearButtonStyle()
        mnuTools.BackColor = Color.White
        mnuTools.ForeColor = Color.Black
        mnuTools.Font = New Font("Tahoma", 8, FontStyle.Bold)
        SubMenuTools(mnuStripSub)
        Me.Text = "TMBookstore - Tools"
        mnuStripSub.Visible = True
    End Sub

    Private Sub mnuLogOut_Click(sender As Object, e As EventArgs) Handles mnuLogOut.Click
        applicationSettings.Online = False
        Me.Hide()
        If frmLogin.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            If Not applicationSettings.Online = True Then
                End
            Else
                GoTo ShowMainMenu
            End If

        End If

ShowMainMenu:

        Me.Show()

        Try
            applicationSettings.tblParam = New DataTable

            applicationSettings.tblParam = appData.GetParameter()

            applicationSettings.DB = database
            Call StatusBar()
            applicationSettings.Default_WH = parameterService.GetValueParamText("DEFAULT WH")


            applicationSettings.Default_Branch = parameterService.GetValueParamText("DEFAULT BRANCH")

            applicationSettings.Default_PPN = parameterService.GetValueParamMoney("DEFAULT PPN")


            applicationSettings.tblMenuAccess = New DataTable
            applicationSettings.tblMenuAccess = appData.GetMenuAccess(applicationSettings.UserGroup)

            'LoadMenuParent First
            MenuParent(applicationSettings.tblMenuAccess)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, applicationSettings.applicationSettings.Title)
        End Try

    End Sub

    Private Sub MDIMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
        TabControl1.Width = ToolStripStatusLabel1.Width
        TabControl1.Height = ToolStripStatusLabel1.Height

    End Sub


End Class
