Namespace Entidades
    Public Class Telefono
        Private _tipo As String
        Private _numero As Integer
        Private _codigo As Integer
        Private _persona As Integer
        
        Public Property Persona() As Integer
            Get
                Return Me._persona
            End Get
            Set(ByVal value As Integer)
                Me._persona = Value
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
        Public Property Numero() As Integer
            Get
                Return _numero
            End Get
            Set(ByVal value As Integer)
                _numero = value
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
        
        Public Sub New(ByVal tipo As String, ByVal numero As Integer, ByVal codigo As Integer, ByVal persona As Integer)
            Me.Tipo = tipo
            Me.Numero = numero
            Me.Codigo = codigo
            Me.Persona = persona
        End Sub
    End Class
End Namespace
