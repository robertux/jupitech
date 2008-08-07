Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjPromociones
	    Public Shared Function GetPromocion(ByVal codigo As Integer, ByVal ds As DataSet) As Promocion
        For Each fila As DataRow In ds.Tables("promociones").Rows
            If (fila("codigo") = codigo) Then
                Return New Promocion(fila("fecha_inicio"), fila("fecha_fin"), fila("nombre"), fila("descuento"), fila("codigo"), MnjProductos.GetProductosFrom(fila("codigo"),ds), MnjCombos.GetCombosFrom(fila("codigo"),ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddPromocion(ByVal p As Promocion, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("promociones").NewRow()
	fila("fecha_inicio") = p.FechaInicio
	fila("fecha_fin") = p.FechaFin
	fila("nombre") = p.Nombre
	fila("descuento") = p.Descuento
	fila("codigo") = p.codigo
	For Each prod As Producto In p.Productos
		MnjProductos.AddProducto(prod,ds)
	Next
	For Each cmb As Combo In p.Combos
		MnjCombos.AddCombo(cmb,ds)
	Next
        Ds.Tables("promociones").Rows.Add(fila)
    End Sub

    Public Shared Sub EditPromocion(ByVal p As Promocion, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("promociones").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("fecha_inicio") = p.FechaInicio
		fila("fecha_fin") = p.FechaFin
		fila("nombre") = p.Nombre
		fila("descuento") = p.Descuento
		For Each prod As Producto In p.Productos
			MnjProductos.EditProducto(prod,ds)
		Next
		For Each cmb As Combo In p.Combos
			MnjCombos.EditCombo(cmb,ds)
		Next
		fila("productos") = p.Productos
		fila("combos") = p.Combos
            End If
        Next
    End Sub

    Public Shared Sub DelPromocion(ByVal p as Promocion, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("promociones").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("promociones").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from promociones where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
