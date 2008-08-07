Namespace Entidades
    Public Class Devolucion
        Private _fechaDevolucion As Date
        Private _tipoCompensacion As String
        Private _codigo As Integer
        Private _motivo As String
        Private _venta As Venta
        private _items as List(Of ItemDevolucion)

	Public Property Items As List(Of ItemDevolucion)
		Get
			return me._items
		End Get
		Set
			me._items = value
		End Set
	End Property
	Public Property Venta As Venta
		Get
			return me._venta
		End Get
		Set
			me._venta = value
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
        Public Property FechaDevolucion() As Date
            Get
                Return _fechaDevolucion
            End Get
            Set(ByVal value As Date)
                _fechaDevolucion = value
            End Set
        End Property
        Public Property Motivo() As String
            Get
                Return _motivo
            End Get
            Set(ByVal value As String)
                _motivo = value
            End Set
        End Property
        Public Property TipoCompensacion() As String
            Get
                Return _tipoCompensacion
            End Get
            Set(ByVal value As String)
                _tipoCompensacion = value
            End Set
        End Property

        Public Sub New(ByVal fechaDevolucion As Date, ByVal tipoCompensacion As String, ByVal codigo As Integer, ByVal motivo As String, byval venta as Venta, byval items as List(Of ItemDevolucion))
            Me.FechaDevolucion = fechaDevolucion
            Me.TipoCompensacion = tipoCompensacion
            Me.Codigo = codigo
            Me.Motivo = motivo
            Me.Venta = venta
            me.Items = items
        End Sub
 
    End Class
End Namespace

