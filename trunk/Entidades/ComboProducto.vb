namespace Entidades
	Public Class ComboProducto
		
		Private _combo As Combo
		Private _producto As Producto
		Private _codigo As Integer
		
		Public Property Combo As Combo
			Get
				return me._combo
			End Get
			Set
				me._combo = value
			End Set
		End Property
		Public Property Producto As Producto
			Get
				return me._producto
			End Get
			Set
				me._producto = value
			End Set
		End Property
		Public Property Codigo As Integer
			Get
				return me._codigo
			End Get
			Set
				me._codigo = value
			End Set
		End Property

		Public Sub New(ByVal combo As Combo, ByVal producto As Producto, ByVal codigo As Integer)
			Me.Combo = combo
			Me.Producto = producto
			me.Codigo = codigo
		End Sub
	End Class
end namespace
