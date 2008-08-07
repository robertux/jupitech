Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports Npgsql
Namespace WinApp
    Public Class Productos
        Public ReadOnly Property seleccionar() As Integer
            Get
                Return CInt(Me.Gridproducto1.CurrentRow.Cells(0).Value)
            End Get
        End Property
        Public subtipo As Boolean
        Public codtipo As Integer
        Public editar As Boolean
        Public prod As Boolean
        Private Sub ArbolProductos1_NodeClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles ArbolProductos1.NodeClick
            Dim items As String() = e.Node.Text.Split("-")
            Me.codtipo = CInt(items(0))
            Me.Gridproducto1.mostrarproductos(codtipo)
        End Sub
        Private Sub Gridproducto1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gridproducto1.SelectionChanged
            Try
                Me.Gridcostos1.mostrarcostos(CInt(Me.Gridproducto1.CurrentRow.Cells(0).Value))
                Me.Gridprecios1.mostrarprecios(CInt(Me.Gridproducto1.CurrentRow.Cells(0).Value))
            Catch
            End Try
        End Sub

        Private Sub btnAgregarTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarTipo.Click
            Me.subtipo = False
            Me.editar = False
            AgregarTipoProducto.Show()
        End Sub

        Private Sub btnAgregarSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSubTipo.Click
            Me.subtipo = True
            Me.editar = False
            AgregarTipoProducto.Show()
        End Sub

        Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub

        Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
            Me.editar = True
            AgregarTipoProducto.Show()
        End Sub

        Private Sub tbAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbAgregar.Click
            Me.prod = True
            AgregarProducto.ShowDialog()
        End Sub

        Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

        End Sub

        Private Sub tbEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbEliminar.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim prod As Producto = MnjProductos.GetProducto(Me.seleccionar, ds.DS)
            MnjProductos.DelProducto(prod, ds.DS, New NpgsqlConnection(ds.CadenaConexion))
            ds.ActualizarBD()
            ds.CargarDS()
            Me.Gridproducto1.Rows.Remove(Gridproducto1.CurrentRow)
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Información")

        End Sub

        Private Sub tbModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbModificar.Click
            AgregarProducto.cargarRegistro(Me.seleccionar)
            AgregarProducto.Show()

        End Sub
    End Class
End Namespace