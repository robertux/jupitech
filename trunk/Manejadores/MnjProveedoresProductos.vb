Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjProveedoresProductos
	    Public Shared Function GetProveedorProducto(ByVal codigo As Integer, ByVal ds As DataSet) As ProveedorProducto
        For Each fila As DataRow In ds.Tables("proveedoresproductos").Rows
            If (fila("codigo") = codigo) Then
                Return New ProveedorProducto(MnjProveedores.GetProveedor(fila("proveedor"),ds), MnjProductos.GetProducto(fila("producto"),ds), fila("cantidad"), fila("codigo"))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddProveedorProducto(ByVal p As ProveedorProducto, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("proveedoresproductos").NewRow()
	fila("proveedor") = p.Proveedor.Codigo
	fila("producto") = p.Producto.Codigo
	fila("cantidad") = p.Cantidad
	fila("codigo") = p.Codigo
        Ds.Tables("proveedoresproductos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditProveedorProducto(ByVal p As ProveedorProducto, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("proveedoresproductos").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("proveedor") = p.Proveedor.Codigo
		fila("producto") = p.Producto.Codigo
		fila("cantidad") = p.Cantidad
            End If
        Next
    End Sub

    Public Shared Sub DelProveedorProducto(ByVal p as ProveedorProducto, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("proveedoresproductos").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("proveedoresproductos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from proveedoresproductos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
