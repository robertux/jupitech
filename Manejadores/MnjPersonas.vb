Imports Jupitech.Entidades
Imports Npgsql

Namespace Manejadores	
Public Class MnjPersonas
	    Public Shared Function GetPersona(ByVal codigo As Integer, ByVal ds As DataSet) As Persona
        For Each fila As DataRow In ds.Tables("personas").Rows
            If (fila("codigo") = codigo) Then
                Return New Persona(fila("apellidos"), fila("nombres"), fila("direccion"), fila("codigo"), MnjUsuarios.GetUsuario(fila("usuario"),ds), MnjDocumentos.GetDocumentosFrom(fila("codigo"),ds), MnjTelefonos.GetTelefonosFrom(fila("codigo"),ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddPersona(ByVal p As Persona, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("personas").NewRow()
	fila("apellidos") = p.Apellidos
	fila("nombres") = p.Nombres
	fila("direccion") = p.Direccion
	fila("codigo") = p.Codigo
	fila("usuario") = p.Usuario
	For Each doc As Documento In p.Documentos
		MnjDocumentos.AddDocumento(doc,ds)
	Next
	For Each tel As Telefono In p.Telefonos
		MnjTelefonos.AddTelefono(tel, ds)
	Next
        Ds.Tables("personas").Rows.Add(fila)
    End Sub

    Public Shared Sub EditPersona(ByVal p As Persona, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("personas").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("apellidos") = p.Apellidos
		fila("nombres") = p.Nombres
		fila("direccion") = p.Direccion
		fila("usuario") = p.Usuario
		For Each doc As Documento In p.Documentos
			MnjDocumentos.EditDocumento(doc, ds)
		Next
		For Each tel As Telefono In p.Telefonos
			MnjTelefonos.EditTelefono(tel, ds)
		Next
            End If
        Next
    End Sub

    Public Shared Sub DelPersona(ByVal p as Persona, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("personas").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("personas").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from personas where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
