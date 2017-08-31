<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidateMember
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
        Me.txtMember = New System.Windows.Forms.TextBox()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.memberPic = New System.Windows.Forms.PictureBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.memberPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtMember
        '
        Me.txtMember.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMember.BackColor = System.Drawing.Color.White
        Me.txtMember.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMember.Location = New System.Drawing.Point(99, 91)
        Me.txtMember.MaxLength = 20
        Me.txtMember.Name = "txtMember"
        Me.txtMember.Size = New System.Drawing.Size(285, 27)
        Me.txtMember.TabIndex = 398
        '
        'lblNote
        '
        Me.lblNote.BackColor = System.Drawing.Color.White
        Me.lblNote.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNote.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNote.Location = New System.Drawing.Point(106, 61)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(166, 24)
        Me.lblNote.TabIndex = 399
        Me.lblNote.Text = "Please input member code"
        Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'memberPic
        '
        Me.memberPic.BackColor = System.Drawing.Color.White
        Me.memberPic.Location = New System.Drawing.Point(16, 71)
        Me.memberPic.Name = "memberPic"
        Me.memberPic.Size = New System.Drawing.Size(81, 68)
        Me.memberPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.memberPic.TabIndex = 400
        Me.memberPic.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCancel.Location = New System.Drawing.Point(326, 124)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 27)
        Me.btnCancel.TabIndex = 402
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.BackColor = System.Drawing.Color.White
        Me.btnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnApply.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnApply.Location = New System.Drawing.Point(252, 124)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(75, 27)
        Me.btnApply.TabIndex = 401
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(391, 130)
        Me.Label12.TabIndex = 490
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.SteelBlue
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(179, 24)
        Me.lblTitle.TabIndex = 516
        Me.lblTitle.Text = "VALIDATE MEMBER"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmValidateMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(398, 163)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblapplicationSettings.Title)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.memberPic)
        Me.Controls.Add(Me.lblNote)
        Me.Controls.Add(Me.txtMember)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmValidateMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check Member"
        CType(Me.memberPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMember As System.Windows.Forms.TextBox
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents memberPic As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblTitle As Label
End Class
