Namespace Entidades
    Public Class Usuario
        Private _nombre As String
        Private _clave As String
        Private _codigo As Integer
        
        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property
        Public Property Clave() As String
            Get
                Return _clave
            End Get
            Set(ByVal value As String)
                _clave = value
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
 
 Public Sub New(ByVal nombre As String, ByVal clave As String, ByVal codigo As Integer)
            Me.Clave = clave
            Me.Codigo = codigo
            Me.Nombre = nombre
        End Sub
 
    End Class
End Namespace
