Namespace Entidades
    Public Class ProveedorProducto
    	
    	Private _proveedor as Proveedor
        Private _producto As Producto
       Private _cantidad as integer
        Private _codigo As Integer

	Public Property Proveedor As Proveedor
		Get
			return me._proveedor
		End Get
		Set
			me._proveedor = value
		End Set
	End Property
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
        Public Property Cantidad() As Integer
            Get
                Return _cantidad
            End Get
            Set(ByVal value As integer)
                _cantidad = value
            End Set
        End Property

        Public Sub New(ByVal proveedor as Proveedor, ByVal producto As Producto, ByVal cantidad As integer, ByVal codigo As Integer)
		me.Proveedor = proveedor
            Me.Producto = producto
            me.Cantidad = cantidad
            Me.Codigo = codigo
        End Sub
 
 End Class
End Namespace
