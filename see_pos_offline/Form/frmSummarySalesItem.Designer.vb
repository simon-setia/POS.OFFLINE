<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSummarySalesItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSummarySalesItem))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridAll = New System.Windows.Forms.DataGridView()
        Me.GridSummarySales = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJudul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNettPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CreateXMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.dtTo = New System.Windows.Forms.DateTimePicker()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSummarySales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.gridAll.GridColor = System.Drawing.Color.Silver
        Me.gridAll.Location = New System.Drawing.Point(22, 216)
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
        Me.gridAll.Size = New System.Drawing.Size(254, 111)
        Me.gridAll.TabIndex = 395
        Me.gridAll.Visible = False
        '
        'GridSummarySales
        '
        Me.GridSummarySales.AllowUserToAddRows = False
        Me.GridSummarySales.AllowUserToOrderColumns = True
        Me.GridSummarySales.AllowUserToResizeColumns = False
        Me.GridSummarySales.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSummarySales.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridSummarySales.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridSummarySales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.GridSummarySales.BackgroundColor = System.Drawing.Color.White
        Me.GridSummarySales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridSummarySales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.GridSummarySales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridSummarySales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridSummarySales.ColumnHeadersHeight = 30
        Me.GridSummarySales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridSummarySales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colJudul, Me.colUOM, Me.colQty, Me.colUnitPrice, Me.colNettPrice, Me.colAmount})
        Me.GridSummarySales.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridSummarySales.DefaultCellStyle = DataGridViewCellStyle12
        Me.GridSummarySales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.GridSummarySales.EnableHeadersVisualStyles = False
        Me.GridSummarySales.GridColor = System.Drawing.Color.SteelBlue
        Me.GridSummarySales.Location = New System.Drawing.Point(9, 104)
        Me.GridSummarySales.MultiSelect = False
        Me.GridSummarySales.Name = "GridSummarySales"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridSummarySales.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.GridSummarySales.RowHeadersVisible = False
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSummarySales.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.GridSummarySales.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.GridSummarySales.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridSummarySales.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GridSummarySales.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GridSummarySales.RowTemplate.Height = 25
        Me.GridSummarySales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSummarySales.Size = New System.Drawing.Size(917, 495)
        Me.GridSummarySales.TabIndex = 388
        '
        'colItem
        '
        Me.colItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colItem.HeaderText = "Item"
        Me.colItem.MaxInputLength = 13
        Me.colItem.Name = "colItem"
        Me.colItem.Width = 110
        '
        'colJudul
        '
        Me.colJudul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colJudul.HeaderText = "Description"
        Me.colJudul.MaxInputLength = 255
        Me.colJudul.Name = "colJudul"
        Me.colJudul.Width = 450
        '
        'colUOM
        '
        Me.colUOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colUOM.HeaderText = "UOM"
        Me.colUOM.Name = "colUOM"
        Me.colUOM.Width = 60
        '
        'colQty
        '
        Me.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle8
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 50
        '
        'colUnitPrice
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colUnitPrice.DefaultCellStyle = DataGridViewCellStyle9
        Me.colUnitPrice.HeaderText = "Unit Price"
        Me.colUnitPrice.Name = "colUnitPrice"
        Me.colUnitPrice.Width = 83
        '
        'colNettPrice
        '
        Me.colNettPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colNettPrice.DefaultCellStyle = DataGridViewCellStyle10
        Me.colNettPrice.HeaderText = "Nett Price"
        Me.colNettPrice.Name = "colNettPrice"
        Me.colNettPrice.Width = 90
        '
        'colAmount
        '
        Me.colAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = "0"
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle11
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        Me.colAmount.Width = 90
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateXMLToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(136, 26)
        '
        'CreateXMLToolStripMenuItem
        '
        Me.CreateXMLToolStripMenuItem.Name = "CreateXMLToolStripMenuItem"
        Me.CreateXMLToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.CreateXMLToolStripMenuItem.Text = "Create XML"
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.BackColor = System.Drawing.Color.White
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExport.Location = New System.Drawing.Point(935, 162)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(67, 58)
        Me.btnExport.TabIndex = 384
        Me.btnExport.Text = "Export"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.White
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefresh.Location = New System.Drawing.Point(935, 104)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(67, 58)
        Me.btnRefresh.TabIndex = 383
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.White
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(935, 220)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(67, 58)
        Me.btnPrint.TabIndex = 402
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.UseEXDialog = True
        '
        'cmbGroup
        '
        Me.cmbGroup.DropDownHeight = 1
        Me.cmbGroup.DropDownWidth = 1
        Me.cmbGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.IntegralHeight = False
        Me.cmbGroup.Location = New System.Drawing.Point(330, 75)
        Me.cmbGroup.MaxDropDownItems = 1
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(180, 21)
        Me.cmbGroup.TabIndex = 408
        Me.cmbGroup.Tag = "GROUP"
        Me.cmbGroup.Text = "Any"
        '
        'dtTo
        '
        Me.dtTo.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.CustomFormat = "dd MMMM yyyy"
        Me.dtTo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(171, 75)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(153, 21)
        Me.dtTo.TabIndex = 404
        '
        'dtFrom
        '
        Me.dtFrom.CalendarFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.CustomFormat = "dd MMMM yyyy"
        Me.dtFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrom.Location = New System.Drawing.Point(12, 75)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(153, 21)
        Me.dtFrom.TabIndex = 403
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(513, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 447
        Me.Label1.Text = "Status"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownWidth = 121
        Me.cmbStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.IntegralHeight = False
        Me.cmbStatus.Items.AddRange(New Object() {"Any", "Consignment", "Credit"})
        Me.cmbStatus.Location = New System.Drawing.Point(516, 75)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(129, 21)
        Me.cmbStatus.TabIndex = 446
        Me.cmbStatus.Tag = "STATUS"
        Me.cmbStatus.Text = "Any"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(168, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 445
        Me.Label4.Text = "To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblStatus.Location = New System.Drawing.Point(12, 50)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 23)
        Me.lblStatus.TabIndex = 444
        Me.lblStatus.Text = "From"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(327, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 448
        Me.Label2.Text = "Grouping"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(648, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 23)
        Me.Label5.TabIndex = 450
        Me.Label5.Text = "Payment"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPayment
        '
        Me.cmbPayment.DropDownWidth = 121
        Me.cmbPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.IntegralHeight = False
        Me.cmbPayment.Items.AddRange(New Object() {"Any", "Cash", "Card", "Voucher", "Cash + Card", "Cash + Voucher", "Card + Voucher", "Cash + Card + Voucher"})
        Me.cmbPayment.Location = New System.Drawing.Point(651, 75)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(129, 21)
        Me.cmbPayment.TabIndex = 449
        Me.cmbPayment.Tag = "PAYMENT"
        Me.cmbPayment.Text = "Any"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1008, 614)
        Me.Label3.TabIndex = 487
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 24)
        Me.Label7.TabIndex = 513
        Me.Label7.Text = "SUMMARY SALES ITEM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(984, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 25)
        Me.btnClose.TabIndex = 514
        Me.btnClose.Text = "x"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTotal.Location = New System.Drawing.Point(778, 606)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(148, 26)
        Me.lblTotal.TabIndex = 515
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(690, 611)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 16)
        Me.Label8.TabIndex = 516
        Me.Label8.Text = "Grand Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 13
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.MaxInputLength = 255
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 450
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "UOM"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 59
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C0"
        DataGridViewCellStyle15.NullValue = "0"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 51
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "C0"
        DataGridViewCellStyle16.NullValue = "0"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nett Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 87
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "C0"
        DataGridViewCellStyle17.NullValue = "0"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn6.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 76
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N0"
        DataGridViewCellStyle18.NullValue = "0"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 90
        '
        'frmSummarySalesItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1014, 654)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbPayment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrom)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.gridAll)
        Me.Controls.Add(Me.GridSummarySales)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSummarySalesItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary Sales by Item"
        CType(Me.gridAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSummarySales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridAll As System.Windows.Forms.DataGridView
    Friend WithEvents GridSummarySales As System.Windows.Forms.DataGridView
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CreateXMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJudul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNettPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPayment As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents btnClose As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label8 As Label
End Class
