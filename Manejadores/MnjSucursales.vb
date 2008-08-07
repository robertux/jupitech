Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjSucursales
	    Public Shared Function GetSucursal(ByVal codigo As Integer, ByVal ds As DataSet) As Sucursal
        For Each fila As DataRow In ds.Tables("sucursales").Rows
            If (fila("codigo") = codigo) Then
                Return New Sucursal(fila("nombre"), fila("direccion"), MnjPersonas.GetPersona(fila("encargado"),ds), fila("codigo"))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddSucursal(ByVal s As Sucursal, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("sucursales").NewRow()
	fila("nombre") = s.Nombre
	fila("direccion") = s.Direccion
	fila("encargado") = s.Encargado.Codigo
	fila("codigo") = s.Codigo
        Ds.Tables("sucursales").Rows.Add(fila)
    End Sub

    Public Shared Sub EditSucursal(ByVal s As Sucursal, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("sucursales").Rows
            If (fila("codigo") = s.Codigo) Then
		fila("nombre") = s.Nombre
		fila("direccion") = s.Direccion
		fila("encargado") = s.Encargado.Codigo
            End If
        Next
    End Sub

    Public Shared Sub DelSucursal(ByVal s as Sucursal, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("sucursales").Rows
            If (fila("codigo") = s.Codigo) Then
                Ds.Tables("sucursales").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from sucursales where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", s.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
