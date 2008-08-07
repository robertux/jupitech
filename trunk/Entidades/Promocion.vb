Namespace Entidades
    Public Class Promocion
        Private _fechaInicio As Date
        Private _fechaFin As Date
        Private _nombre As String
        Private _descuento As Double
        Private _codigo As Integer
        Private _productos As List(Of Producto)
        Private _combos As List(Of Combo)
        
        Public Property FechaInicio() As Date
            Get
                Return _fechaInicio
            End Get
            Set(ByVal value As Date)
                _fechaInicio = value
            End Set
        End Property
        Public Property codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
            End Set
        End Property
        Public Property Descuento() As Double
            Get
                Return _descuento
            End Get
            Set(ByVal value As Double)
                _descuento = value
            End Set
        End Property
        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property
        Public Property FechaFin() As Date
            Get
                Return _fechaFin
            End Get
            Set(ByVal value As Date)
                _fechaFin = value
            End Set
        End Property
        Public Property Productos As List(Of Producto)
        	Get
        		return me._productos
        	End Get
        	Set
        		me._productos = value
        	End Set
        End Property
        Public Property Combos As List(Of Combo)
        	Get
        		return me._combos
        	End Get
        	Set
        		me._combos = value
        	End Set
        End Property
        
        Public Sub New(ByVal fechaInicio As Date, ByVal fechaFin As Date, ByVal nombre As String, ByVal descuento As Double, ByVal codigo As Integer, byval productos as List(Of Producto), byval combos as List(Of Combo))
            Me.codigo = codigo
            Me.Descuento = descuento
            Me.FechaFin = fechaFin
            Me.FechaInicio = fechaInicio
            Me.Nombre = nombre
            Me.Productos = productos
            me.Combos = combos
        End Sub
        
    End Class
End Namespace
