Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjPedidos
	    Public Shared Function GetPedido(ByVal codigo As Integer, ByVal ds As DataSet) As Pedido
        For Each fila As DataRow In ds.Tables("pedidos").Rows
            If (fila("codigo") = codigo) Then
                Return New Pedido(fila("fecha_emision"), fila("fecha_entrega"), MnjClientes.GetCliente(fila("cliente"),ds), fila("estado"), fila("codigo"),MnjItemsPedido.GetItemsFrom(fila("codigo"),ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddPedido(ByVal p As Pedido, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("pedidos").NewRow()
		fila("fecha_emision") = p.FechaEmision
		fila("fecha_entrega") = p.FechaEntrega
		fila("cliente") = p.Cliente.Codigo
		fila("estado") = p.Estado
		fila("codigo") = p.Codigo
		For Each itm As ItemPedido In p.Items
			MnjItemsPedido.AddItemPedido(itm,ds)
		Next
        Ds.Tables("pedidos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditPedido(ByVal p As Pedido, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("pedidos").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("fecha_emision") = p.FechaEmision
		fila("fecha_entrega") = p.FechaEntrega
		fila("cliente") = p.Cliente.Codigo
		fila("estado") = p.Estado
		For Each itm As ItemPedido In p.Items
			MnjItemsPedido.EditItemPedido(itm, ds)
		Next
            End If
        Next
    End Sub

    Public Shared Sub DelPedido(ByVal p as Pedido, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each itm As ItemPedido In p.Items
        	MnjItemsPedido.DelItemPedido(itm,ds,cn)
        Next
        For Each fila As DataRow In Ds.Tables("pedidos").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("pedidos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from pedidos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
