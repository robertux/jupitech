namespace Entidades
	Public Class ItemDevolucion
		Inherits Item
		
        Private _devolucion As Integer
		
        Public Property Devolucion() As Integer
            Get
                Return Me._devolucion
            End Get
            Set(ByVal value As Integer)
                Me._devolucion = Value
            End Set
        End Property
		
        Public Sub New(ByVal codigo As Integer, ByVal producto As Producto, ByVal cantidad As Integer, ByVal devolucion As Integer)
            MyBase.New(codigo, producto, cantidad)
            Me.Devolucion = devolucion
        End Sub
	End Class
end namespace
