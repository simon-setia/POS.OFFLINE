<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvent
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbDiscType = New System.Windows.Forms.ComboBox()
        Me.lblDiscType = New System.Windows.Forms.Label()
        Me.dtPeriodFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDocNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtPeriodTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridEvent = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPaste = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.cmbAutoGenerate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTransType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAssignTo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.gridAll = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMinPayment = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.GridEvent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDiscType
        '
        Me.cmbDiscType.DropDownWidth = 121
        Me.cmbDiscType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDiscType.FormattingEnabled = True
        Me.cmbDiscType.IntegralHeight = False
        Me.cmbDiscType.Items.AddRange(New Object() {"Add Discount", "Best Price", "Final Discount"})
        Me.cmbDiscType.Location = New System.Drawing.Point(101, 113)
        Me.cmbDiscType.Name = "cmbDiscType"
        Me.cmbDiscType.Size = New System.Drawing.Size(176, 21)
        Me.cmbDiscType.TabIndex = 2
        Me.cmbDiscType.Tag = ""
        '
        'lblDiscType
        '
        Me.lblDiscType.AutoSize = True
        Me.lblDiscType.BackColor = System.Drawing.Color.White
        Me.lblDiscType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscType.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblDiscType.Location = New System.Drawing.Point(42, 111)
        Me.lblDiscType.Name = "lblDiscType"
        Me.lblDiscType.Size = New System.Drawing.Size(53, 13)
        Me.lblDiscType.TabIndex = 409
        Me.lblDiscType.Text = "Disc Type"
        Me.lblDiscType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtPeriodFrom
        '
        Me.dtPeriodFrom.CustomFormat = "dd MMMM yyyy"
        Me.dtPeriodFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPeriodFrom.Location = New System.Drawing.Point(101, 194)
        Me.dtPeriodFrom.Name = "dtPeriodFrom"
        Me.dtPeriodFrom.Size = New System.Drawing.Size(153, 21)
        Me.dtPeriodFrom.TabIndex = 6
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(101, 86)
        Me.txtNote.MaxLength = 200
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(442, 21)
        Me.txtNote.TabIndex = 1
        '
        'lblDocNo
        '
        Me.lblDocNo.BackColor = System.Drawing.Color.White
        Me.lblDocNo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocNo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblDocNo.Location = New System.Drawing.Point(101, 34)
        Me.lblDocNo.Name = "lblDocNo"
        Me.lblDocNo.Size = New System.Drawing.Size(192, 23)
        Me.lblDocNo.TabIndex = 405
        Me.lblDocNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(64, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 407
        Me.Label5.Text = "Note"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(31, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 406
        Me.Label6.Text = "Period From"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(43, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 404
        Me.Label4.Text = "Event No"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtEventName
        '
        Me.txtEventName.BackColor = System.Drawing.Color.White
        Me.txtEventName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventName.Location = New System.Drawing.Point(101, 60)
        Me.txtEventName.MaxLength = 200
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(442, 21)
        Me.txtEventName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(30, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "Event Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtPeriodTo
        '
        Me.dtPeriodTo.CustomFormat = "dd MMMM yyyy"
        Me.dtPeriodTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPeriodTo.Location = New System.Drawing.Point(101, 221)
        Me.dtPeriodTo.Name = "dtPeriodTo"
        Me.dtPeriodTo.Size = New System.Drawing.Size(153, 21)
        Me.dtPeriodTo.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(43, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 412
        Me.Label2.Text = "Period To"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GridEvent
        '
        Me.GridEvent.AllowUserToAddRows = False
        Me.GridEvent.AllowUserToOrderColumns = True
        Me.GridEvent.AllowUserToResizeColumns = False
        Me.GridEvent.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEvent.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridEvent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEvent.BackgroundColor = System.Drawing.Color.White
        Me.GridEvent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridEvent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GridEvent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridEvent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridEvent.ColumnHeadersHeight = 30
        Me.GridEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridEvent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colItem, Me.colDescription, Me.colDisc})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridEvent.DefaultCellStyle = DataGridViewCellStyle5
        Me.GridEvent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GridEvent.EnableHeadersVisualStyles = False
        Me.GridEvent.GridColor = System.Drawing.Color.SteelBlue
        Me.GridEvent.Location = New System.Drawing.Point(12, 250)
        Me.GridEvent.MultiSelect = False
        Me.GridEvent.Name = "GridEvent"
        Me.GridEvent.RowHeadersVisible = False
        Me.GridEvent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridEvent.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEvent.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GridEvent.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GridEvent.RowTemplate.Height = 25
        Me.GridEvent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridEvent.Size = New System.Drawing.Size(707, 294)
        Me.GridEvent.TabIndex = 414
        '
        'colNo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNo.DefaultCellStyle = DataGridViewCellStyle3
        Me.colNo.Frozen = True
        Me.colNo.HeaderText = "No."
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 40
        '
        'colItem
        '
        Me.colItem.Frozen = True
        Me.colItem.HeaderText = "Item Code"
        Me.colItem.Name = "colItem"
        Me.colItem.ReadOnly = True
        Me.colItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItem.Width = 110
        '
        'colDescription
        '
        Me.colDescription.Frozen = True
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 490
        '
        'colDisc
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.colDisc.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDisc.HeaderText = "Disc"
        Me.colDisc.Name = "colDisc"
        Me.colDisc.Width = 60
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAdd.Location = New System.Drawing.Point(729, 250)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add (F1)"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.White
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDelete.Location = New System.Drawing.Point(729, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete (F3)"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnPaste
        '
        Me.btnPaste.BackColor = System.Drawing.Color.White
        Me.btnPaste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPaste.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaste.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnPaste.Location = New System.Drawing.Point(729, 298)
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(75, 23)
        Me.btnPaste.TabIndex = 11
        Me.btnPaste.Text = "Paste"
        Me.btnPaste.UseVisualStyleBackColor = False
        '
        'btnImport
        '
        Me.btnImport.BackColor = System.Drawing.Color.White
        Me.btnImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnImport.Location = New System.Drawing.Point(729, 322)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 12
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = False
        '
        'cmbAutoGenerate
        '
        Me.cmbAutoGenerate.DropDownWidth = 121
        Me.cmbAutoGenerate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAutoGenerate.FormattingEnabled = True
        Me.cmbAutoGenerate.IntegralHeight = False
        Me.cmbAutoGenerate.Items.AddRange(New Object() {"No", "Yes"})
        Me.cmbAutoGenerate.Location = New System.Drawing.Point(101, 167)
        Me.cmbAutoGenerate.Name = "cmbAutoGenerate"
        Me.cmbAutoGenerate.Size = New System.Drawing.Size(48, 21)
        Me.cmbAutoGenerate.TabIndex = 5
        Me.cmbAutoGenerate.Tag = ""
        Me.cmbAutoGenerate.Text = "No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(17, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 420
        Me.Label3.Text = "Auto Generate"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbFilter
        '
        Me.cmbFilter.DropDownWidth = 121
        Me.cmbFilter.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.IntegralHeight = False
        Me.cmbFilter.Items.AddRange(New Object() {"Item", "Disc Group", "Product", "Prodhier1", "Prodhier2", "Prodhier3", "Prodhier4", "Prodhier5", "Member"})
        Me.cmbFilter.Location = New System.Drawing.Point(614, 221)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(105, 21)
        Me.cmbFilter.TabIndex = 8
        Me.cmbFilter.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(562, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 422
        Me.Label7.Text = "Filter by"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTransType
        '
        Me.cmbTransType.DropDownWidth = 121
        Me.cmbTransType.Enabled = False
        Me.cmbTransType.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTransType.FormattingEnabled = True
        Me.cmbTransType.IntegralHeight = False
        Me.cmbTransType.Items.AddRange(New Object() {"Add", "Replace"})
        Me.cmbTransType.Location = New System.Drawing.Point(367, 113)
        Me.cmbTransType.Name = "cmbTransType"
        Me.cmbTransType.Size = New System.Drawing.Size(176, 21)
        Me.cmbTransType.TabIndex = 3
        Me.cmbTransType.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(300, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 13)
        Me.Label8.TabIndex = 424
        Me.Label8.Text = "Trans Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbAssignTo
        '
        Me.cmbAssignTo.DropDownWidth = 121
        Me.cmbAssignTo.Enabled = False
        Me.cmbAssignTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAssignTo.FormattingEnabled = True
        Me.cmbAssignTo.IntegralHeight = False
        Me.cmbAssignTo.Items.AddRange(New Object() {"D1", "D2", "D3", "D4", "D5"})
        Me.cmbAssignTo.Location = New System.Drawing.Point(101, 140)
        Me.cmbAssignTo.Name = "cmbAssignTo"
        Me.cmbAssignTo.Size = New System.Drawing.Size(48, 21)
        Me.cmbAssignTo.TabIndex = 4
        Me.cmbAssignTo.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(44, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 426
        Me.Label9.Text = "Assign to"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Location = New System.Drawing.Point(729, 521)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel (Esc)"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnSave.Location = New System.Drawing.Point(729, 496)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save (F12)"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblRecords
        '
        Me.lblRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRecords.BackColor = System.Drawing.Color.White
        Me.lblRecords.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblRecords.Location = New System.Drawing.Point(602, 547)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(117, 23)
        Me.lblRecords.TabIndex = 438
        Me.lblRecords.Text = "0 records"
        Me.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.White
        Me.txtItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(68, 547)
        Me.txtItem.MaxLength = 200
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(195, 21)
        Me.txtItem.TabIndex = 440
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(20, 544)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 23)
        Me.Label10.TabIndex = 441
        Me.Label10.Text = "Item"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbItem
        '
        Me.cmbItem.DropDownHeight = 1
        Me.cmbItem.DropDownWidth = 1
        Me.cmbItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.IntegralHeight = False
        Me.cmbItem.Items.AddRange(New Object() {"Item", "Disc Group", "Product", "Prodhier1", "Prodhier2", "Prodhier3", "Prodhier4", "Prodhier5"})
        Me.cmbItem.Location = New System.Drawing.Point(68, 546)
        Me.cmbItem.MaxDropDownItems = 1
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(195, 21)
        Me.cmbItem.TabIndex = 442
        Me.cmbItem.Tag = ""
        Me.cmbItem.Visible = False
        '
        'gridAll
        '
        Me.gridAll.AllowUserToAddRows = False
        Me.gridAll.AllowUserToOrderColumns = True
        Me.gridAll.AllowUserToResizeColumns = False
        Me.gridAll.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.gridAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridAll.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gridAll.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.gridAll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.gridAll.ColumnHeadersHeight = 25
        Me.gridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridAll.DefaultCellStyle = DataGridViewCellStyle8
        Me.gridAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.gridAll.EnableHeadersVisualStyles = False
        Me.gridAll.GridColor = System.Drawing.Color.Silver
        Me.gridAll.Location = New System.Drawing.Point(423, 295)
        Me.gridAll.MultiSelect = False
        Me.gridAll.Name = "gridAll"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridAll.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.gridAll.RowHeadersVisible = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAll.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.gridAll.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.gridAll.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridAll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.gridAll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.gridAll.RowTemplate.Height = 20
        Me.gridAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridAll.Size = New System.Drawing.Size(285, 111)
        Me.gridAll.TabIndex = 443
        Me.gridAll.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 400
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn4.HeaderText = "Disc"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'txtMinPayment
        '
        Me.txtMinPayment.BackColor = System.Drawing.Color.White
        Me.txtMinPayment.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinPayment.Location = New System.Drawing.Point(614, 192)
        Me.txtMinPayment.MaxLength = 200
        Me.txtMinPayment.Name = "txtMinPayment"
        Me.txtMinPayment.Size = New System.Drawing.Size(105, 22)
        Me.txtMinPayment.TabIndex = 444
        Me.txtMinPayment.Text = "0"
        Me.txtMinPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(536, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 13)
        Me.Label11.TabIndex = 445
        Me.Label11.Text = "Min. Payment"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(809, 544)
        Me.Label12.TabIndex = 488
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(158, 24)
        Me.lblTitle.TabIndex = 490
        Me.lblTitle.Text = "NEW EVENT PROMO"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEvent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(816, 584)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtMinPayment)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.gridAll)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblRecords)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbAssignTo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbTransType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbAutoGenerate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnPaste)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GridEvent)
        Me.Controls.Add(Me.dtPeriodTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEventName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDiscType)
        Me.Controls.Add(Me.lblDiscType)
        Me.Controls.Add(Me.dtPeriodFrom)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.lblDocNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbItem)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmEvent"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Event Promo"
        CType(Me.GridEvent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDiscType As System.Windows.Forms.ComboBox
    Friend WithEvents lblDiscType As System.Windows.Forms.Label
    Friend WithEvents dtPeriodFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblDocNo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEventName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtPeriodTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridEvent As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPaste As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents cmbAutoGenerate As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTransType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbAssignTo As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblRecords As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbItem As System.Windows.Forms.ComboBox
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridAll As System.Windows.Forms.DataGridView
    Friend WithEvents txtMinPayment As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTitle As Label
End Class
