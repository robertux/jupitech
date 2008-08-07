Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjCostosProductos
	    Public Shared Function GetCostoProducto(ByVal codigo As Integer, ByVal ds As DataSet) As CostoProducto
        For Each fila As DataRow In ds.Tables("costosproductos").Rows
            If (fila("codigo") = codigo) Then
                    Return New CostoProducto(fila("fecha"), fila("monto"), fila("codigo"), fila("producto"))
            End If
        Next
        Return Nothing
    End Function
    
    Public Shared Function GetCostosFrom(ByVal codProducto As String, ByVal ds As DataSet) As List(Of CostoProducto)
    	Dim costos As New List(Of CostoProducto)
    	For Each fila As DataRow In ds.Tables("costosproductos").Rows
    		If(fila("producto") = codproducto) Then
                    costos.Add(New CostoProducto(fila("fecha"), fila("monto"), fila("codigo"), (fila("producto"))))
    		End If    		
    	Next
    	return costos
    End Function

    Public Shared Sub AddCostoProducto(ByVal c As CostoProducto, ByVal Ds As DataSet)
       Dim fila As DataRow = Ds.Tables("costosproductos").NewRow()
	fila("fecha") = c.Fecha
	fila("monto") = c.Monto
	fila("codigo") = c.Codigo
            fila("producto") = c.Producto
        Ds.Tables("costosproductos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditCostoProducto(ByVal c As CostoProducto, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("costosproductos").Rows
            If (fila("codigo") = c.Codigo) Then
		fila("fecha") = c.Fecha
		fila("monto") = c.Monto
                    fila("producto") = c.Producto
            End If
        Next
    End Sub

    Public Shared Sub DelCostoProducto(ByVal c As CostoProducto, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("costosproductos").Rows
            If (fila("codigo") = c.Codigo) Then
                Ds.Tables("costosproductos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from costosproductos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", c.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
