Imports System.ComponentModel

Public Class MovementLine
    Implements INotifyPropertyChanged, IDataErrorInfo

#Region "Variabel"

    Private _partnumber As String
    Private _description As String
    Private _product As String
    Private _uom As String
    Private _qty As Integer
    Private _note As String
    Private _vendor As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

#Region "Constructor"
    Public Sub MovementLine()

        _partnumber = ""
        _description = ""
        _product = ""
        _uom = ""
        _qty = 0
        _note = ""
        _vendor = ""
    End Sub
#End Region

#Region "Property"

    Public Property Partnumber() As String
        Get
            Return _partnumber
        End Get
        Set(value As String)
            _partnumber = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property Product() As String
        Get
            Return _product
        End Get
        Set(value As String)
            _product = value
        End Set

    End Property

    Public Property UOM() As String
        Get
            Return _uom
        End Get
        Set(value As String)
            _uom = value
        End Set

    End Property

    Public Property Qty() As Integer
        Get
            Return _qty
        End Get
        Set(value As Integer)
            _qty = value
        End Set

    End Property

    Public Property Note() As String
        Get
            Return _note
        End Get
        Set(value As String)
            _note = value
        End Set

    End Property

    Public Property Vendor() As String
        Get
            Return _vendor
        End Get
        Set(value As String)
            _vendor = value
        End Set
    End Property

    Default Public ReadOnly Property Item(name As String) As String Implements IDataErrorInfo.Item
        Get
            Dim result As String = Nothing

            If name = "Partnumber" Then
                If IsDBNull(_partnumber) Then

                    result += "Partnumber can't blank" + vbCrLf
                End If
            ElseIf name = "Description" Then
                result += "Description can't blank" + vbCrLf
            ElseIf name = "Qty" Then

                If _qty = 0 Then
                    result += "Qty must more than 0" + vbCrLf
                End If

            End If

            Return result

        End Get
    End Property

    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Private Sub OnPropertyChanged(Name As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(Name))
    End Sub

#End Region




End Class
