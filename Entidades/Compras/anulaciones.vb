Public Class anulaciones
    Private _numero As String
    Private _fecha As Date
    Private _producto As String
    Private _motivo As String
    Private _proveedor As String
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property
    Public Property Producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal value As String)
            _producto = value
        End Set
    End Property
    Public Property Motivo() As String
        Get
            Return _motivo
        End Get
        Set(ByVal value As String)
            _motivo = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property
    Sub New(ByVal numero As String, ByVal fecha As Date, ByVal producto As String, ByVal motivo As String, ByVal proveedor As String)
        Me.Fecha = fecha
        Me.Motivo = motivo
        Me.Numero = numero
        Me.Producto = producto
        Me.Proveedor = proveedor
    End Sub

End Class
