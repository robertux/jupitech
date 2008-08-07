Imports Jupitech.Entidades
Imports Npgsql

Namespace Manejadores
Public Class MnjVentas
	    Public Shared Function GetVenta(ByVal codigo As Integer, ByVal ds As DataSet) As Venta
        For Each fila As DataRow In ds.Tables("ventas").Rows
            If (fila("codigo") = codigo) Then
                    Return New Venta(MnjClientes.GetCliente(fila("cliente"), ds), MnjVendedores.GetVendedor(fila("vendedor"), ds), MnjPedidos.GetPedido(fila("pedido"), ds), fila("fecha"), MnjSucursales.GetSucursal(fila("sucursal"), ds), fila("tipo"), fila("tipo_pago"), MnjDocumentosPago.GetDocumentoPago(fila("forma_pago"), ds), fila("codigo"), MnjItemsTransaccion.GetItemsFrom(fila("codigo"), ds))
            End If
        Next
        Return Nothing
        End Function

        Public Shared Function GetLastCode(ByVal cn As NpgsqlConnection) As Integer
            Dim cmd As New NpgsqlCommand("select max(codigo) from ventas", cn)
            cn.Open()
            Dim val As Integer = CInt(cmd.ExecuteScalar())
            cn.Close()
            Return val
        End Function

    Public Shared Sub AddVenta(ByVal v As Venta, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("ventas").NewRow()
	fila("cliente") = v.Cliente.Codigo
            fila("vendedor") = v.Vendedor.Codigo
            If Not v.Pedido Is Nothing Then
                fila("pedido") = v.Pedido.Codigo
            End If
            fila("fecha") = v.Fecha
            fila("sucursal") = v.Sucursal.Codigo
	fila("tipo") = v.Tipo
	fila("tipo_pago") = v.TipoPago
            fila("forma_pago") = v.Documento.Codigo
	fila("codigo") = v.Codigo
            Ds.Tables("ventas").Rows.Add(fila)
           
    End Sub

    Public Shared Sub EditVenta(ByVal v As Venta, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("ventas").Rows
            If (fila("codigo") = v.Codigo) Then
		fila("cliente") = v.Cliente.Codigo
		fila("vendedor") = v.Vendedor.Codigo
		fila("pedido") = v.Pedido.Codigo
		fila("fecha") = v.Fecha
                    fila("sucursal") = v.Sucursal.Codigo
		fila("tipo") = v.Tipo
		fila("tipo_pago") = v.TipoPago
                    fila("forma_pago") = v.Documento.Codigo
		
            End If
        Next
    End Sub

    Public Shared Sub DelVenta(ByVal v as Venta, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each itm As ItemTransaccion In v.Items
        	MnjItems.DelItem(itm,ds,cn)
        Next
        For Each fila As DataRow In Ds.Tables("ventas").Rows
            If (fila("codigo") = v.Codigo) Then
                Ds.Tables("ventas").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from ventas where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", v.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
