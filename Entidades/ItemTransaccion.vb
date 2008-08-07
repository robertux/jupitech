namespace Entidades
	Public Class ItemTransaccion
		Inherits Item
		
        Private _transaccion As Integer
		
        Public Property Transaccion() As Integer
            Get
                Return Me._transaccion
            End Get
            Set(ByVal value As Integer)
                Me._transaccion = Value
            End Set
        End Property
		
        Public Sub New(ByVal codigo As Integer, ByVal producto As Producto, ByVal cantidad As Integer, ByVal transaccion As Integer)
            MyBase.New(codigo, producto, cantidad)
            Me.Transaccion = transaccion
        End Sub
	End Class
end namespace
