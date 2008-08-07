Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjDevoluciones
	    Public Shared Function GetDevolucion(ByVal codigo As Integer, ByVal ds As DataSet) As Devolucion
        For Each fila As DataRow In ds.Tables("devoluciones").Rows
            If (fila("codigo") = codigo) Then
                Return New Devolucion(fila("fecha_devolucion"), fila("tipo_compensacion"), fila("codigo"), fila("motivo"), MnjVentas.GetVenta(fila("venta"),ds), MnjItemsDevolucion.GetItemsFrom(fila("codigo"),ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddDevolucion(ByVal d As Devolucion, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("devoluciones").NewRow()
	fila("fecha_devolucion") = d.FechaDevolucion
	fila("tipo_compensacion") = d.TipoCompensacion
	fila("codigo") = d.Codigo
	fila("motivo") = d.Motivo
	fila("venta") = d.Venta.Codigo
	For Each itm As ItemDevolucion In d.Items
		MnjItemsDevolucion.AddItemDevolucion(itm,ds)
	Next
        Ds.Tables("devoluciones").Rows.Add(fila)
    End Sub

    Public Shared Sub EditDevolucion(ByVal d As Devolucion, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("devoluciones").Rows
            If (fila("codigo") = d.Codigo) Then
		fila("fecha_devolucion") = d.FechaDevolucion
		fila("tipo_compensacion") = d.TipoCompensacion
		fila("motivo") = d.Motivo
		fila("venta") = d.Venta.Codigo
		For Each itm As ItemDevolucion In d.Items
			MnjItemsDevolucion.EditItemDevolucion(itm,ds)
		Next
            End If
        Next
    End Sub

    Public Shared Sub DelDevolucion(ByVal d as Devolucion, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each itm As ItemDevolucion In d.Items
        	MnjItemsDevolucion.DelItemDevolucion(itm,ds,cn)
        Next
        For Each fila As DataRow In Ds.Tables("devoluciones").Rows
            If (fila("codigo") = d.Codigo) Then
                Ds.Tables("devoluciones").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from devoluciones where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", d.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
