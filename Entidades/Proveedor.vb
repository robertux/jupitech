Namespace Entidades
    Public Class Proveedor
        Inherits Persona
        Private _tipo As String

        Public Property Tipo() As String
            Get
                Return _tipo
            End Get
            Set(ByVal value As String)
                _tipo = value
            End Set
        End Property

        Sub New(ByVal tipo As String, ByVal apellidos As String, ByVal nombres As String, ByVal direccion As String, ByVal codigo As String, ByVal usuario As Usuario, byval documentos as List(Of Documento), byval telefonos as List(Of Telefono))
            MyBase.new(apellidos, nombres, direccion, codigo, usuario, documentos, telefonos)
            Me.Tipo = tipo
        End Sub
        
    End Class

End Namespace
