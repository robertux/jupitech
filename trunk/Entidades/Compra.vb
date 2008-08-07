Namespace Entidades
    Public Class Compra
        Inherits Transaccion
        
        Private _proveedor As Proveedor
        Private _cargos as List(Of Cargo)
        
        Public Property Proveedor() As Proveedor
            Get
                Return _proveedor
            End Get
            Set(ByVal value As Proveedor)
                _proveedor = value
            End Set
        End Property        
        Public Property Cargos As List(Of Cargo)
        	Get
        		return me._cargos
        	End Get
        	Set
        		me._cargos = value
        	End Set
        End Property
        
        Public Sub New(ByVal proveedor As Proveedor, ByVal fecha As Date, ByVal sucursal As Sucursal, ByVal tipo As String, ByVal tipoPago As String, ByVal documento as DocumentoPago, ByVal codigo As Integer, byval items as List(Of ItemTransaccion), byval cargos as List(Of Cargo))
           MyBase.New(fecha, sucursal, tipo, tipoPago, documento, codigo, nothing)
            Me.Proveedor = proveedor
            me.Cargos = cargos
        End Sub
        
    End Class
End Namespace
