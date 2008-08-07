Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjProveedores
	    Public Shared Function GetProveedor(ByVal codigo As Integer, ByVal ds As DataSet) As Proveedor
        For Each fila As DataRow In ds.Tables("proveedores").Rows
                If (fila("codigo") = codigo) Then                    
                    Dim user As Usuario
                    Dim docs As List(Of Documento)
                    Dim tels As New List(Of Telefono)
                    If (TypeOf (fila("usuario")) Is System.DBNull) Then
                        user = Nothing
                    Else
                        user = MnjUsuarios.GetUsuario(fila("usuario"), ds)
                    End If
                    docs = MnjDocumentos.GetDocumentosFrom(fila("codigo"), ds)
                    If (docs Is Nothing) Then
                        docs = New List(Of Documento)
                    End If
                    tels = MnjTelefonos.GetTelefonosFrom(fila("codigo"), ds)
                    If (tels Is Nothing) Then
                        tels = New List(Of Telefono)
                    End If
                    Return New Proveedor(fila("tipo"), fila("apellidos"), fila("nombres"), fila("direccion"), fila("codigo"), user, docs, tels)
                End If
            Next
        Return Nothing
    End Function

    Public Shared Sub AddProveedor(ByVal p As Proveedor, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("proveedores").NewRow()
	fila("tipo") = p.Tipo
	fila("apellidos") = p.Apellidos
	fila("nombres") = p.Nombres
	fila("direccion") = p.Direccion
            fila("codigo") = p.Codigo
            If Not (p.Usuario Is Nothing) Then
                fila("usuario") = p.Usuario.Codigo
            End If
            For Each doc As Documento In p.Documentos
                MnjDocumentos.AddDocumento(doc, Ds)
            Next
            For Each tel As Telefono In p.Telefonos
                MnjTelefonos.AddTelefono(tel, Ds)
            Next
            Ds.Tables("proveedores").Rows.Add(fila)
        End Sub

    Public Shared Sub EditProveedor(ByVal p As Proveedor, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("proveedores").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("apellidos") = p.Apellidos
                    fila("nombres") = p.Nombres
                    fila("tipo") = p.Tipo
                    fila("direccion") = p.Direccion
                    If Not (p.Usuario Is Nothing) Then
                        fila("usuario") = p.Usuario.Codigo
                    End If
                    For Each doc As Documento In p.Documentos
                        MnjDocumentos.EditDocumento(doc, Ds)
                    Next
                    For Each tel As Telefono In p.Telefonos
                        MnjTelefonos.EditTelefono(tel, Ds)
                    Next
                End If
            Next
    End Sub

    Public Shared Sub DelProveedor(ByVal p as Proveedor, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("proveedores").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("proveedores").Rows.Remove(fila)
                exit for
            End If
        Next
            Dim cmd As New NpgsqlCommand("Delete from proveedores where codigo = :codigo and (select count(*) from compras where proveedor=:codigo)=0", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
