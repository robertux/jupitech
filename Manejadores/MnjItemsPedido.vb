Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjItemsPedido
	    Public Shared Function GetItemPedido(ByVal codigo As Integer, ByVal ds As DataSet) As ItemPedido
        For Each fila As DataRow In ds.Tables("itemspedido").Rows
            If (fila("codigo") = codigo) Then
                    Return New ItemPedido(fila("codigo"), fila("producto"), fila("cantidad"), (fila("pedido")))
            End If
        Next
        Return Nothing
    End Function
    
      Public Shared Function GetItemsFrom(ByVal codPedido As Integer, ByVal ds As DataSet) as List(Of ItemPedido)
    	Dim items As New List(Of ItemPedido)
    	For Each fila As DataRow In ds.Tables("itemspedido").Rows
    		If(fila("pedido") = codPedido) Then
                    items.Add(New ItemPedido(fila("codigo"), fila("producto"), fila("cantidad"), (fila("pedido"))))
    		End If
    	Next
    	return items
    End Function     

    Public Shared Sub AddItemPedido(ByVal i As ItemPedido, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("itemspedido").NewRow()
	fila("codigo") = i.Codigo
	fila("producto")  = i.Producto
	fila("cantidad") = i.Cantidad
            fila("pedido") = i.Pedido
        Ds.Tables("itemspedido").Rows.Add(fila)
    End Sub

    Public Shared Sub EditItemPedido(ByVal i As ItemPedido, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("itemspedido").Rows
            If (fila("codigo") = i.Codigo) Then
		fila("producto")  = i.Producto
		fila("cantidad") = i.Cantidad
                    fila("pedido") = i.Pedido
            End If
        Next
    End Sub

    Public Shared Sub DelItemPedido(ByVal i as ItemPedido, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("itemspedido").Rows
            If (fila("codigo") = i.Codigo) Then
                Ds.Tables("itemspedido").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from itemspedido where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", i.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
