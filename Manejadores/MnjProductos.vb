Imports Jupitech.Entidades
Imports Npgsql

Namespace Manejadores
    Public Class MnjProductos
        Public Shared Function GetProducto(ByVal codigo As Integer, ByVal ds As DataSet) As Producto
            For Each fila As DataRow In ds.Tables("productos").Rows
                If (fila("codigo") = codigo) Then
                    Dim strImg As String
                    If (TypeOf (fila("imagen")) Is DBNull) Then
                        strImg = ""
                    Else
                        strImg = fila("imagen")
                    End If
                    Dim promo As Promocion
                    If (TypeOf (fila("promocion")) Is DBNull) Then
                        promo = Nothing
                    Else
                        promo = MnjPromociones.GetPromocion(fila("promocion"), ds)
                    End If
                    Return New Producto(fila("nombre"), fila("descripcion"), fila("marca"), fila("modelo"), MnjTiposProductos.GetTipoProducto(fila("tipo"), ds), strImg, fila("codigo"), MnjCostosProductos.GetCostosFrom(fila("codigo"), ds), MnjPreciosProductos.GetPreciosFrom(fila("codigo"), ds), promo)
                End If
            Next
            Return Nothing
        End Function

        Public Shared Function GetProductosFrom(ByVal codPromocion As String, ByVal ds As DataSet) As List(Of Producto)
            Dim prods As New List(Of Producto)
            For Each fila As DataRow In ds.Tables("productos").Rows
                If (fila("promocion") = codPromocion) Then
                    prods.Add(New Producto(fila("nombre"), fila("descripcion"), fila("marca"), fila("modelo"), fila("tipo"), fila("imagen"), fila("codigo"), MnjCostosProductos.GetCostosFrom(fila("codigo"), ds), MnjPreciosProductos.GetPreciosFrom(fila("codigo"), ds), MnjPromociones.GetPromocion(fila("promocion"), ds)))
                End If
            Next
            Return prods
        End Function

        Public Shared Sub AddProducto(ByVal p As Producto, ByVal Ds As DataSet)
            Dim fila As DataRow = Ds.Tables("productos").NewRow()
            fila("nombre") = p.Nombre
            fila("descripcion") = p.Descripcion
            fila("marca") = p.marca
            fila("modelo") = p.modelo
            fila("tipo") = p.Tipo.Codigo
            fila("imagen") = p.Imagen
            fila("codigo") = p.Codigo
            For Each precio As PrecioProducto In p.precios
                MnjPreciosProductos.AddPrecioProducto(precio, ds)
            Next
            For Each costo As CostoProducto In p.costos
                MnjCostosProductos.AddCostoProducto(costo, ds)
            Next
            If Not p.Promocion Is Nothing Then
                fila("promocion") = p.Promocion.codigo
            End If
            Ds.Tables("productos").Rows.Add(fila)
        End Sub

        Public Shared Sub EditProducto(ByVal p As Producto, ByVal Ds As DataSet)
            For Each fila As DataRow In Ds.Tables("productos").Rows
                If (fila("codigo") = p.Codigo) Then
                    fila("nombre") = p.Nombre
                    fila("descripcion") = p.Descripcion
                    fila("marca") = p.marca
                    fila("modelo") = p.modelo
                    fila("tipo") = p.Tipo
                    fila("imagen") = p.Imagen
                    For Each precio As PrecioProducto In p.precios
                        MnjPreciosProductos.EditPrecioProducto(precio, ds)
                    Next
                    For Each costo As CostoProducto In p.costos
                        MnjCostosProductos.EditCostoProducto(costo, ds)
                    Next
                    If Not p.Promocion Is Nothing Then
                        fila("promocion") = p.Promocion.codigo
                    End If
                End If
            Next
        End Sub

        Public Shared Sub DelProducto(ByVal p As Producto, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
            Dim cmd1 As New NpgsqlCommand("Delete from prodsucursal where producto= :codprod", cn)
            cmd1.Parameters.Add(New NpgsqlParameter(":codprod", p.Codigo))
            Dim cmd2 As New NpgsqlCommand("Delete from combosproductos where producto= :codprod", cn)
            cmd2.Parameters.Add(New NpgsqlParameter(":codprod", p.Codigo))
            Dim cmd As New NpgsqlCommand("Delete from productos where codigo = :codigo", cn)
            cmd.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
            Dim cmd3 As New NpgsqlCommand("Delete from costosproductos where producto = :codigo", cn)
            cmd3.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
            Dim cmd4 As New NpgsqlCommand("Delete from preciosproductos where producto = :codigo", cn)
            cmd4.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))
            Dim cmd5 As New NpgsqlCommand("Delete from proveedoresproductos where producto = :codigo", cn)
            cmd5.Parameters.Add(New NpgsqlParameter(":codigo", p.Codigo))

            cn.Open()
            cmd1.ExecuteNonQuery()
            cmd2.ExecuteNonQuery()
            cmd3.ExecuteNonQuery()
            cmd4.ExecuteNonQuery()
            cmd5.ExecuteNonQuery()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Sub
    End Class
End Namespace
