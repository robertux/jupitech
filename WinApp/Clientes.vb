Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports Npgsql

Namespace WinApp
    Public Class Clientes

        Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.GridClientes1.mostrarclientes()
        End Sub
        Public ReadOnly Property seleccionar() As Integer
            Get
                Return CInt(Me.GridClientes1.CurrentRow.Cells(0).Value)
            End Get
        End Property

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
            ClientesDialog.Text = "..::Agregar cliente::.."
            ClientesDialog.btnagregar.Visible = True
            clientesDialog.TextBox1.Text = ""
            clientesDialog.TextBox2.Text = ""
            ClientesDialog.TextBox4.Text = ""
            clientesDialog.ShowDialog()
        End Sub

        Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
            ClientesDialog.Text = "..::Modificar Cliente::.."
            ClientesDialog.btnagregar.Visible = False
            ClientesDialog.btnmodificar.Visible = True
            ClientesDialog.cargarRegistro(Me.seleccionar)
            ClientesDialog.ShowDialog()
        End Sub

        Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim cl As Cliente = MnjClientes.GetCliente(Me.seleccionar, ds.DS)
            MnjClientes.DelCliente(cl, ds.DS, New NpgsqlConnection(ds.CadenaConexion))
            ds.ActualizarBD()
            Me.GridClientes1.mostrarclientes()
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Información")
        End Sub
    End Class
End Namespace