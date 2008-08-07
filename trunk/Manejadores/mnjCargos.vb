Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjCargos
	    Public Shared Function GetCargo(ByVal codigo As Integer, ByVal ds As DataSet) As Cargo
        For Each fila As DataRow In ds.Tables("cargos").Rows
            If (fila("codigo") = codigo) Then
                    Return New Cargo(fila("fecha_limite_pago"), fila("fecha_pago"), fila("monto"), fila("prctn_interes_normal"), fila("prctn_interes_mora"), fila("codigo"), fila("compra"))
            End If
        Next
        Return Nothing
    End Function
    
    Public Shared Function GetCargosFrom(ByVal codCompra As Integer, ByVal ds As DataSet) As List(Of Cargo)
    	dim cargos as new List(Of Cargo)	
    	For Each fila As DataRow In ds.Tables("cargos").Rows
    		If(fila("compra") = codCompra) Then
                    cargos.Add(New Cargo(fila("fecha_limite_pago"), fila("fecha_pago"), fila("monto"), fila("prctn_interes_normal"), fila("prctn_interes_mora"), fila("codigo"), (fila("compra"))))
    		End If    		
    	Next
    	return cargos
    End Function

    Public Shared Sub AddCargo(ByVal c As Cargo, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("cargos").NewRow()
	fila("fecha_limite_pago") = c.FechaLimitePago
	fila("fecha_pago") = c.FechaPago
	fila("monto") = c.Monto
	fila("prctn_interes_normal") = c.PrcntInteresNormal
	fila("prctn_interes_mora") = c.PrcntInteresMora
	fila("codigo") = c.Codigo
            fila("compra") = c.Compra
        Ds.Tables("cargos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditCargo(ByVal c As Cargo, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("cargos").Rows
            If (fila("codigo") = c.Codigo) Then
		fila("fecha_limite_pago") = c.FechaLimitePago
		fila("fecha_pago") = c.FechaPago
		fila("monto") = c.Monto
		fila("prctn_interes_normal") = c.PrcntInteresNormal
		fila("prctn_interes_mora") = c.PrcntInteresMora
                    fila("compra") = c.Compra
            End If
        Next
    End Sub

    Public Shared Sub DelCargo(ByVal c as Cargo, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("cargos").Rows
            If (fila("codigo") = c.Codigo) Then
                Ds.Tables("cargos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from cargos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", c.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
