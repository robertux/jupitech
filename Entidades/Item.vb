Namespace Entidades
    Public Class Item
        Private _codigo As Integer
        Private _producto As Producto
        Private _cantidad As Integer
        
        Public Property Codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
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
        Public Property Cantidad() As Integer
            Get
                Return _cantidad
            End Get
            Set(ByVal value As Integer)
                _cantidad = value
            End Set
        End Property
 
 Public Sub New(ByVal codigo As Integer, ByVal producto As Producto, ByVal cantidad As Integer)
            Me.Codigo = codigo
            Me.Producto = producto
            Me.Cantidad = cantidad
        End Sub

Public Function GetTotal() as Double
		'FIXME: arreglar esta linea return me.Producto * me.Cantidad
		'TODO: para arreglarla hay que implementar el metodo PrecioPromedio() en la clase Producto
End Function

    End Class
End Namespace
