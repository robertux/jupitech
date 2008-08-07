Namespace Entidades
    Public Class Transaccion
        Private _fecha As Date
        Private _sucursal as Sucursal
        Private _tipo As String
        Private _tipoPago As String
        Private _codigo As Integer
        Private _documento As DocumentoPago
        Private _items As List(Of ItemTransaccion)
        
        Public Property Codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
            End Set
        End Property
        Public Property TipoPago() As String
            Get
                Return _tipoPago
            End Get
            Set(ByVal value As String)
                _tipoPago = value
            End Set
        End Property
        Public Property Tipo() As String
            Get
                Return _tipo
            End Get
            Set(ByVal value As String)
                _tipo = value
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
        Public Property Documento as DocumentoPago
        	Get
        		return me._documento
        	End Get
        	Set
        		me._documento = value
        	End Set
        End Property
        Public Property Items As List(Of ItemTransaccion)
        	Get
        		return me._items
        	End Get
        	Set
        		me._items = value
        	End Set
        End Property
        Public Property Sucursal() As Sucursal
            Get
                Return Me._sucursal
            End Get
            Set(ByVal value As Sucursal)
                Me._sucursal = Value
            End Set
        End Property

        Public Sub New(ByVal fecha As Date, ByVal sucursal As Sucursal, ByVal tipo As String, ByVal tipoPago As String, ByVal documento As DocumentoPago, ByVal codigo As Integer, ByVal items As List(Of ItemTransaccion))
            Me.Fecha = fecha
            Me.Sucursal = sucursal
            Me.Tipo = tipo
            Me.TipoPago = tipoPago
            Me.Documento = documento
            Me.Codigo = codigo
            Me.Items = items
        End Sub
        
        Public Function GetTotal() As Double
            Dim total As Double = 0
        	For Each i As Item In Me.Items
        		total+= i.GetTotal()
        	Next
        	return total
        End Function

    End Class
End Namespace
