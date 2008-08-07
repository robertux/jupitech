Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjClientes

    Public Shared Function GetCliente(ByVal codigo As Integer, ByVal ds As DataSet) As Cliente
        For Each fila As DataRow In ds.Tables("clientes").Rows
            If (fila("codigo") = codigo) Then
                Return New Cliente(fila("estado"), fila("apellidos"), fila("nombres"), fila("direccion"), fila("codigo"), MnjUsuarios.GetUsuario(fila("usuario"),ds), MnjDocumentos.GetDocumentosFrom(fila("codigo"),ds), MnjTelefonos.GetTelefonosFrom(fila("codigo"),ds))
            End If
        Next
        Return Nothing
        End Function

        Public Shared Function GetClientes(ByVal ds As DataSet) As List(Of Cliente)
            Dim cl As New List(Of Cliente)
            For Each fila As DataRow In ds.Tables("clientes").Rows
                cl.Add(MnjClientes.GetCliente(fila("codigo"), ds))
            Next
            Return cl
        End Function

    Public Shared Sub AddCliente(ByVal c As Cliente, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("clientes").NewRow()
        fila("apellidos") = c.Apellidos
        fila("codigo") = c.Codigo
        fila("direccion") = c.Direccion
        For Each doc As Documento In c.Documentos
        	MnjDocumentos.AddDocumento(doc, ds)
        Next
        fila("estado") = c.Estado
        fila("nombres") = c.Nombres
        For Each tel As Telefono In c.Telefonos
        	MnjTelefonos.AddTelefono(tel, ds)
        Next
        fila("usuario") = c.Usuario.Codigo
        Ds.Tables("clientes").Rows.Add(fila)
    End Sub

    Public Shared Sub EditCliente(ByVal c As Cliente, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("clientes").Rows
            If fila("codigo") = c.Codigo Then
                fila("apellidos") = c.Apellidos
                fila("direccion") = c.Direccion
                For Each doc As Documento In c.Documentos
                	MnjDocumentos.EditDocumento(doc, ds)
                Next
                fila("estado") = c.Estado
                fila("nombres") = c.Nombres
                For Each tel As Telefono In c.Telefonos
                	MnjTelefonos.EditTelefono(tel, ds)
                Next
                fila("usuario") = c.Usuario.Codigo
            End If
        Next
    End Sub

    Public Shared Sub DelCliente(ByVal c As Cliente, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("clientes").Rows
            If (fila("codigo") = c.Codigo) Then
                Ds.Tables("clientes").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from clientes where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", c.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        End Sub

        Public Shared Function GetClienteFromUser(ByVal codUser As Integer, ByVal ds As DataSet) As Cliente
            For Each fila As DataRow In ds.Tables("usuarios").Rows
                If (fila("codigo") = codUser) Then
                    For Each fila2 As DataRow In ds.Tables("clientes").Rows
                        If (fila2("usuario") = fila("codigo")) Then
                            Return MnjClientes.GetCliente(fila2("codigo"), ds)
                        End If
                    Next
                End If
            Next
            Return Nothing
        End Function
End Class
end namespace
