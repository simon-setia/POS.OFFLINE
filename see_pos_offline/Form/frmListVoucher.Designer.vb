<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListVoucher
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridVoucher = New System.Windows.Forms.DataGridView()
        Me.colNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVoucherId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contextVoucher = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.removeVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GridVoucher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextVoucher.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridVoucher
        '
        Me.GridVoucher.AllowUserToAddRows = False
        Me.GridVoucher.AllowUserToOrderColumns = True
        Me.GridVoucher.AllowUserToResizeColumns = False
        Me.GridVoucher.AllowUserToResizeRows = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridVoucher.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.GridVoucher.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridVoucher.BackgroundColor = System.Drawing.Color.White
        Me.GridVoucher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridVoucher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GridVoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVoucher.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridVoucher.ColumnHeadersHeight = 30
        Me.GridVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridVoucher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNo, Me.colVoucherId, Me.colItem, Me.colDisc})
        Me.GridVoucher.ContextMenuStrip = Me.contextVoucher
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridVoucher.DefaultCellStyle = DataGridViewCellStyle12
        Me.GridVoucher.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.GridVoucher.EnableHeadersVisualStyles = False
        Me.GridVoucher.GridColor = System.Drawing.Color.Silver
        Me.GridVoucher.Location = New System.Drawing.Point(12, 37)
        Me.GridVoucher.MultiSelect = False
        Me.GridVoucher.Name = "GridVoucher"
        Me.GridVoucher.RowHeadersVisible = False
        Me.GridVoucher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridVoucher.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridVoucher.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GridVoucher.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.GridVoucher.RowTemplate.Height = 25
        Me.GridVoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridVoucher.Size = New System.Drawing.Size(513, 241)
        Me.GridVoucher.TabIndex = 415
        '
        'colNo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colNo.DefaultCellStyle = DataGridViewCellStyle10
        Me.colNo.Frozen = True
        Me.colNo.HeaderText = "No."
        Me.colNo.Name = "colNo"
        Me.colNo.ReadOnly = True
        Me.colNo.Width = 40
        '
        'colVoucherId
        '
        Me.colVoucherId.Frozen = True
        Me.colVoucherId.HeaderText = "Voucher Id"
        Me.colVoucherId.Name = "colVoucherId"
        '
        'colItem
        '
        Me.colItem.Frozen = True
        Me.colItem.HeaderText = "Voucher Code"
        Me.colItem.Name = "colItem"
        Me.colItem.ReadOnly = True
        Me.colItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItem.Width = 250
        '
        'colDisc
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = "0"
        Me.colDisc.DefaultCellStyle = DataGridViewCellStyle11
        Me.colDisc.HeaderText = "Amount"
        Me.colDisc.Name = "colDisc"
        '
        'contextVoucher
        '
        Me.contextVoucher.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.removeVoucher})
        Me.contextVoucher.Name = "contextVoucher"
        Me.contextVoucher.Size = New System.Drawing.Size(118, 26)
        '
        'removeVoucher
        '
        Me.removeVoucher.Name = "removeVoucher"
        Me.removeVoucher.Size = New System.Drawing.Size(117, 22)
        Me.removeVoucher.Text = "Remove"
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "No."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Voucher Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 60
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(531, 262)
        Me.Label11.TabIndex = 442
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.BackColor = System.Drawing.Color.SteelBlue
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(509, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 25)
        Me.btnClose.TabIndex = 515
        Me.btnClose.Text = "x"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 24)
        Me.Label3.TabIndex = 516
        Me.Label3.Text = "VOUCHER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmListVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(537, 298)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GridVoucher)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListVoucher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.GridVoucher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextVoucher.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridVoucher As System.Windows.Forms.DataGridView
    Friend WithEvents contextVoucher As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents removeVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVoucherId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Private WithEvents btnClose As Button
    Friend WithEvents Label3 As Label
End Class
