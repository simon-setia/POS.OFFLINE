<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpenCashier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridAll = New System.Windows.Forms.DataGridView()
        Me.cmbEmployeeID = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.numShift = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numShift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridAll
        '
        Me.gridAll.AllowUserToAddRows = False
        Me.gridAll.AllowUserToOrderColumns = True
        Me.gridAll.AllowUserToResizeColumns = False
        Me.gridAll.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gridAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridAll.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gridAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.gridAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridAll.ColumnHeadersHeight = 25
        Me.gridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridAll.DefaultCellStyle = DataGridViewCellStyle3
        Me.gridAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gridAll.EnableHeadersVisualStyles = False
        Me.gridAll.GridColor = System.Drawing.Color.Silver
        Me.gridAll.Location = New System.Drawing.Point(98, 152)
        Me.gridAll.MultiSelect = False
        Me.gridAll.Name = "gridAll"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAll.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.gridAll.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAll.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.gridAll.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.gridAll.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.gridAll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gridAll.RowTemplate.Height = 20
        Me.gridAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAll.Size = New System.Drawing.Size(257, 111)
        Me.gridAll.TabIndex = 411
        Me.gridAll.Visible = False
        '
        'cmbEmployeeID
        '
        Me.cmbEmployeeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEmployeeID.DropDownHeight = 1
        Me.cmbEmployeeID.DropDownWidth = 1
        Me.cmbEmployeeID.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmployeeID.FormattingEnabled = True
        Me.cmbEmployeeID.IntegralHeight = False
        Me.cmbEmployeeID.ItemHeight = 13
        Me.cmbEmployeeID.Location = New System.Drawing.Point(98, 125)
        Me.cmbEmployeeID.MaxDropDownItems = 1
        Me.cmbEmployeeID.Name = "cmbEmployeeID"
        Me.cmbEmployeeID.Size = New System.Drawing.Size(199, 21)
        Me.cmbEmployeeID.TabIndex = 410
        Me.cmbEmployeeID.Tag = ""
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label15.Location = New System.Drawing.Point(27, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 18)
        Me.Label15.TabIndex = 409
        Me.Label15.Text = "Employee ID :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(25, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 23)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "Note"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNote
        '
        Me.txtNote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(98, 214)
        Me.txtNote.MaxLength = 30
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(199, 21)
        Me.txtNote.TabIndex = 399
        '
        'numShift
        '
        Me.numShift.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.numShift.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numShift.Location = New System.Drawing.Point(98, 152)
        Me.numShift.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numShift.Name = "numShift"
        Me.numShift.Size = New System.Drawing.Size(48, 24)
        Me.numShift.TabIndex = 397
        Me.numShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numShift.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(25, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 407
        Me.Label1.Text = "Shift"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancel.Location = New System.Drawing.Point(296, 322)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(67, 58)
        Me.btnCancel.TabIndex = 401
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(228, 322)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 58)
        Me.btnSave.TabIndex = 400
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtDate
        '
        Me.dtDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtDate.CustomFormat = "dd MMMM yyyy"
        Me.dtDate.Enabled = False
        Me.dtDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(98, 98)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(129, 21)
        Me.dtDate.TabIndex = 406
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(25, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 23)
        Me.Label5.TabIndex = 405
        Me.Label5.Text = "Amount"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(98, 180)
        Me.txtAmount.MaxLength = 100
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(159, 26)
        Me.txtAmount.TabIndex = 398
        Me.txtAmount.Text = "0"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(25, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 404
        Me.Label3.Text = "Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(24, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 403
        Me.Label7.Text = "User Id"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUserId
        '
        Me.txtUserId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUserId.BackColor = System.Drawing.Color.Khaki
        Me.txtUserId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(98, 70)
        Me.txtUserId.MaxLength = 20
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.ReadOnly = True
        Me.txtUserId.Size = New System.Drawing.Size(90, 21)
        Me.txtUserId.TabIndex = 402
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 24)
        Me.Label6.TabIndex = 487
        Me.Label6.Text = "OPEN CASHIER"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 357)
        Me.Label4.TabIndex = 488
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmOpenCashier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(375, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gridAll)
        Me.Controls.Add(Me.cmbEmployeeID)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.numShift)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOpenCashier"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Open Cashier"
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numShift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridAll As DataGridView
    Friend WithEvents cmbEmployeeID As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents numShift As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
End Class
