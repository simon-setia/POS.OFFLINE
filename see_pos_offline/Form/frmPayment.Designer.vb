<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnVoucher = New System.Windows.Forms.Button()
        Me.label27 = New System.Windows.Forms.Label()
        Me.label26 = New System.Windows.Forms.Label()
        Me.txtVoucherAmount = New System.Windows.Forms.TextBox()
        Me.label25 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVoucherCode = New System.Windows.Forms.TextBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.label17 = New System.Windows.Forms.Label()
        Me.label22 = New System.Windows.Forms.Label()
        Me.label18 = New System.Windows.Forms.Label()
        Me.txtCashAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label23 = New System.Windows.Forms.Label()
        Me.txtApproval = New System.Windows.Forms.TextBox()
        Me.label24 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cmbEDC = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbCardType = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCardAmount = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnViewListVoucher = New System.Windows.Forms.Button()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.Color.White
        Me.lblSubTotal.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.IndianRed
        Me.lblSubTotal.Location = New System.Drawing.Point(216, 41)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(325, 56)
        Me.lblSubTotal.TabIndex = 316
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(16, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 26)
        Me.Label2.TabIndex = 319
        Me.Label2.Text = "SUB TOTAL"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'lblPaid
        '
        Me.lblPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPaid.BackColor = System.Drawing.Color.IndianRed
        Me.lblPaid.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.ForeColor = System.Drawing.Color.White
        Me.lblPaid.Location = New System.Drawing.Point(16, 560)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(253, 47)
        Me.lblPaid.TabIndex = 352
        Me.lblPaid.Text = "0.00"
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.IndianRed
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 561)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 25)
        Me.Label8.TabIndex = 353
        Me.Label8.Text = "Paid :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(275, 561)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 350
        Me.Label1.Text = "Remain :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblChange.BackColor = System.Drawing.Color.IndianRed
        Me.lblChange.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.White
        Me.lblChange.Location = New System.Drawing.Point(273, 560)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(261, 47)
        Me.lblChange.TabIndex = 349
        Me.lblChange.Text = "0.00"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(467, 349)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 58)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.White
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.Location = New System.Drawing.Point(467, 409)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(67, 58)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCash.BackColor = System.Drawing.Color.White
        Me.btnCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCash.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCash.Location = New System.Drawing.Point(467, 112)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(67, 58)
        Me.btnCash.TabIndex = 0
        Me.btnCash.Text = "Cash"
        Me.btnCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnCard
        '
        Me.btnCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCard.BackColor = System.Drawing.Color.White
        Me.btnCard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCard.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCard.Location = New System.Drawing.Point(467, 171)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(67, 58)
        Me.btnCard.TabIndex = 1
        Me.btnCard.Text = "Card"
        Me.btnCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCard.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(470, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 10)
        Me.Label13.TabIndex = 408
        Me.Label13.Text = "F1"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(470, 174)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 10)
        Me.Label14.TabIndex = 409
        Me.Label14.Text = "F2"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(470, 352)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 10)
        Me.Label15.TabIndex = 410
        Me.Label15.Text = "F12"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label16.Location = New System.Drawing.Point(469, 412)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 10)
        Me.Label16.TabIndex = 411
        Me.Label16.Text = "Esc"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label19.Location = New System.Drawing.Point(470, 233)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(15, 10)
        Me.Label19.TabIndex = 414
        Me.Label19.Text = "F3"
        '
        'btnVoucher
        '
        Me.btnVoucher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoucher.BackColor = System.Drawing.Color.White
        Me.btnVoucher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoucher.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoucher.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnVoucher.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnVoucher.Location = New System.Drawing.Point(467, 230)
        Me.btnVoucher.Name = "btnVoucher"
        Me.btnVoucher.Size = New System.Drawing.Size(67, 58)
        Me.btnVoucher.TabIndex = 2
        Me.btnVoucher.Text = "Voucher"
        Me.btnVoucher.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVoucher.UseVisualStyleBackColor = False
        '
        'label27
        '
        Me.label27.BackColor = System.Drawing.Color.SteelBlue
        Me.label27.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label27.ForeColor = System.Drawing.Color.White
        Me.label27.Location = New System.Drawing.Point(455, 120)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(2, 90)
        Me.label27.TabIndex = 497
        Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label26
        '
        Me.label26.BackColor = System.Drawing.Color.SteelBlue
        Me.label26.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label26.ForeColor = System.Drawing.Color.White
        Me.label26.Location = New System.Drawing.Point(18, 114)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(2, 90)
        Me.label26.TabIndex = 496
        Me.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVoucherAmount
        '
        Me.txtVoucherAmount.BackColor = System.Drawing.Color.White
        Me.txtVoucherAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVoucherAmount.Enabled = False
        Me.txtVoucherAmount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherAmount.ForeColor = System.Drawing.Color.Black
        Me.txtVoucherAmount.Location = New System.Drawing.Point(20, 182)
        Me.txtVoucherAmount.Multiline = True
        Me.txtVoucherAmount.Name = "txtVoucherAmount"
        Me.txtVoucherAmount.Size = New System.Drawing.Size(436, 25)
        Me.txtVoucherAmount.TabIndex = 494
        Me.txtVoucherAmount.Text = "0"
        Me.txtVoucherAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label25
        '
        Me.label25.BackColor = System.Drawing.Color.SteelBlue
        Me.label25.Location = New System.Drawing.Point(18, 181)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(439, 29)
        Me.label25.TabIndex = 495
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(49, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 493
        Me.Label9.Text = "Number"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoucherCode
        '
        Me.txtVoucherCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVoucherCode.Enabled = False
        Me.txtVoucherCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVoucherCode.ForeColor = System.Drawing.Color.Black
        Me.txtVoucherCode.Location = New System.Drawing.Point(102, 151)
        Me.txtVoucherCode.Name = "txtVoucherCode"
        Me.txtVoucherCode.Size = New System.Drawing.Size(179, 20)
        Me.txtVoucherCode.TabIndex = 5
        '
        'label21
        '
        Me.label21.BackColor = System.Drawing.Color.SteelBlue
        Me.label21.Location = New System.Drawing.Point(100, 149)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(183, 24)
        Me.label21.TabIndex = 492
        '
        'label17
        '
        Me.label17.BackColor = System.Drawing.Color.SteelBlue
        Me.label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.ForeColor = System.Drawing.Color.White
        Me.label17.Location = New System.Drawing.Point(18, 111)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(439, 30)
        Me.label17.TabIndex = 490
        Me.label17.Text = "VOUCHER"
        Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label22
        '
        Me.label22.AutoSize = True
        Me.label22.BackColor = System.Drawing.Color.White
        Me.label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label22.ForeColor = System.Drawing.Color.SteelBlue
        Me.label22.Location = New System.Drawing.Point(49, 187)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(50, 13)
        Me.label22.TabIndex = 498
        Me.label22.Text = "AMOUNT"
        Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label18
        '
        Me.label18.AutoSize = True
        Me.label18.BackColor = System.Drawing.Color.White
        Me.label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label18.ForeColor = System.Drawing.Color.SteelBlue
        Me.label18.Location = New System.Drawing.Point(49, 256)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(50, 13)
        Me.label18.TabIndex = 502
        Me.label18.Text = "AMOUNT"
        Me.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCashAmount
        '
        Me.txtCashAmount.BackColor = System.Drawing.Color.White
        Me.txtCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCashAmount.Enabled = False
        Me.txtCashAmount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmount.ForeColor = System.Drawing.Color.Black
        Me.txtCashAmount.Location = New System.Drawing.Point(20, 251)
        Me.txtCashAmount.Multiline = True
        Me.txtCashAmount.Name = "txtCashAmount"
        Me.txtCashAmount.Size = New System.Drawing.Size(435, 25)
        Me.txtCashAmount.TabIndex = 6
        Me.txtCashAmount.Text = "0"
        Me.txtCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(18, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(439, 30)
        Me.Label3.TabIndex = 500
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(439, 30)
        Me.Label4.TabIndex = 501
        Me.Label4.Text = "CASH"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(49, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 523
        Me.Label5.Text = "AMOUNT"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(32, 385)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 522
        Me.Label6.Text = "Card Name"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCardName
        '
        Me.txtCardName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardName.Enabled = False
        Me.txtCardName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.ForeColor = System.Drawing.Color.Black
        Me.txtCardName.Location = New System.Drawing.Point(98, 390)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(179, 14)
        Me.txtCardName.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(96, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 24)
        Me.Label7.TabIndex = 521
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(46, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 519
        Me.Label10.Text = "Card No"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCardNo
        '
        Me.txtCardNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardNo.Enabled = False
        Me.txtCardNo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNo.ForeColor = System.Drawing.Color.Black
        Me.txtCardNo.Location = New System.Drawing.Point(98, 362)
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.Size = New System.Drawing.Size(179, 14)
        Me.txtCardNo.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(96, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 24)
        Me.Label11.TabIndex = 518
        '
        'label23
        '
        Me.label23.AutoSize = True
        Me.label23.BackColor = System.Drawing.Color.White
        Me.label23.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label23.ForeColor = System.Drawing.Color.SteelBlue
        Me.label23.Location = New System.Drawing.Point(40, 441)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(50, 13)
        Me.label23.TabIndex = 516
        Me.label23.Text = "Approval"
        Me.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApproval
        '
        Me.txtApproval.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtApproval.Enabled = False
        Me.txtApproval.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApproval.ForeColor = System.Drawing.Color.Black
        Me.txtApproval.Location = New System.Drawing.Point(98, 446)
        Me.txtApproval.Name = "txtApproval"
        Me.txtApproval.Size = New System.Drawing.Size(257, 14)
        Me.txtApproval.TabIndex = 11
        '
        'label24
        '
        Me.label24.BackColor = System.Drawing.Color.SteelBlue
        Me.label24.Location = New System.Drawing.Point(96, 441)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(261, 24)
        Me.label24.TabIndex = 515
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.SteelBlue
        Me.label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.ForeColor = System.Drawing.Color.White
        Me.label12.Location = New System.Drawing.Point(453, 316)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(2, 165)
        Me.label12.TabIndex = 513
        Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.SteelBlue
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(18, 316)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(2, 165)
        Me.Label28.TabIndex = 512
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label29.Location = New System.Drawing.Point(35, 330)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 13)
        Me.Label29.TabIndex = 511
        Me.Label29.Text = "Card Type"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbEDC
        '
        Me.cmbEDC.Enabled = False
        Me.cmbEDC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEDC.FormattingEnabled = True
        Me.cmbEDC.Location = New System.Drawing.Point(98, 415)
        Me.cmbEDC.Name = "cmbEDC"
        Me.cmbEDC.Size = New System.Drawing.Size(179, 21)
        Me.cmbEDC.TabIndex = 10
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.SteelBlue
        Me.Label30.Location = New System.Drawing.Point(96, 413)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(183, 25)
        Me.Label30.TabIndex = 510
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label31.Location = New System.Drawing.Point(63, 413)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(27, 13)
        Me.Label31.TabIndex = 508
        Me.Label31.Text = "EDC"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbCardType
        '
        Me.cmbCardType.Enabled = False
        Me.cmbCardType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCardType.FormattingEnabled = True
        Me.cmbCardType.Location = New System.Drawing.Point(98, 330)
        Me.cmbCardType.Name = "cmbCardType"
        Me.cmbCardType.Size = New System.Drawing.Size(179, 21)
        Me.cmbCardType.TabIndex = 7
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.SteelBlue
        Me.Label32.Location = New System.Drawing.Point(96, 329)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(183, 25)
        Me.Label32.TabIndex = 507
        '
        'txtCardAmount
        '
        Me.txtCardAmount.BackColor = System.Drawing.Color.White
        Me.txtCardAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCardAmount.Enabled = False
        Me.txtCardAmount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardAmount.ForeColor = System.Drawing.Color.Black
        Me.txtCardAmount.Location = New System.Drawing.Point(20, 478)
        Me.txtCardAmount.Multiline = True
        Me.txtCardAmount.Name = "txtCardAmount"
        Me.txtCardAmount.Size = New System.Drawing.Size(433, 25)
        Me.txtCardAmount.TabIndex = 12
        Me.txtCardAmount.Text = "0"
        Me.txtCardAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.SteelBlue
        Me.Label33.Location = New System.Drawing.Point(18, 477)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(437, 29)
        Me.Label33.TabIndex = 504
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.SteelBlue
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(18, 290)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(437, 30)
        Me.Label34.TabIndex = 505
        Me.Label34.Text = "CARD"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(3, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(542, 593)
        Me.Label20.TabIndex = 524
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.SteelBlue
        Me.Label35.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(17, 102)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(515, 2)
        Me.Label35.TabIndex = 525
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.SteelBlue
        Me.Label36.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(4, 2)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(153, 24)
        Me.Label36.TabIndex = 526
        Me.Label36.Text = "PAYMENT"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCharge
        '
        Me.txtCharge.BackColor = System.Drawing.Color.White
        Me.txtCharge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCharge.Enabled = False
        Me.txtCharge.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharge.ForeColor = System.Drawing.Color.Black
        Me.txtCharge.Location = New System.Drawing.Point(294, 503)
        Me.txtCharge.Multiline = True
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(159, 25)
        Me.txtCharge.TabIndex = 527
        Me.txtCharge.Text = "0"
        Me.txtCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.SteelBlue
        Me.Label37.Location = New System.Drawing.Point(18, 501)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(437, 29)
        Me.Label37.TabIndex = 528
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.SteelBlue
        Me.Label38.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(224, 508)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(54, 13)
        Me.Label38.TabIndex = 529
        Me.Label38.Text = "CHARGES"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnViewListVoucher
        '
        Me.btnViewListVoucher.BackColor = System.Drawing.Color.SteelBlue
        Me.btnViewListVoucher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewListVoucher.Enabled = False
        Me.btnViewListVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewListVoucher.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewListVoucher.ForeColor = System.Drawing.Color.White
        Me.btnViewListVoucher.Location = New System.Drawing.Point(412, 113)
        Me.btnViewListVoucher.Name = "btnViewListVoucher"
        Me.btnViewListVoucher.Size = New System.Drawing.Size(41, 25)
        Me.btnViewListVoucher.TabIndex = 530
        Me.btnViewListVoucher.Text = "View"
        Me.btnViewListVoucher.UseVisualStyleBackColor = False
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.SteelBlue
        Me.Label39.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(16, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(515, 2)
        Me.Label39.TabIndex = 531
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label40.Location = New System.Drawing.Point(98, 359)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(179, 20)
        Me.Label40.TabIndex = 532
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label41.Location = New System.Drawing.Point(98, 387)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(179, 20)
        Me.Label41.TabIndex = 533
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label42.Location = New System.Drawing.Point(98, 443)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(257, 20)
        Me.Label42.TabIndex = 534
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(548, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCardName)
        Me.Controls.Add(Me.txtApproval)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtCardNo)
        Me.Controls.Add(Me.cmbCardType)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.btnViewListVoucher)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtCharge)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.label23)
        Me.Controls.Add(Me.label24)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cmbEDC)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtCardAmount)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.label18)
        Me.Controls.Add(Me.txtCashAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label22)
        Me.Controls.Add(Me.label27)
        Me.Controls.Add(Me.label26)
        Me.Controls.Add(Me.txtVoucherAmount)
        Me.Controls.Add(Me.label25)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVoucherCode)
        Me.Controls.Add(Me.label21)
        Me.Controls.Add(Me.label17)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btnVoucher)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCard)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCash As System.Windows.Forms.Button
    Friend WithEvents btnCard As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents btnVoucher As System.Windows.Forms.Button
    Private WithEvents label27 As Label
    Private WithEvents label26 As Label
    Friend WithEvents txtVoucherAmount As System.Windows.Forms.TextBox
    Private WithEvents label25 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents txtVoucherCode As System.Windows.Forms.TextBox
    Private WithEvents label21 As Label
    Private WithEvents label17 As Label
    Private WithEvents label22 As Label
    Private WithEvents label18 As Label
    Friend WithEvents txtCashAmount As System.Windows.Forms.TextBox
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Private WithEvents Label6 As Label
    Friend WithEvents txtCardName As System.Windows.Forms.TextBox
    Private WithEvents Label7 As Label
    Private WithEvents Label10 As Label
    Friend WithEvents txtCardNo As System.Windows.Forms.TextBox
    Private WithEvents Label11 As Label
    Private WithEvents label23 As Label
    Friend WithEvents txtApproval As System.Windows.Forms.TextBox
    Private WithEvents label24 As Label
    Private WithEvents label12 As Label
    Private WithEvents Label28 As Label
    Private WithEvents Label29 As Label
    Friend WithEvents cmbEDC As System.Windows.Forms.ComboBox
    Private WithEvents Label30 As Label
    Private WithEvents Label31 As Label
    Friend WithEvents cmbCardType As System.Windows.Forms.ComboBox
    Private WithEvents Label32 As Label
    Friend WithEvents txtCardAmount As System.Windows.Forms.TextBox
    Private WithEvents Label33 As Label
    Private WithEvents Label34 As Label
    Friend WithEvents Label20 As Label
    Private WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents txtCharge As System.Windows.Forms.TextBox
    Private WithEvents Label37 As Label
    Private WithEvents Label38 As Label
    Private WithEvents btnViewListVoucher As Button
    Private WithEvents Label39 As Label
    Private WithEvents Label40 As Label
    Private WithEvents Label41 As Label
    Private WithEvents Label42 As Label
End Class
