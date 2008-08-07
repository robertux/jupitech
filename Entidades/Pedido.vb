Namespace Entidades
    Public Class Pedido
        Private _fechaEmision As Date
        Private _fechaEntrega As Date
        Private _cliente As Cliente
        Private _estado As String
        Private _codigo As Integer
        Private _items as List(Of ItemPedido)
        
        Public Property Items As List(Of ItemPedido)
        	Get
        		return me._items
        	End Get
        	Set
        		me._items = value
        	End Set
        End Property
        Public Property FechaEmision() As Date
            Get
                Return _fechaEmision
            End Get
            Set(ByVal value As Date)
                _fechaEmision = value
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
        Public Property Estado() As String
            Get
                Return _estado
            End Get
            Set(ByVal value As String)
                _estado = value
            End Set
        End Property
        Public Property Cliente() As Cliente
            Get
                Return _cliente
            End Get
            Set(ByVal value As Cliente)
                _cliente = value
            End Set
        End Property
        Public Property FechaEntrega() As Date
            Get
                Return _fechaEntrega
            End Get
            Set(ByVal value As Date)
                _fechaEntrega = value
            End Set
        End Property
 
 Public Sub New(ByVal fechaEmision As Date, ByVal fechaEntrega As Date, ByVal cliente As Cliente, ByVal estado As String, ByVal codigo As Integer, byval items as List(Of ItemPedido))
            Me.FechaEmision = fechaEmision
            Me.FechaEntrega = fechaEntrega
            Me.Cliente = cliente
            Me.Estado = estado
            Me.Codigo = codigo
            me.Items = items
        End Sub
        
    End Class
End Namespace
