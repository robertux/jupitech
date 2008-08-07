Namespace Entidades
    Public Class DocumentoPago
    	
        Private _tipo As String
        Private _numero As Integer
        Private _formato As String
        Private _codigo As Integer
        Private _cliente As Integer
        
        Public Property Cliente() As Integer
            Get
                Return Me._cliente
            End Get
            Set(ByVal value As Integer)
                Me._cliente = Value
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
        Public Property Codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
            End Set
        End Property
        Public Property Formato() As String
            Get
                Return _formato
            End Get
            Set(ByVal value As String)
                _formato = value
            End Set
        End Property
        Public Property Numero() As Integer
            Get
                Return _numero
            End Get
            Set(ByVal value As Integer)
                _numero = value
            End Set
        End Property
        
        Public Sub New(ByVal tipo As String, ByVal numero As Integer, ByVal formato As String, ByVal codigo As Integer, ByVal cliente As Integer)
            Me.Codigo = codigo
            Me.Formato = formato
            Me.Numero = numero
            Me.Tipo = tipo
            Me.Cliente = cliente
        End Sub
        
    End Class
End Namespace
