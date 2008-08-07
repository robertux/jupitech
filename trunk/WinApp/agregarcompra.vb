Imports Jupitech.Manejadores
Imports Jupitech.Entidades
Imports CDS.PgSql
Imports System.Data
Namespace WinApp
    Public Class agregarcompra
        Public items As New List(Of ItemTransaccion)
        Dim ds As CustomPgSqlDataSource
        Public cmp As Compra
        Public total As Double = 0

        Private Sub agregarcompra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ds = Manejador.GetDS
            Me.cmbtipocomp.SelectedIndex = 0
            Me.cmbtipoventa.SelectedIndex = 0
            Me.grditems.Columns.Clear()
            Me.grditems.Columns.Add("Producto", "Producto")
            Me.grditems.Columns.Add("Cantidad", "Cantidad")
            Me.grditems.Columns.Add("Precio Unitario", "Precio Unitario")
            Me.grditems.Columns.Add("Subtotal", "Subtotal")
            Me.grditems.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.grditems.AllowUserToAddRows = False
            Me.grditems.AllowUserToDeleteRows = False
            Me.grditems.ReadOnly = True
            Me.grditems.MultiSelect = False
            Me.btnborraritem.Enabled = False
            Me.lbltotal.Text = total.ToString
            Me.txtproveedor.Text = ""
        End Sub


        Private Sub btnagregaritem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregaritem.Click
            If txtproducto.Text <> "" Or txtcantidad.Text <> "" Then
                Dim prd As Producto = MnjProductos.GetProducto(CInt(txtproducto.Text), ds.DS)
                If prd Is Nothing Then
                    MsgBox("No se encontro el producto")
                Else
                    Me.items.Add(New ItemTransaccion(0, prd, CInt(txtcantidad.Text), Nothing))
                    Me.agregaritem(Me.items(Me.items.Count - 1))
                End If
            End If
        End Sub

        Public Sub agregaritem(ByVal item As ItemTransaccion)
            Me.grditems.Rows.Add()
            Me.grditems.Rows(Me.grditems.Rows.Count - 1).Cells(0).Value = item.Producto.Nombre
            Me.grditems.Rows(Me.grditems.Rows.Count - 1).Cells(1).Value = item.Cantidad.ToString
            Me.grditems.Rows(Me.grditems.Rows.Count - 1).Cells(2).Value = item.Producto.precios(item.Producto.precios.Count - 1).Monto
            Me.grditems.Rows(Me.grditems.Rows.Count - 1).Cells(3).Value = CDbl(item.Cantidad) * item.Producto.precios(item.Producto.precios.Count - 1).Monto
            If Me.grditems.Rows.Count = 0 Then
                Me.btnborraritem.Enabled = False
            Else
                Me.btnborraritem.Enabled = True
            End If
            Me.txtproducto.Text = ""
            Me.txtcantidad.Text = ""
            Me.txtproducto.Focus()
            total += CDbl(item.Cantidad) * item.Producto.precios(item.Producto.precios.Count - 1).Monto
            lbltotal.Text = total.ToString
        End Sub


        Private Sub btnborraritem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborraritem.Click
            total -= CDbl(Me.grditems.CurrentRow.Cells(3).Value)
            Me.items.Remove(Me.items(Me.grditems.CurrentRow.Index))
            Me.grditems.Rows.Remove(Me.grditems.CurrentRow)
            If Me.grditems.Rows.Count = 0 Then
                Me.grditems.CurrentCell = Nothing
                Me.btnborraritem.Enabled = False
            Else
                Me.grditems.CurrentCell = Me.grditems.Rows(0).Cells(0)
            End If
            lbltotal.Text = total.ToString
            Me.grditems.Refresh()
        End Sub


        Private Sub cmbtipoventa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipoventa.SelectedIndexChanged
            If Me.cmbtipoventa.Text = "Credito" Then
                Me.btnguardar.Text = "Aceptar"
            Else
                Me.btnguardar.Text = "Guardar"
            End If
        End Sub
        Public Function tipocomprob() As String
            Dim comp As String
            If Me.cmbtipocomp.Text = "Consumidor Final" Then
                comp = "ConsFinal"
            Else
                comp = "CredFiscal"
            End If
            Return comp
        End Function

        Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
            'If Me.items.Count <> 0 And Me.txtproveedor.Text <> "" And Me.cmbtipodoc.Text <> "" Then
            '    cmp = New Compra(MnjProveedores.GetProveedor(CInt(Me.txtproveedor.Text), ds.DS), Date.Now, MnjSucursales.GetSucursal(CInt(MainForm.CM("sucursal")), ds.DS), tipocomprob(), Me.cmbtipoventa.Text, MnjDocumentosPago.GetDocumentoPago(CInt(Me.cmbtipodoc.Text.Split("-")(0)), ds.DS), 0, items, Nothing)
            '    If Me.btnguardar.Text = "Guardar" Then
            '        MnjCompras.AddCompra(cmp, ds.DS)
            '        ds.ActualizarBD()
            '        ds.CargarDS()
            '        For Each itm As ItemTransaccion In Me.items
            '            itm.Transaccion = MnjCompras.GetLastCode(New Npgsql.NpgsqlConnection(ds.CadenaConexion))
            '            MnjItemsTransaccion.AddItemTransaccion(itm, ds.DS)
            '        Next
            '        ds.ActualizarBD()
            '        Compras.Gridcompras1.llenar(ds.DS.Tables("compras"), ds.DS)
            '        Me.Close()

            '    Else
            ''crearabonos.ShowDialog()
            '    End If
            'Else
            'MsgBox("Faltan datos en la compra")
            'End If
        End Sub

    End Class
End Namespace
