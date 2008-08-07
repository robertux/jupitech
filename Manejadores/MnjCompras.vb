Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjCompras
	   
	Public Shared Function GetCompra(ByVal codigo As Integer, ByVal ds As DataSet) As Compra
        For Each fila As DataRow In ds.Tables("compras").Rows
            If (fila("codigo") = codigo) Then
                    Return New Compra(MnjProveedores.GetProveedor(fila("proveedor"), ds), fila("fecha"), MnjSucursales.GetSucursal(fila("sucursal"), ds), fila("tipo"), fila("tipo_pago"), MnjDocumentosPago.GetDocumentoPago(fila("forma_pago"), ds), fila("codigo"), MnjItemsTransaccion.GetItemsFrom(fila("codigo"), ds), MnjCargos.GetCargosFrom(fila("codigo"), ds))
            End If
        Next
        Return Nothing
        End Function

        Public Shared Function GetLastCode(ByVal cn As NpgsqlConnection) As Integer
            Dim cmd As New NpgsqlCommand("select max(codigo) from compras", cn)
            cn.Open()
            Dim val As Integer = CInt(cmd.ExecuteScalar())
            cn.Close()
            Return val
        End Function


    Public Shared Sub AddCompra(ByVal c As Compra, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("compras").NewRow()
	fila("proveedor") = c.Proveedor.Codigo
	fila("fecha") = c.Fecha
            fila("sucursal") = c.Sucursal.Codigo
	fila("tipo") = c.Tipo
	fila("tipo_pago") = c.TipoPago
	fila("documento") = c.Documento.Codigo
	fila("codigo") = c.Codigo
	For Each itm As ItemTransaccion In c.Items
		MnjItemsTransaccion.AddItemTransaccion(itm,ds)
	Next
	For Each crg As Cargo In c.Cargos
		MnjCargos.AddCargo(crg,ds)
	Next
        Ds.Tables("compras").Rows.Add(fila)
    End Sub

    Public Shared Sub EditCompra(ByVal c As Compra, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("compras").Rows
            If (fila("codigo") = c.Codigo) Then
		fila("proveedor") = c.Proveedor.Codigo
		fila("fecha") = c.Fecha
                    fila("sucursal") = c.Sucursal.Codigo
		fila("tipo") = c.Tipo
		fila("tipo_pago") = c.TipoPago
		fila("documento") = c.Documento.Codigo
		For Each itm As ItemTransaccion In c.Items
			MnjItemsTransaccion.EditItemTransaccion(itm,ds)
		Next
		For Each crg As Cargo In c.Cargos
			MnjCargos.EditCargo(crg,ds)
		Next
            End If
        Next
    End Sub

    Public Shared Sub DelCompra(ByVal c As Compra, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each itm As ItemTransaccion  In c.Items
        	MnjItemsTransaccion.DelItemTransaccion(itm,ds,cn)
        Next
        For Each fila As DataRow In Ds.Tables("compras").Rows
            If (fila("codigo") = c.Codigo) Then
                Ds.Tables("compras").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from compras where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", c.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
