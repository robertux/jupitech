Namespace Entidades
    Public Class Cliente
        Inherits Persona
        Private _estado As String
        
        Public Property Estado() As String
            Get
                Return _estado
            End Get
            Set(ByVal value As String)
                _estado = value
            End Set
        End Property
        
        Public Sub New(ByVal estado As String, ByVal apellidos As String, ByVal nombres As String, ByVal direccion As String, ByVal codigo As Integer, ByVal usuario As Usuario, ByVal documentos As List(Of Documento), ByVal telefonos As List(Of Telefono))
            MyBase.New(apellidos, nombres, direccion, codigo, usuario, documentos, telefonos)
            Me.Estado = estado
        End Sub
        
    End Class
End Namespace
