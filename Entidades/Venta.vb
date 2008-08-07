Namespace Entidades
    Public Class Venta
        Inherits Transaccion
        Private _cliente As Cliente
        Private _vendedor As Vendedor
        Private _pedido As Pedido
        Private _abonos As List(Of Abono)
        Private _anulacion As Anulacion
        private _devoluciones as List(Of Devolucion)
        
        Public Property Cliente() As Cliente
            Get
                Return _cliente
            End Get
            Set(ByVal value As Cliente)
                _cliente = value
            End Set
        End Property
        Public Property Pedido() As Pedido
            Get
                Return _pedido
            End Get
            Set(ByVal value As Pedido)
                _pedido = value
            End Set
        End Property
        Public Property Vendedor() As Vendedor
            Get
                Return _vendedor
            End Get
            Set(ByVal value As Vendedor)
                _vendedor = value
            End Set
        End Property
        Public Property Abonos As List(Of Abono)
        	Get
        		return me._abonos
        	End Get
        	Set
        		me._abonos = value
        	End Set
        End Property
        Public Property Anulacionn As Anulacion
        	Get
        		return me._anulacion
        	End Get
        	Set
        		me._anulacion = value
        	End Set
        End Property
	Public Property Devoluciones As List(Of Devolucion)
		Get
			return me._devoluciones
		End Get
		Set
			me._devoluciones = value
		End Set
	End Property
        
        Public Sub New(ByVal cliente As Cliente, ByVal vendedor As Vendedor, ByVal pedido As Pedido, ByVal fecha As Date, ByVal sucursal As Sucursal, ByVal tipo As String, ByVal tipoPago As String, ByVal documento As DocumentoPago, ByVal codigo As Integer, ByVal items As List(Of ItemTransaccion))
            MyBase.New(fecha, sucursal, tipo, tipoPago, documento, codigo, Nothing)
            Me.Cliente = cliente
            Me.Vendedor = vendedor
            Me.Pedido = pedido
        End Sub
        
    End Class
End Namespace
