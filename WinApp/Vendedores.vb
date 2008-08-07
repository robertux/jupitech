Imports CDS.PgSql
Imports Jupitech.Manejadores
Imports Jupitech.Entidades
Imports System.Data
Imports Npgsql

Namespace WinApp
    Public Class Vendedores
        Public ReadOnly Property seleccionar() As Integer
            Get
                Return CInt(Me.Gridvendedores1.CurrentRow.Cells(0).Value)
            End Get
        End Property
        Public addtel As Boolean = False
        Public adddoc As Boolean = False

        Private Sub vendedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Gridvendedores1.mostrarvendedores()
        End Sub


        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
            vendedorDialog.Text = "..::Agregar vendedor::.."
            vendedorDialog.Button3.Visible = False
            vendedorDialog.Button3.Visible = True
            vendedorDialog.TextBox1.Text = ""
            vendedorDialog.TextBox2.Text = ""
            vendedorDialog.TextBox3.Text = ""
            vendedorDialog.ShowDialog()
        End Sub



        Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
            vendedorDialog.Text = "..::Modificar vendedor::.."
            vendedorDialog.Button3.Visible = False
            vendedorDialog.Button3.Visible = True
            vendedorDialog.cargarRegistro(Me.seleccionar)
            vendedorDialog.ShowDialog()
        End Sub

        Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
            vendedorDialog.Text = "..::Eliminar vendedor::.."
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim prov As vendedor = MnjVendedores.GetVendedor(Me.seleccionar, ds.DS)
            MnjVendedores.DelVendedor(prov, ds.DS, New NpgsqlConnection(ds.CadenaConexion))
            ds.ActualizarBD()
            Me.Gridvendedores1.mostrarvendedores()
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Información")
        End Sub
    End Class
End Namespace