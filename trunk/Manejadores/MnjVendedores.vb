Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjVendedores
	    Public Shared Function GetVendedor(ByVal codigo As Integer, ByVal ds As DataSet) As Vendedor
        For Each fila As DataRow In ds.Tables("vendedores").Rows
            If (fila("codigo") = codigo) Then
                    Return New Vendedor(fila("cargo"), fila("sueldo_base"), MnjSucursales.GetSucursal(fila("sucursal"), ds), fila("apellidos"), fila("nombres"), fila("direccion"), fila("codigo"), MnjUsuarios.GetUsuario(fila("usuario"), ds), MnjDocumentos.GetDocumentosFrom(fila("codigo"), ds), MnjTelefonos.GetTelefonosFrom(fila("codigo"), ds))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddVendedor(ByVal v As Vendedor, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("vendedores").NewRow()
	fila("cargo") = v.Cargo
	fila("sueldo_base") = v.SueldoBase
	fila("sucursal") = v.Sucursal.Codigo
	fila("apellidos") = v.Apellidos
	fila("nombres") = v.Nombres
	fila("direccion") = v.Direccion
	fila("codigo") = v.Codigo
	fila("usuario") = v.Usuario.Codigo
	For Each doc As Documento In v.Documentos
		MnjDocumentos.AddDocumento(doc, ds)
	Next
	For Each tel As Telefono In v.Telefonos
		MnjTelefonos.AddTelefono(tel, ds)
	Next
        Ds.Tables("vendedores").Rows.Add(fila)
    End Sub

    Public Shared Sub EditVendedor(ByVal v As Vendedor, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("vendedores").Rows
            If (fila("codigo") = v.Codigo) Then
		fila("cargo") = v.Cargo
		fila("sueldo_base") = v.SueldoBase
		fila("sucursal") = v.Sucursal.Codigo
		fila("apellidos") = v.Apellidos
		fila("nombres") = v.Nombres
		fila("direccion") = v.Direccion
		fila("usuario") = v.Usuario.Codigo
		For Each doc As Documento In v.Documentos
			MnjDocumentos.EditDocumento(doc, ds)
		Next
		For Each tel As Telefono In v.Telefonos
			MnjTelefonos.EditTelefono(tel, ds)
		Next
            End If
        Next
    End Sub

    Public Shared Sub DelVendedor(ByVal v as Vendedor, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("vendedores").Rows
            If (fila("codigo") = v.Codigo) Then
                Ds.Tables("vendedores").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from vendedores where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", v.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        End Sub
        Public Shared Function GetvendedorFromUser(ByVal codUser As Integer, ByVal ds As DataSet) As Vendedor
            For Each fila As DataRow In ds.Tables("usuarios").Rows
                If (fila("codigo") = codUser) Then
                    For Each fila2 As DataRow In ds.Tables("vendedores").Rows
                        If (fila2("usuario") = fila("codigo")) Then
                            Return MnjVendedores.GetVendedor(fila2("codigo"), ds)
                        End If
                    Next
                End If
            Next
            Return Nothing
        End Function
End Class
end namespace
