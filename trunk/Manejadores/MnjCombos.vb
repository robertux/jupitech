Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjCombos
	    Public Shared Function GetCombo(ByVal codigo As Integer, ByVal ds As DataSet) As Combo
        For Each fila As DataRow In ds.Tables("combos").Rows
            If (fila("codigo") = codigo) Then
                Return New Combo(fila("nombre"), fila("descripcion"), fila("codigo"), MnjPromociones.GetPromocion(fila("promocion"),ds))
            End If
        Next
        Return Nothing
    End Function
    
    Public Shared Function GetCombosFrom(ByVal codPromocion As String, ByVal ds As DataSet) As List(Of Combo)
    	Dim combos As new List(Of Combo)
    	For Each fila As DataRow In ds.Tables("combos").Rows
    		If(fila("promocion") = codPromocion) Then
    			combos.Add(New Combo(fila("nombre"), fila("descripcion"), fila("codigo"), MnjPromociones.GetPromocion(fila("promocion"),ds)))
    		End If
    	Next
    	return combos
    End Function

    Public Shared Sub AddCombo(ByVal c As Combo, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("combos").NewRow()
	fila("nombre") = c.Nombre
	fila("descripcion") = c.Descripcion
	fila("codigo") = c.Codigo
	fila("promocion") = c.Promocion.codigo
        Ds.Tables("combos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditCombo(ByVal c As Combo, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("combos").Rows
            If (fila("codigo") = c.Codigo) Then
		fila("nombre") = c.Nombre
		fila("descripcion") = c.Descripcion
		fila("promocion") = c.Promocion.codigo
            End If
        Next
    End Sub

    Public Shared Sub DelCombo(ByVal c As Combo, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("combos").Rows
            If (fila("codigo") = c.Codigo) Then
                Ds.Tables("combos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from combos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", c.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
