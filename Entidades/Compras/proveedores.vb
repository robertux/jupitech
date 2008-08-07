Public Class Proveedores
    Private _codigo As String
    Private _nombre As String
    Private _direccion As String
    Private _telefono As String
    Private _fax As String
    Private _pweb As String
    Private _email As String


    Public Property Codigo() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
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
    Public Property Telefono() As String
        Get
            Return _telefono
        End Get
        Set(ByVal value As String)
            _telefono = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return _fax
        End Get
        Set(ByVal value As String)
            _fax = value
        End Set
    End Property
    Public Property Pweb() As String
        Get
            Return _pweb
        End Get
        Set(ByVal value As String)
            _pweb = value
        End Set
    End Property
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property
    Sub New(ByVal codigo As String, ByVal nombre As String, ByVal direccion As String, ByVal telefono As String, ByVal fax As String, ByVal pweb As String, ByVal email As String)
        Me.Codigo = codigo
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Telefono = telefono
        Me.Fax = fax
        Me.Pweb = pweb
        Me.Email = email
    End Sub



End Class

