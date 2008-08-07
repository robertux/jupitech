Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjItemsTransaccion
	    Public Shared Function GetItemTransaccion(ByVal codigo As Integer, ByVal ds As DataSet) As ItemTransaccion
        For Each fila As DataRow In ds.Tables("itemstransaccion").Rows
            If (fila("codigo") = codigo) Then
                    Return New ItemTransaccion(fila("codigo"), MnjProductos.GetProducto(fila("producto"), ds), fila("cantidad"), (fila("transaccion")))
            End If
        Next
        Return Nothing
    End Function
    
      Public Shared Function GetItemsFrom(ByVal codTransaccion As Integer, ByVal ds As DataSet) as List(Of ItemTransaccion)
    	Dim items As New List(Of ItemTransaccion)
    	For Each fila As DataRow In ds.Tables("itemstransaccion").Rows
    		If(fila("transaccion") = codTransaccion) Then
                    items.Add(New ItemTransaccion(fila("codigo"), MnjProductos.GetProducto(fila("producto"), ds), fila("cantidad"), fila("transaccion")))
    		End If
    	Next
    	return items
    End Function    

    Public Shared Sub AddItemTransaccion(ByVal i As ItemTransaccion, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("itemstransaccion").NewRow()
	fila("codigo") = i.Codigo
            fila("producto") = i.Producto.Codigo
	fila("cantidad") = i.Cantidad
            fila("transaccion") = i.Transaccion
        Ds.Tables("itemstransaccion").Rows.Add(fila)
    End Sub

    Public Shared Sub EditItemTransaccion(ByVal i As ItemTransaccion, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("itemstransaccion").Rows
            If (fila("codigo") = i.Codigo) Then
                    fila("producto") = i.Producto.Codigo
		fila("cantidad") = i.Cantidad
                    fila("transaccion") = i.Transaccion
            End If
        Next
    End Sub   

    Public Shared Sub DelItemTransaccion(ByVal i as ItemTransaccion, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("itemstransaccion").Rows
            If (fila("codigo") = i.Codigo) Then
                Ds.Tables("itemstransaccion").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from itemstransaccion where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", i.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
