namespace Entidades
	Public Class ItemPedido
		Inherits Item
		
        Private _pedido As Integer
		
        Public Property Pedido() As Integer
            Get
                Return Me._pedido
            End Get
            Set(ByVal value As Integer)
                Me._pedido = Value
            End Set
        End Property
		
        Public Sub New(ByVal codigo As Integer, ByVal producto As Producto, ByVal cantidad As Integer, ByVal pedido As Integer)
            MyBase.New(codigo, producto, cantidad)
            Me.Pedido = pedido
        End Sub
	End Class
end namespace
