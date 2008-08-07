Public Class devoluciones
    Private _codigo As String
    Private _producto As String
    Private _numero_dev As String
    Private _motivo As String
    Private _proveedor As String
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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
    Public Property Numero_dev() As String
        Get
            Return _numero_dev
        End Get
        Set(ByVal value As String)
            _numero_dev = value
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
    Public Property Proveedor() As String
        Get
            Return _proveedor
        End Get
        Set(ByVal value As String)
            _proveedor = value
        End Set
    End Property
    Sub New(ByVal codigo As String, ByVal producto As String, ByVal numero_dev As String, ByVal motivo As String, ByVal proveedor As String)
        Me.Codigo = codigo
        Me.Producto = producto
        Me.Numero_dev = numero_dev
        Me.Motivo = motivo
        Me.Proveedor = proveedor
    End Sub


End Class

