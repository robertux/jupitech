Namespace Entidades
    Public Class Persona

        Private _apellidos As String
        Private _nombres As String
        Private _direccion As String
        Private _codigo As Integer
        Private _usuario As Usuario
        Private _documentos As List(Of Documento)
        Private _telefonos As List(Of Telefono)
        
        Public Property Apellidos() As String
            Get
                Return _apellidos
            End Get
            Set(ByVal value As String)
                _apellidos = value
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
        Public Property Codigo() As Integer
            Get
                Return _codigo
            End Get
            Set(ByVal value As Integer)
                _codigo = value
            End Set
        End Property
        Public Property Nombres() As String
            Get
                Return _nombres
            End Get
            Set(ByVal value As String)
                _nombres = value
            End Set
        End Property
        Public Property Usuario() As Usuario
            Get
                Return _usuario
            End Get
            Set(ByVal value As Usuario)
                _usuario = value
            End Set
        End Property
        Public Property Documentos As List(Of Documento)
        	Get
        		return me._documentos
        	End Get
        	Set
        		me._documentos = value
        	End Set
        End Property
        Public Property Telefonos As List(Of Telefono)
        	Get
        		return me._telefonos
        	End Get
        	Set
        		me._telefonos = value
        	End Set
        End Property
        
        Public Sub New(ByVal apellidos As String, ByVal nombres As String, ByVal direccion As String, ByVal codigo As Integer, ByVal usuario As Usuario, byval documentos as List(Of Documento), byval telefonos as List(Of Telefono))
            Me.Apellidos = apellidos
            Me.Codigo = codigo
            Me.Direccion = direccion
            Me.Nombres = nombres
            Me.Documentos = documentos
            Me.Telefonos = telefonos
            me.Usuario = usuario
        End Sub

    End Class
End Namespace
