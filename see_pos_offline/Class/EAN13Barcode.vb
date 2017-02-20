' ///////////////          EAN13 Barcode Component          \\\\\\\\\\\\\\\ '
' ///////////////             By: Tammam Koujan             \\\\\\\\\\\\\\\ '
' /////////////// http://www.enashir.com/blogs/TammamKoujan  \\\\\\\\\\\\\\\ '
' ///////////////          email:tammamkoujan@gmail.com          \\\\\\\\\\\\\\\ '
' ///////////////     UAE - Dubai , Mobile : 050 6772279     \\\\\\\\\\\\\\\ '
' ///////////////       Free Component With Source Code       \\\\\\\\\\\\\\\ '
' /////////////// Please do not remove my Name or my Address \\\\\\\\\\\\\\\ '
' ///////////////                   enjoy                     \\\\\\\\\\\\\\\ '

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Public Class EAN13Barcode
    Inherits UserControl

#Region "Consts"
    Const StartMark As String = "101"
    Const SplittingMark As String = "01010"
    Const EndMark As String = "101"

#End Region

#Region "Declarations"
    Private Structure Ean13Tables
        Public TableA As String
        Public TableB As String
        Public TableC As String
    End Structure
    Private Tables(0 To 9) As Ean13Tables
    Private BarcodeValue As StringBuilder
#End Region

    Private M_BarWidth As Double
    <ComponentModel.Category("Appearance"),
         ComponentModel.Description("rrrrrr")>
    Public Property BarWidth() As Double
        Get
            Return M_BarWidth
        End Get
        Set(ByVal value As Double)
            M_BarWidth = value
        End Set
    End Property

    Private M_BarHeight As Double
    <ComponentModel.Category("Appearance"),
         ComponentModel.Description("rrrrrr")>
    Public Property BarHeight() As Double
        Get
            Return M_BarHeight
        End Get
        Set(ByVal value As Double)
            M_BarHeight = value
        End Set
    End Property

    Private m_BarcodeText As String
    <ComponentModel.Category("Barcode"),
     ComponentModel.Description("The Barcode Value" & vbCrLf & "must consist of 12 digit"),
     ComponentModel.RefreshProperties(ComponentModel.RefreshProperties.All)>
    Public Property Value() As String 'Overrides
        Get
            Return m_BarcodeText
        End Get
        Set(ByVal value As String)
            If (value.Length = 12) And (IsNumeric(value)) Then
                m_BarcodeText = value
                Me.Refresh()
            ElseIf (value.Length <> 12) Then
                InitBarcode()
                Throw New Exception("EAN13 Barcode Must Consist Of 12 Digits")
            ElseIf Not (IsNumeric(value)) Then
                InitBarcode()
                Throw New Exception("EAN13 Barcode Must Consist Of Digits Only")

            End If
        End Set
    End Property

    Private m_ShowBarcodeText As Boolean
    <ComponentModel.Category("Barcode"),
     ComponentModel.Description("show Barcode value under barcode bars"),
     ComponentModel.RefreshProperties(ComponentModel.RefreshProperties.All)>
    Public Property ShowBarcodeText() As Boolean 'Overrides
        Get
            Return m_ShowBarcodeText
        End Get
        Set(ByVal value As Boolean)
            m_ShowBarcodeText = value
            Me.Refresh()
        End Set
    End Property

    Private m_ShowCheckSum As Boolean
    <ComponentModel.Category("Barcode"),
     ComponentModel.Description("show check sum value under barcode bars"),
     ComponentModel.RefreshProperties(ComponentModel.RefreshProperties.All)>
    Public Property ShowCheckSum() As Boolean 'Overrides
        Get
            Return m_ShowCheckSum
        End Get
        Set(ByVal value As Boolean)
            m_ShowCheckSum = value
            Me.Refresh()
        End Set
    End Property

    Private m_CheckSum As Byte
    <ComponentModel.Category("Barcode"),
     ComponentModel.Description("Check Digit Value")>
    Public ReadOnly Property CheckSum() As Byte
        Get
            CalculateCheckSum()
            Return m_CheckSum
        End Get
    End Property

    <ComponentModel.Category("About"),
     ComponentModel.Description("About EAN13 Component")>
    Public ReadOnly Property About() As String

        Get
            Return "Tammam Koujan http://www.enashir.com/blogs/TammamKoujan email:Tammam84@yahoo.com"
        End Get
    End Property



    Public Sub New()
        Me.ResizeRedraw = True
        InitBarcode()
        InitEAN13Tables()
        M_BarWidth = 0.33 ' mm
        Me.Font = New Font("Arial", 18)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Init Procedures"

    Private Sub InitBarcode()
        m_BarcodeText = "000000000000"
    End Sub

    Public Sub InitEAN13Tables()
        '          Zero
        Tables(0).TableA = "0001101"
        Tables(0).TableB = "0100111"
        Tables(0).TableC = "1110010"
        '          One
        Tables(1).TableA = "0011001"
        Tables(1).TableB = "0110011"
        Tables(1).TableC = "1100110"
        '          Two
        Tables(2).TableA = "0010011"
        Tables(2).TableB = "0011011"
        Tables(2).TableC = "1101100"
        '          Three
        Tables(3).TableA = "0111101"
        Tables(3).TableB = "0100001"
        Tables(3).TableC = "1000010"
        '          Four
        Tables(4).TableA = "0100011"
        Tables(4).TableB = "0011101"
        Tables(4).TableC = "1011100"
        '          Five
        Tables(5).TableA = "0110001"
        Tables(5).TableB = "0111001"
        Tables(5).TableC = "1001110"
        '          Six
        Tables(6).TableA = "0101111"
        Tables(6).TableB = "0000101"
        Tables(6).TableC = "1010000"
        '          Seven
        Tables(7).TableA = "0111011"
        Tables(7).TableB = "0010001"
        Tables(7).TableC = "1000100"
        '          Eight
        Tables(8).TableA = "0110111"
        Tables(8).TableB = "0001001"
        Tables(8).TableC = "1001000"
        '          Nine
        Tables(9).TableA = "0001011"
        Tables(9).TableB = "0010111"
        Tables(9).TableC = "1110100"

    End Sub

#End Region

    Private Function CalculateCheckSum() As Boolean
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim j As Integer = 11
        Try
            For i As Integer = 1 To 12
                If i Mod 2 = 0 Then
                    X += Val(m_BarcodeText(j))
                Else
                    Y += Val(m_BarcodeText(j))
                End If
                j -= 1
            Next

            Dim Z As Integer = X + (3 * Y)
            'first way
            m_CheckSum = ((10 - (Z Mod 10)) Mod 10)
            'second way
            'Dim M As Integer = Z
            ' Do Until (M Mod 10 = 0)
            'M += 1
            ' Loop
            'm_CheckSum = M - Z

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Function CalculateValue() As Boolean
        ' Clear any previous Value
        BarcodeValue = New StringBuilder(95)
        Try
            ' Add The Start Mark
            BarcodeValue.Append(StartMark)
            Select Case m_BarcodeText(0)
                Case "0"
                    For i As Integer = 1 To 6
                        BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                    Next
                Case "1"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 2) Or (i = 4) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "2"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 2) Or (i = 5) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "3"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 2) Or (i = 6) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "4"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 3) Or (i = 4) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "5"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 4) Or (i = 5) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "6"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 5) Or (i = 6) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "7"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 3) Or (i = 5) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "8"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 3) Or (i = 6) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
                Case "9"
                    For i As Integer = 1 To 6
                        If (i = 1) Or (i = 4) Or (i = 6) Then
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableA)
                        Else
                            BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableB)
                        End If
                    Next
            End Select
            ' Add The Splitting Mark
            BarcodeValue.Append(SplittingMark)

            For i As Integer = 7 To (m_BarcodeText.Length - 1)
                BarcodeValue.Append(Tables(Val(m_BarcodeText(i))).TableC)
            Next
            ' Add Checksum
            BarcodeValue.Append(Tables(CheckSum).TableC)
            ' Add The End Mark
            BarcodeValue.Append(EndMark)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Private Sub DrawBarcodeText(ByVal e As PaintEventArgs)


        ' Create font and brush. 
        'Dim drawFont As New Font("Arial", 18)
        Dim drawFont = Me.Font
        Dim drawBrush As New SolidBrush(Me.ForeColor)

        ' Create rectangle for drawing. 
        Dim x As Single = 3.61
        Dim y As Single = (30 + (5 * 0.33F)) '31.4F

        ' Create string to draw. 
        Dim drawString As [String] = m_BarcodeText
        If ShowCheckSum = True Then
            drawString += CheckSum.ToString()
            x -= 1.2F
        End If

        ' Measure string. 
        Dim stringSize As New SizeF
        stringSize = e.Graphics.MeasureString(drawString, drawFont)

        Dim drawRect As New RectangleF(x, y, stringSize.Width, stringSize.Height)

        ' Set format of string. 
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Center


        ' Draw string to screen.
        e.Graphics.DrawString(drawString, drawFont, drawBrush,
        drawRect, drawFormat)
    End Sub

    Private Sub EAN13Barcode_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        CalculateValue()
        ' Change the page scale.  
        e.Graphics.PageUnit = GraphicsUnit.Millimeter
        ' Dim units As GraphicsUnit = GraphicsUnit.Millimeter
        Dim s As Single = 3
        For i As Integer = 0 To 94
            If BarcodeValue(i) = "1" Then
                Select Case i
                    ' Case 94
                    '    e.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), s + 0.2F, 10, 0.33F, (15 + (5 * 0.33F)))
                    Case 0, 1, 2, 45, 46, 47, 48, 49, 92, 93, 94
                        e.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), s + 0.11F, 10, 0.5F, (20 + (5 * 0.33F)))
                    Case Else
                        e.Graphics.FillRectangle(New SolidBrush(Me.ForeColor), s + 0.11F, 10, 0.5F, 20)
                End Select
            ElseIf BarcodeValue(i) = "0" Then
                Select Case i
                    Case 0, 1, 2, 45, 46, 47, 48, 49, 92, 93, 94
                        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), s + 0.11F, 10, 0.5F, (20 + (5 * 0.33F)))
                    Case Else
                        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), s + 0.11F, 10, 0.5F, 20)
                End Select
            End If

            s += 0.5F
        Next

        If ShowBarcodeText = True Then
            DrawBarcodeText(e)
        End If

    End Sub

    ''' <summary>
    ''' Print the control's view to a Graphics object.
    ''' </summary>
    ''' <param name="graphics">Graphics object to draw on.</param>
    ''' <param name="bounds">Rectangle to print in.</param>
    Public Sub PrintToGraphics(graphics As Graphics, bounds As Rectangle)
        Dim bitmap As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bitmap, New Rectangle(0, 0, bitmap.Width, bitmap.Height))
        Dim target As New Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height)
        Dim xScale As Double = CDbl(bitmap.Width) / bounds.Width
        Dim yScale As Double = CDbl(bitmap.Height) / bounds.Height
        If xScale < yScale Then
            target.Width = CInt(Math.Truncate(xScale * target.Width / yScale))
        Else
            target.Height = CInt(Math.Truncate(yScale * target.Height / xScale))
        End If
        graphics.PageUnit = GraphicsUnit.Display
        graphics.DrawImage(bitmap, target)
    End Sub

End Class






