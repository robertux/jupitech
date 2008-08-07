Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjAnulaciones
	    Public Shared Function GetAnulacion(ByVal codigo As Integer, ByVal ds As DataSet) As Anulacion
        For Each fila As DataRow In ds.Tables("anulaciones").Rows
            If (fila("codigo") = codigo) Then
                Return New Anulacion(fila("fecha_anulacion"), fila("tipo_compensacion"), fila("codigo"), fila("motivo"), MnjVentas.GetVenta(fila("venta"),ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddAnulacion(ByVal a As Anulacion, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("anulaciones").NewRow()
        fila("codigo") = a.Codigo
        fila("fecha_anulacion") = a.FechaAnulacion
        fila("tipo_compensacion") = a.TipoCompansacion
        fila("motivo") = a.Motivo
        fila("venta") = a.Venta.Codigo
        Ds.Tables("anulaciones").Rows.Add(fila)
    End Sub

    Public Shared Sub EditAnulacion(ByVal a As Anulacion, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("anulaciones").Rows
            If (fila("codigo") = a.Codigo) Then
	        fila("fecha_anulacion") = a.FechaAnulacion
	        fila("tipo_compensacion") = a.TipoCompansacion
	        fila("motivo") = a.Motivo
	        fila("venta") = a.Venta.Codigo
	        Ds.Tables("anulaciones").Rows.Add(fila)
            End If
        Next
    End Sub

    Public Shared Sub DelAnulacion(ByVal a As Anulacion, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("anulaciones").Rows
            If (fila("codigo") = a.Codigo) Then
                Ds.Tables("anulaciones").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from anulaciones where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", a.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
