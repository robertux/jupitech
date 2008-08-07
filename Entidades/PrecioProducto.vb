Namespace Entidades
    Public Class PrecioProducto
        Private _fecha As Date
        Private _monto As Double
        Private _codigo As Integer
        Private _producto As Integer
        
        Public Property Producto() As Integer
            Get
                Return Me._producto
            End Get
            Set(ByVal value As Integer)
                Me._producto = Value
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
        Public Property Monto() As Double
            Get
                Return _monto
            End Get
            Set(ByVal value As Double)
                _monto = value
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
        
        Public Sub New(ByVal fecha As Date, ByVal monto As Double, ByVal codigo As Integer, ByVal producto As Integer)
            Me.Fecha = fecha
            Me.Monto = monto
            Me.Codigo = codigo
            Me.Producto = producto
        End Sub

    End Class
End Namespace
