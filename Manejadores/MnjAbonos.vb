Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjAbonos
	    Public Shared Function GetAbono(ByVal codigo As Integer, ByVal ds As DataSet) As Abono
        For Each fila As DataRow In ds.Tables("abonos").Rows
            If (fila("codigo") = codigo) Then
                    Return New Abono(fila("codigo"), fila("fecha_lim_pago"), fila("fecha_pago"), fila("monto"), fila("prctn_interes_normal"), fila("prctn_interes_mora"), (fila("venta")))
            End If
        Next
        Return Nothing
    End Function
    
    Public Shared Function GetAbonosFrom(ByVal codVenta As Integer, byval ds as DataSet) As List(Of Abono)
	dim abonos as new List(Of Abono)
    	For Each fila As DataRow In ds.Tables("abonos").Rows
    		If(fila("venta") = codVenta) Then
                    abonos.Add(New Abono(fila("codigo"), fila("fecha_lim_pago"), fila("fecha_pago"), fila("monto"), fila("prctn_interes_normal"), fila("prctn_interes_mora"), fila("venta")))
    		End If    		
    	Next
    	return abonos
    End Function

    Public Shared Sub AddAbono(ByVal a As Abono, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("abonos").NewRow()
        fila("codigo") = a.Codigo
            fila("fecha_limite_pago") = a.FechaLimPago.Year.ToString + "-" + a.FechaLimPago.Month.ToString + "-" + a.FechaLimPago.Day.ToString
            fila("fecha_pago") = a.FechaPago.Year.ToString + "-" + a.FechaPago.Month.ToString + "-" + a.FechaPago.Day.ToString
        fila("monto") = a.Monto
        fila("prctn_interes_normal") = a.InteresNormal
        fila("prctn_interes_mora") = a.InteresMora
            fila("venta") = a.Venta
        Ds.Tables("abonos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditAbono(ByVal a As Abono, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("abonos").Rows
            If (fila("codigo") = a.Codigo) Then
                    fila("fecha_limite_pago") = a.FechaLimPago
	        fila("fecha_pago") = a.FechaPago
	        fila("monto") = a.Monto
	        fila("prctn_interes_normal") = a.InteresNormal
	        fila("prctn_interes_mora") = a.InteresMora
                    fila("venta") = a.Venta
	        Ds.Tables("abonos").Rows.Add(fila)
            End If
        Next
    End Sub

    Public Shared Sub DelAbono(ByVal a As Abono, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("abonos").Rows
            If (fila("codigo") = a.Codigo) Then
                Ds.Tables("abonos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from abonos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", a.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
