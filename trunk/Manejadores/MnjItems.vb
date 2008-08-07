Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjItems
	    Public Shared Function GetItem(ByVal codigo As Integer, ByVal ds As DataSet) As Item
        For Each fila As DataRow In ds.Tables("items").Rows
            If (fila("codigo") = codigo) Then
                Return New Item(fila("codigo"), mnjProductos.GetProducto(fila("producto"),ds), fila("cantidad"))
            End If
        Next
        Return Nothing
    End Function
    
    Public Shared Sub AddItem(ByVal i As Item, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("items").NewRow()
	fila("codigo") = i.Codigo
	fila("producto")  = i.Producto.Codigo
	fila("cantidad") = i.Cantidad
        Ds.Tables("items").Rows.Add(fila)
    End Sub

    Public Shared Sub EditItem(ByVal i As Item, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("items").Rows
            If (fila("codigo") = i.Codigo) Then
		fila("producto")  = i.Producto.Codigo
		fila("cantidad") = i.Cantidad
            End If
        Next
    End Sub

    Public Shared Sub DelItem(ByVal i as Item, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("items").Rows
            If (fila("codigo") = i.Codigo) Then
                Ds.Tables("items").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from items where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", i.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
