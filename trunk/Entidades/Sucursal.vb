Namespace Entidades
    Public Class Sucursal
        Private _nombre As String
        Private _direccion As String
        Private _encargado As Persona
        Private _codigo As Integer
        
        Public Property Nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
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
        Public Property Encargado() As Persona
            Get
                Return _encargado
            End Get
            Set(ByVal value As Persona)
                _encargado = value
            End Set
        End Property
        Public Property Direccion() As String
            Get
                Return _direccion
            End Get
            Set(ByVal value As String)
                _direccion = value
            End Set
        End Property

        Public Sub New(ByVal nombre As String, ByVal direccion As String, ByVal encargado As Persona, ByVal codigo As Integer)
            Me.Nombre = nombre
            Me.Direccion = direccion
            Me.Encargado = encargado
            Me.Codigo = codigo
        End Sub
    End Class
End Namespace
