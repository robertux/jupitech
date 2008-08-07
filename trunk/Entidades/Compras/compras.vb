Public Class compras
    Private _codigo As String
    Private _fecha As Date
    Private _producto As String
    Private _numero As Integer
    Private _costo_unit As Integer
    Private _costo_total As Integer
    Private _subtotal As Integer
    Private _total As Integer
    Private _proveedor As String
    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
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
    Public Property Producto() As String
        Get
            Return _producto
        End Get
        Set(ByVal value As String)
            _producto = value
        End Set
    End Property
    Public Property Numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property
    Public Property Costo_unit() As Integer
        Get
            Return _costo_unit
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property
    Public Property Costo_total() As Integer
        Get
            Return _costo_total
        End Get
        Set(ByVal value As Integer)
            _costo_total = value
        End Set
    End Property
    Public Property Subtotal() As Integer
        Get
            Return _subtotal
        End Get
        Set(ByVal value As Integer)
            _subtotal = value
        End Set
    End Property
    Public Property Total() As Integer
        Get
            Return _total
        End Get
        Set(ByVal value As Integer)
            _codigo = value
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
    Sub New(ByVal codigo As String, ByVal fecha As Date, ByVal producto As String, ByVal numero As Integer, ByVal costo_unit As Integer, ByVal cost_total As Integer, ByVal subtotal As Integer, ByVal total As Integer, ByVal proveedor As String)
        Me.Codigo = codigo
        Me.Fecha = fecha
        Me.Costo_total = costo_unit
        Me.Costo_unit = Costo_total
        Me.Producto = producto
        Me.Numero = numero
        Me.Proveedor = proveedor
        Me.Subtotal = subtotal
        Me.Total = total
    End Sub

End Class
