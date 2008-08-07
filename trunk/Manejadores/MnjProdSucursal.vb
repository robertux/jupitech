Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjProdSucursal
	    Public Shared Function GetProdSucursal(ByVal codigo As Integer, ByVal ds As DataSet) As ProdSucursal
        For Each fila As DataRow In ds.Tables("prodsucursal").Rows
            If (fila("codigo") = codigo) Then
                Return New ProdSucursal(MnjProductos.GetProducto(fila("producto"),ds), MnjSucursales.GetSucursal(fila("sucursal"),ds), fila("existencia_actual"), fila("existencia_minima"), fila("codigo"))
            End If
        Next
        Return Nothing
    End Function

    Public Shared Sub AddProdSucursal(ByVal p As ProdSucursal, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("prodsucursal").NewRow()
	fila("producto") = p.Producto.Codigo
	fila("sucursal") = p.Sucursal.Codigo
	fila("existencia_actual") = p.ExistenciaActual
	fila("existencia_minima") = p.ExistenciaMinima
	fila("codigo") = p.Codigo
        Ds.Tables("prodsucursal").Rows.Add(fila)
    End Sub

    Public Shared Sub EditProdSucursal(ByVal p As ProdSucursal, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("prodsucursal").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("producto") = p.Producto.Codigo
		fila("sucursal") = p.Sucursal.Codigo
		fila("existencia_actual") = p.ExistenciaActual
		fila("existencia_minima") = p.ExistenciaMinima
            End If
        Next
    End Sub

    Public Shared Sub DelProdSucursal(ByVal p as ProdSucursal, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("prodsucursal").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("prodsucursal").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from prodsucursal where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
