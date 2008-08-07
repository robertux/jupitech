Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjItemsDevolucion
	    Public Shared Function GetItemDevolucion(ByVal codigo As Integer, ByVal ds As DataSet) As ItemDevolucion
        For Each fila As DataRow In ds.Tables("itemsdevolucion").Rows
            If (fila("codigo") = codigo) Then
                    Return New ItemDevolucion(fila("codigo"), fila("producto"), fila("cantidad"), (fila("devolucion")))
            End If
        Next
        Return Nothing
    End Function
    
          Public Shared Function GetItemsFrom(ByVal codDevolucion As Integer, ByVal ds As DataSet) as List(Of ItemDevolucion)
    	Dim items As New List(Of ItemDevolucion)
    	For Each fila As DataRow In ds.Tables("itemsdevolucion").Rows
    		If(fila("devolucion") = codDevolucion) Then
                    items.Add(New ItemDevolucion(fila("codigo"), fila("producto"), fila("cantidad"), (fila("devolucion"))))
    		End If
    	Next
    	return items
    End Function 

    Public Shared Sub AddItemDevolucion(ByVal i As ItemDevolucion, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("itemsdevolucion").NewRow()
	fila("codigo") = i.Codigo
	fila("producto")  = i.Producto
	fila("cantidad") = i.Cantidad
            fila("devolucion") = i.Devolucion
        Ds.Tables("itemsdevolucion").Rows.Add(fila)
    End Sub

    Public Shared Sub EditItemDevolucion(ByVal i As ItemDevolucion, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("itemsdevolucion").Rows
            If (fila("codigo") = i.Codigo) Then
		fila("producto")  = i.Producto
		fila("cantidad") = i.Cantidad
                    fila("devolucion") = i.Devolucion
            End If
        Next
    End Sub

    Public Shared Sub DelItemDevolucion(ByVal i as ItemDevolucion, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("itemsdevolucion").Rows
            If (fila("codigo") = i.Codigo) Then
                Ds.Tables("itemsdevolucion").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from itemsdevolucion where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", i.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
