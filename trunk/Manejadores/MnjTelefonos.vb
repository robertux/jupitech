Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjTelefonos
	    Public Shared Function GetTelefono(ByVal codigo As Integer, ByVal ds As DataSet) As Telefono
        For Each fila As DataRow In ds.Tables("telefonos").Rows
            If (fila("codigo") = codigo) Then
                    Return New Telefono(fila("tipo"), fila("numero"), fila("codigo"), fila("persona"))
            End If
        Next
        Return Nothing
    End Function
    
    Public Shared Function GetTelefonosFrom(ByVal codPersona As Integer, ByVal ds As DataSet) as List(Of Telefono)
    	Dim telefonos As New List(Of Telefono)
    	For Each fila As DataRow In ds.Tables("telefonos").Rows
    		If(fila("persona") = codPersona) Then
                    telefonos.Add(New Telefono(fila("tipo"), fila("numero"), fila("codigo"), fila("persona")))
    		End If
    	Next
    	return telefonos
    End Function

    Public Shared Sub AddTelefono(ByVal t As Telefono, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("telefonos").NewRow()
	fila("tipo") = t.Tipo
	fila("numero") = t.Numero
	fila("codigo") = t.Codigo
            fila("persona") = t.Persona
        Ds.Tables("telefonos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditTelefono(ByVal t As Telefono, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("telefonos").Rows
            If (fila("codigo") = t.Codigo) Then
		fila("tipo") = t.Tipo
		fila("numero") = t.Numero
                    fila("persona") = t.Persona
            End If
        Next
    End Sub

    Public Shared Sub DelTelefono(ByVal t as Telefono, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("telefonos").Rows
            If (fila("codigo") = t.Codigo) Then
                Ds.Tables("telefonos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from telefonos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", t.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
