<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMain))
        Me.mnuMain = New System.Windows.Forms.ToolStrip()
        Me.mnuSales = New System.Windows.Forms.ToolStripButton()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripButton()
        Me.mnuProducts = New System.Windows.Forms.ToolStripButton()
        Me.mnuInventory = New System.Windows.Forms.ToolStripButton()
        Me.mnuFinance = New System.Windows.Forms.ToolStripButton()
        Me.mnuAccounting = New System.Windows.Forms.ToolStripButton()
        Me.mnuHRDGA = New System.Windows.Forms.ToolStripButton()
        Me.mnuReport = New System.Windows.Forms.ToolStripButton()
        Me.mnuSetup = New System.Windows.Forms.ToolStripButton()
        Me.mnuTools = New System.Windows.Forms.ToolStripButton()
        Me.mnuUserMenu = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangePassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStripSub = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusComp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusServer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.mnuMain.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.AutoSize = False
        Me.mnuMain.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuMain.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSales, Me.mnuCustomers, Me.mnuProducts, Me.mnuInventory, Me.mnuFinance, Me.mnuAccounting, Me.mnuHRDGA, Me.mnuReport, Me.mnuSetup, Me.mnuTools, Me.mnuUserMenu})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1080, 30)
        Me.mnuMain.TabIndex = 3
        '
        'mnuSales
        '
        Me.mnuSales.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSales.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSales.ForeColor = System.Drawing.Color.White
        Me.mnuSales.Image = CType(resources.GetObject("mnuSales.Image"), System.Drawing.Image)
        Me.mnuSales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSales.Name = "mnuSales"
        Me.mnuSales.Size = New System.Drawing.Size(36, 27)
        Me.mnuSales.Tag = "SLS"
        Me.mnuSales.Text = "Sales"
        '
        'mnuCustomers
        '
        Me.mnuCustomers.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuCustomers.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuCustomers.ForeColor = System.Drawing.Color.White
        Me.mnuCustomers.Image = CType(resources.GetObject("mnuCustomers.Image"), System.Drawing.Image)
        Me.mnuCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuCustomers.Name = "mnuCustomers"
        Me.mnuCustomers.Size = New System.Drawing.Size(62, 27)
        Me.mnuCustomers.Tag = "CUS"
        Me.mnuCustomers.Text = "Customers"
        '
        'mnuProducts
        '
        Me.mnuProducts.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuProducts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuProducts.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuProducts.ForeColor = System.Drawing.Color.White
        Me.mnuProducts.Image = CType(resources.GetObject("mnuProducts.Image"), System.Drawing.Image)
        Me.mnuProducts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(53, 27)
        Me.mnuProducts.Tag = "PRO"
        Me.mnuProducts.Text = "Products"
        '
        'mnuInventory
        '
        Me.mnuInventory.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuInventory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuInventory.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuInventory.ForeColor = System.Drawing.Color.White
        Me.mnuInventory.Image = CType(resources.GetObject("mnuInventory.Image"), System.Drawing.Image)
        Me.mnuInventory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuInventory.Name = "mnuInventory"
        Me.mnuInventory.Size = New System.Drawing.Size(59, 27)
        Me.mnuInventory.Tag = "INV"
        Me.mnuInventory.Text = "Inventory"
        '
        'mnuFinance
        '
        Me.mnuFinance.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuFinance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFinance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuFinance.ForeColor = System.Drawing.Color.White
        Me.mnuFinance.Image = CType(resources.GetObject("mnuFinance.Image"), System.Drawing.Image)
        Me.mnuFinance.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuFinance.Name = "mnuFinance"
        Me.mnuFinance.Size = New System.Drawing.Size(48, 27)
        Me.mnuFinance.Tag = "FIN"
        Me.mnuFinance.Text = "Finance"
        '
        'mnuAccounting
        '
        Me.mnuAccounting.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuAccounting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuAccounting.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAccounting.ForeColor = System.Drawing.Color.White
        Me.mnuAccounting.Image = CType(resources.GetObject("mnuAccounting.Image"), System.Drawing.Image)
        Me.mnuAccounting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuAccounting.Name = "mnuAccounting"
        Me.mnuAccounting.Size = New System.Drawing.Size(64, 27)
        Me.mnuAccounting.Tag = "ACC"
        Me.mnuAccounting.Text = "Accounting"
        '
        'mnuHRDGA
        '
        Me.mnuHRDGA.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuHRDGA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuHRDGA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuHRDGA.ForeColor = System.Drawing.Color.White
        Me.mnuHRDGA.Image = CType(resources.GetObject("mnuHRDGA.Image"), System.Drawing.Image)
        Me.mnuHRDGA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuHRDGA.Name = "mnuHRDGA"
        Me.mnuHRDGA.Size = New System.Drawing.Size(50, 27)
        Me.mnuHRDGA.Tag = "HRD"
        Me.mnuHRDGA.Text = "HRD/GA"
        '
        'mnuReport
        '
        Me.mnuReport.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuReport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuReport.ForeColor = System.Drawing.Color.White
        Me.mnuReport.Image = CType(resources.GetObject("mnuReport.Image"), System.Drawing.Image)
        Me.mnuReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(44, 27)
        Me.mnuReport.Tag = "RPT"
        Me.mnuReport.Text = "Report"
        '
        'mnuSetup
        '
        Me.mnuSetup.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuSetup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSetup.ForeColor = System.Drawing.Color.White
        Me.mnuSetup.Image = CType(resources.GetObject("mnuSetup.Image"), System.Drawing.Image)
        Me.mnuSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSetup.Name = "mnuSetup"
        Me.mnuSetup.Size = New System.Drawing.Size(39, 27)
        Me.mnuSetup.Tag = "SET"
        Me.mnuSetup.Text = "Setup"
        '
        'mnuTools
        '
        Me.mnuTools.BackColor = System.Drawing.Color.SteelBlue
        Me.mnuTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuTools.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuTools.ForeColor = System.Drawing.Color.White
        Me.mnuTools.Image = CType(resources.GetObject("mnuTools.Image"), System.Drawing.Image)
        Me.mnuTools.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(36, 27)
        Me.mnuTools.Tag = "TOL"
        Me.mnuTools.Text = "Tools"
        '
        'mnuUserMenu
        '
        Me.mnuUserMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuUserMenu.BackColor = System.Drawing.Color.White
        Me.mnuUserMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuProfile, Me.mnuChangePassword, Me.ToolStripMenuItem1, Me.mnuLogOut})
        Me.mnuUserMenu.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUserMenu.ForeColor = System.Drawing.Color.Black
        Me.mnuUserMenu.Image = CType(resources.GetObject("mnuUserMenu.Image"), System.Drawing.Image)
        Me.mnuUserMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuUserMenu.Name = "mnuUserMenu"
        Me.mnuUserMenu.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mnuUserMenu.Size = New System.Drawing.Size(100, 27)
        Me.mnuUserMenu.Text = "Administrator"
        '
        'mnuProfile
        '
        Me.mnuProfile.Name = "mnuProfile"
        Me.mnuProfile.Size = New System.Drawing.Size(160, 22)
        Me.mnuProfile.Text = "Profile"
        '
        'mnuChangePassword
        '
        Me.mnuChangePassword.Name = "mnuChangePassword"
        Me.mnuChangePassword.Size = New System.Drawing.Size(160, 22)
        Me.mnuChangePassword.Text = "Change Password"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 6)
        '
        'mnuLogOut
        '
        Me.mnuLogOut.Name = "mnuLogOut"
        Me.mnuLogOut.Size = New System.Drawing.Size(160, 22)
        Me.mnuLogOut.Text = "LogOut"
        '
        'mnuStripSub
        '
        Me.mnuStripSub.AutoSize = False
        Me.mnuStripSub.BackColor = System.Drawing.Color.White
        Me.mnuStripSub.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuStripSub.Location = New System.Drawing.Point(0, 30)
        Me.mnuStripSub.Name = "mnuStripSub"
        Me.mnuStripSub.Size = New System.Drawing.Size(1080, 20)
        Me.mnuStripSub.TabIndex = 4
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.statusComp, Me.statusServer, Me.statusTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 615)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(1080, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 86
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.OrangeRed
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(1017, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'statusComp
        '
        Me.statusComp.BackColor = System.Drawing.Color.LightGray
        Me.statusComp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusComp.ForeColor = System.Drawing.Color.Black
        Me.statusComp.Image = CType(resources.GetObject("statusComp.Image"), System.Drawing.Image)
        Me.statusComp.ImageTransparentColor = System.Drawing.Color.White
        Me.statusComp.Name = "statusComp"
        Me.statusComp.Size = New System.Drawing.Size(16, 17)
        '
        'statusServer
        '
        Me.statusServer.BackColor = System.Drawing.Color.LightGray
        Me.statusServer.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusServer.ForeColor = System.Drawing.Color.Black
        Me.statusServer.Image = CType(resources.GetObject("statusServer.Image"), System.Drawing.Image)
        Me.statusServer.ImageTransparentColor = System.Drawing.Color.White
        Me.statusServer.Name = "statusServer"
        Me.statusServer.Size = New System.Drawing.Size(16, 17)
        '
        'statusTime
        '
        Me.statusTime.BackColor = System.Drawing.Color.LightGray
        Me.statusTime.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusTime.ForeColor = System.Drawing.Color.Black
        Me.statusTime.Image = CType(resources.GetObject("statusTime.Image"), System.Drawing.Image)
        Me.statusTime.Name = "statusTime"
        Me.statusTime.Size = New System.Drawing.Size(16, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 615)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(614, 22)
        Me.TabControl1.TabIndex = 255
        '
        'MDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1080, 637)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.mnuStripSub)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuStripSub
        Me.MaximizeBox = False
        Me.Name = "MDIMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TMBookstore"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStrip
    Friend WithEvents mnuStripSub As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSales As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuInventory As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuProducts As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusComp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusServer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mnuFinance As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuAccounting As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuSetup As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuHRDGA As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuUserMenu As ToolStripDropDownButton
    Friend WithEvents mnuProfile As ToolStripMenuItem
    Friend WithEvents mnuChangePassword As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuLogOut As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
End Class
