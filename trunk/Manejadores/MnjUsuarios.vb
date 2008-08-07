Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjUsuarios

    Public Shared Function GetUsuario(ByVal codigo As Integer, ByVal ds As DataSet) As Usuario
        For Each fila As DataRow In ds.Tables("usuarios").Rows
            If (fila("codigo") = codigo) Then
                Return New Usuario(fila("nombre"), fila("clave"), fila("codigo"))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function GetUsuario(ByVal nombre As String, ByVal clave As String, ByVal ds As DataSet) As Usuario
        For Each fila As DataRow In ds.Tables("usuarios").Rows
            If (fila("nombre") = nombre And fila("clave") = clave) Then
                Return New Usuario(fila("nombre"), fila("clave"), fila("codigo"))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddUsuario(ByVal u As Usuario, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("usuarios").NewRow()
        fila("codigo") = u.Codigo
        fila("clave") = u.Clave
        fila("nombre") = u.Nombre
        Ds.Tables("usuarios").Rows.Add(fila)
    End Sub

    Public Shared Sub EditUsuario(ByVal u As Usuario, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("usuarios").Rows
            If (fila("codigo") = u.Codigo) Then
                fila("clave") = u.Clave
                fila("nombre") = u.Nombre
            End If
        Next
    End Sub

    Public Shared Sub DelUsuario(ByVal u As Usuario, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("usuarios").Rows
            If (fila("codigo") = u.Codigo) Then
                Ds.Tables("usuarios").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from usuarios where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", u.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
