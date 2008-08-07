Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjPreciosProductos
	    Public Shared Function GetPrecioProducto(ByVal codigo As Integer, ByVal ds As DataSet) As PrecioProducto
        For Each fila As DataRow In ds.Tables("preciosproductos").Rows
            If (fila("codigo") = codigo) Then
                    Return New PrecioProducto(fila("fecha"), fila("monto"), fila("codigo"), (fila("producto")))
            End If
        Next
        Return Nothing
    End Function
    
        Public Shared Function GetPreciosFrom(ByVal codProducto As Integer, ByVal ds As DataSet) As List(Of PrecioProducto)
            Dim precios As New List(Of PrecioProducto)
            For Each fila As DataRow In ds.Tables("preciosproductos").Rows
                If (fila("producto") = codProducto) Then
                    precios.Add(New PrecioProducto(fila("fecha"), fila("monto"), fila("codigo"), (fila("producto"))))
                End If
            Next
            Return precios
        End Function

    Public Shared Sub AddPrecioProducto(ByVal p As PrecioProducto, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("preciosproductos").NewRow()
	fila("fecha") = p.Fecha
	fila("monto") = p.Monto
	fila("codigo") = p.Codigo
            fila("producto") = p.Producto
        Ds.Tables("preciosproductos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditPrecioProducto(ByVal p As PrecioProducto, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("preciosproductos").Rows
            If (fila("codigo") = p.Codigo) Then
		fila("fecha") = p.Fecha
		fila("monto") = p.Monto
                    fila("producto") = p.Producto
            End If
        Next
    End Sub

    Public Shared Sub DelPrecioProducto(ByVal p as PrecioProducto, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("preciosproductos").Rows
            If (fila("codigo") = p.Codigo) Then
                Ds.Tables("preciosproductos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from preciosproductos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
