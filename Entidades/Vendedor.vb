Namespace Entidades
    Public Class Vendedor
        Inherits Persona
        Private _cargo As String
        Private _sueldoBase As Double
        Private _sucursal As Sucursal
        
        Public Property Cargo() As String
            Get
                Return _cargo
            End Get
            Set(ByVal value As String)
                _cargo = value
            End Set
        End Property
        Public Property Sucursal() As Sucursal
            Get
                Return _sucursal
            End Get
            Set(ByVal value As Sucursal)
                _sucursal = value
            End Set
        End Property
        Public Property SueldoBase() As Double
            Get
                Return _sueldoBase
            End Get
            Set(ByVal value As Double)
                _sueldoBase = value
            End Set
        End Property

        Public Sub New(ByVal cargo As String, ByVal sueldoBase As Double, ByVal sucursal As Sucursal, ByVal apellidos As String, ByVal nombres As String, ByVal direccion As String, ByVal codigo As Integer, ByVal usuario As Usuario, byval documentos as List(Of Documento), byval telefonos as List(Of Telefono))
            MyBase.New(apellidos, nombres, direccion, codigo, usuario, documentos, telefonos)
            Me.Cargo = cargo
            Me.SueldoBase = sueldoBase
            Me.Sucursal = sucursal
        End Sub
        
    End Class
End Namespace
