Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjTiposProductos
	    Public Shared Function GetTipoProducto(ByVal codigo As Integer, ByVal ds As DataSet) As TipoProducto
        For Each fila As DataRow In ds.Tables("tiposproductos").Rows
            If (fila("codigo") = codigo) Then
                Return New TipoProducto(fila("nombre"), fila("descripcion"), fila("superior"), fila("codigo"))
            End If
        Next
        Return Nothing
        End Function

        Public Shared Function GetTiposProductos(ByVal ds As DataSet) As List(Of TipoProducto)
            Dim tipos As New List(Of TipoProducto)
            For Each fila As DataRow In ds.Tables("tiposproductos").Rows
                tipos.Add(New TipoProducto(fila("nombre"), fila("descripcion"), fila("superior"), fila("codigo")))
            Next
            Return tipos
        End Function

    Public Shared Sub AddTipoProducto(ByVal t As TipoProducto, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("tiposproductos").NewRow()
	fila("nombre") = t.Nombre
	fila("descripcion") = t.Descripcion
	fila("superior") = t.Superior
	fila("codigo") = t.Codigo
        Ds.Tables("tiposproductos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditTipoProducto(ByVal t As TipoProducto, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("tiposproductos").Rows
            If (fila("codigo") = t.Codigo) Then
		fila("nombre") = t.Nombre
		fila("descripcion") = t.Descripcion
		fila("superior") = t.Superior
            End If
        Next
    End Sub

    Public Shared Sub TipoProducto(ByVal t as TipoProducto, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("tiposproductos").Rows
            If (fila("codigo") = t.Codigo) Then
                Ds.Tables("tiposproductos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from tiposproductos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", t.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
