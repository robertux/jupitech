Public Class cxp
    Private _monto_total As Integer
    Private _descripcion As String
    Private _abono As Integer
    Private _fecha_abono As Integer
    Private _interes As Integer
    Private _saldo As Integer
    Private _proveedor As String
    Public Property Monto_total() As Integer
        Get
            Return _monto_total
        End Get
        Set(ByVal value As Integer)
            _monto_total = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _monto_total = value
        End Set
    End Property
    Public Property Abono() As Integer
        Get
            Return _abono
        End Get
        Set(ByVal value As Integer)
            _abono = value
        End Set
    End Property
    Public Property Fecha_abono() As Integer
        Get
            Return _fecha_abono
        End Get
        Set(ByVal value As Integer)
            _fecha_abono = value
        End Set
    End Property
    Public Property Interes() As Integer
        Get
            Return _interes
        End Get
        Set(ByVal value As Integer)
            _interes = value
        End Set
    End Property
    Public Property Saldo() As Integer
        Get
            Return _saldo
        End Get
        Set(ByVal value As Integer)
            _saldo = value
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
    Sub New(ByVal monto_total As Integer, ByVal descripcion As String, ByVal abono As Integer, ByVal fecha_abono As Integer, ByVal interes As Integer, ByVal saldo As Integer, ByVal proveedor As String)
        Me.Monto_total = monto_total
        Me.Descripcion = descripcion
        Me.Proveedor = proveedor
        Me.Saldo = saldo
        Me.Abono = abono
        Me.Fecha_abono = fecha_abono
        Me.Interes = interes
    End Sub
End Class
