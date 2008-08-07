Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjCombosProductos
	    Public Shared Function GetComboProducto(ByVal codigo As Integer, ByVal ds As DataSet) As ComboProducto
        For Each fila As DataRow In ds.Tables("combosproductos").Rows
            If (fila("codigo") = codigo) Then
                Return New ComboProducto(MnjCombos.GetCombo(fila("combo"),ds), MnjProductos.GetProducto(fila("producto"),ds), fila("codigo"))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddComboProducto(ByVal c As ComboProducto, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("combosproductos").NewRow()
	fila("combo") = c.Combo.Codigo
	fila("producto") = c.Producto.Codigo
	fila("codigo") = c.Codigo
        Ds.Tables("combosproductos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditComboProducto(ByVal c As ComboProducto, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("combosproductos").Rows
            If (fila("codigo") = c.Codigo) Then
		fila("combo") = c.Combo.Codigo
		fila("producto") = c.Producto.Codigo
	end if
        Next
    End Sub

    Public Shared Sub DelComboProducto(ByVal c as ComboProducto, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("combosproductos").Rows
            If (fila("codigo") = c.Codigo) Then
                Ds.Tables("combosproductos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from combosproductos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", c.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
