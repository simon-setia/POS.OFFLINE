<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTesting
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EaN13Barcode1 = New SEE_POS_OFFLINE.EAN13Barcode()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Code EAN13", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        '
        'EaN13Barcode1
        '
        Me.EaN13Barcode1.BarHeight = 0R
        Me.EaN13Barcode1.BarWidth = 0.33R
        Me.EaN13Barcode1.Font = New System.Drawing.Font("Arial", 18.0!)
        Me.EaN13Barcode1.Location = New System.Drawing.Point(214, 58)
        Me.EaN13Barcode1.Name = "EaN13Barcode1"
        Me.EaN13Barcode1.ShowBarcodeText = True
        Me.EaN13Barcode1.ShowCheckSum = True
        Me.EaN13Barcode1.Size = New System.Drawing.Size(207, 150)
        Me.EaN13Barcode1.TabIndex = 2
        Me.EaN13Barcode1.Value = "000000000000"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(221, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(157, 20)
        Me.TextBox2.TabIndex = 4
        '
        'FormTesting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 261)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EaN13Barcode1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "FormTesting"
        Me.Text = "FormTesting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents EaN13Barcode1 As EAN13Barcode
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
