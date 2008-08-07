Namespace Entidades
    Public Class Producto
        Private _nombre As String
        Private _descripcion As String
        Private _marca As String
        Private _modelo As String
        Private _tipo As TipoProducto
        Private _imagen As String
        Private _codigo As Integer
        Private _costos As List(Of CostoProducto)
        Private _precios As List(Of PrecioProducto)
        private _promocion as Promocion
        
        Public Property Promocion As Promocion
        	Get
        		return me._promocion
        	End Get
        	Set
        		me._promocion = value
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
        Public Property Descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property
        Public Property Tipo() As TipoProducto
            Get
                Return _tipo
            End Get
            Set(ByVal value As TipoProducto)
                _tipo = value
            End Set
        End Property
        Public Property Imagen() As String
            Get
                Return _imagen
            End Get
            Set(ByVal value As String)
                _imagen = value
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
        Public Property costos() As List(Of CostoProducto)
            Get
                Return _costos
            End Get
            Set(ByVal value As List(Of CostoProducto))
                _costos = value
            End Set
        End Property
        Public Property precios() As List(Of PrecioProducto)
            Get
                Return _precios
            End Get
            Set(ByVal value As List(Of PrecioProducto))
                _precios = value
            End Set
        End Property
        Public Property marca() As String
            Get
                Return _marca
            End Get
            Set(ByVal value As String)
                _marca = value
            End Set
        End Property
        Public Property modelo() As String
            Get
                Return _modelo
            End Get
            Set(ByVal value As String)
                _modelo = value
            End Set
        End Property
        
        Public Sub New(ByVal nombre As String, ByVal descripcion As String, ByVal marca As String, ByVal modelo As String, ByVal tipo As TipoProducto, ByVal imagen As String, ByVal codigo As Integer, byval costos as List(Of CostoProducto), byval precios as List(Of PrecioProducto), byval promocion as Promocion)
            Me.Nombre = nombre
            Me.Descripcion = descripcion
            Me.Tipo = tipo
            Me.marca = marca
            Me.modelo = modelo
            Me.Imagen = imagen
            Me.Codigo = codigo
            Me.costos = costos
            Me.Precios = precios
            me.Promocion = promocion
        End Sub

        Public Function preciopromedio()
            Dim promedio As Double
            For Each p As PrecioProducto In Me.precios
                promedio += p.Monto
            Next
            Return promedio / Me.precios.Count
        End Function

        Public Function costopromedio()
            Dim promedio As Double
            For Each c As CostoProducto In Me.costos
                promedio += c.Monto
            Next
            Return promedio / Me.costos.Count
        End Function


    End Class
End Namespace
