Namespace Entidades
    Public Class ProdSucursal
        Private _producto As Producto
        Private _sucursal As Sucursal
        Private _existenciaActual As Integer
        Private _existenciaMinima As Integer
        Private _codigo As Integer
        Public Property Producto() As Producto
            Get
                Return _producto
            End Get
            Set(ByVal value As Producto)
                _producto = value
            End Set
        End Property
        Public Property Codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
            End Set
        End Property
        Public Property ExistenciaMinima() As Integer
            Get
                Return _existenciaMinima
            End Get
            Set(ByVal value As Integer)
                _existenciaMinima = value
            End Set
        End Property
        Public Property ExistenciaActual() As Integer
            Get
                Return _existenciaActual
            End Get
            Set(ByVal value As Integer)
                _existenciaActual = value
            End Set
        End Property
        Public Property Sucursal() As Sucursal
            Get
                Return _sucursal
            End Get
            Set(ByVal value As Sucursal)
                _sucursal = value
            End Set
        End Property
        Public Sub New(ByVal producto As Producto, ByVal sucursal As Sucursal, ByVal existenciaActual As Integer, ByVal existenxiaMinima As Integer, ByVal codigo As Integer)
            Me.Producto = producto
            Me.Sucursal = sucursal
            Me.ExistenciaActual = existenciaActual
            Me.ExistenciaMinima = ExistenciaMinima
            Me.Codigo = codigo
        End Sub
    End Class
End Namespace
