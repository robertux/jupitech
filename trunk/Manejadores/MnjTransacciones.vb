Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjTransacciones
	    Public Shared Function GetTransaccion(ByVal codigo As Integer, ByVal ds As DataSet) As Transaccion
        For Each fila As DataRow In ds.Tables("transacciones").Rows
            If (fila("codigo") = codigo) Then
                    Return New Transaccion(fila("fecha"), MnjSucursales.GetSucursal(fila("sucursal"), ds), fila("tipo"), fila("tipo_pago"), MnjDocumentosPago.GetDocumentoPago(fila("forma_pago"), ds), fila("codigo"), MnjItemsTransaccion.GetItemsFrom(fila("codigo"), ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddTransaccion(ByVal t As Transaccion, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("transacciones").NewRow()
	fila("fecha") = t.Fecha
            fila("sucursal") = t.Sucursal.Codigo
	fila("tipo") = t.Tipo
	fila("tipo_pago") = t.TipoPago
	fila("documento") = t.Documento.Codigo
	fila("codigo") = t.Codigo
	For Each itm As ItemTransaccion In t.Items
		MnjItemsTransaccion.AddItemTransaccion(itm, ds)
	Next
        Ds.Tables("transacciones").Rows.Add(fila)
    End Sub

    Public Shared Sub EditTransaccion(ByVal t As Transaccion, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("transacciones").Rows
            If (fila("codigo") = t.Codigo) Then
		fila("fecha") = t.Fecha
                    fila("sucursal") = t.Sucursal.Codigo
		fila("tipo") = t.Tipo
		fila("tipo_pago") = t.TipoPago
		fila("documento") = t.Documento.Codigo
		For Each itm As ItemTransaccion In t.Items
			MnjItemsTransaccion.AddItemTransaccion(itm, ds)
		Next
            End If
        Next
    End Sub

    Public Shared Sub DelTransaccion(ByVal t as Transaccion, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
	For Each itm As ItemTransaccion In t.Items
		MnjItemsTransaccion.DelItemTransaccion(itm,ds,cn)
	Next
        For Each fila As DataRow In Ds.Tables("transacciones").Rows
            If (fila("codigo") = t.Codigo) Then
                Ds.Tables("transacciones").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from transacciones where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", t.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
