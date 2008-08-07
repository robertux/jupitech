Namespace Entidades
    Public Class TipoProducto
        Private _nombre As String
        Private _descripcion As String
        Private _superior As Integer
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
        Public Property Superior() As Integer
            Get
                Return _superior
            End Get
            Set(ByVal value As Integer)
                _superior = value
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
        
        Public Sub New(ByVal nombre As String, ByVal descripcion As String, ByVal superior As Integer, ByVal codigo As Integer)
            Me.Codigo = codigo
            Me.Descripcion = descripcion
            Me.Nombre = nombre
            Me.Superior = Superior
        End Sub

    End Class
End Namespace
