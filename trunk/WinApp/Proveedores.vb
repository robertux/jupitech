Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports Npgsql

Namespace WinApp
    Public Class Proveedores
        Public ReadOnly Property seleccionar() As Integer
            Get
                Return CInt(Me.Gridproveedores1.CurrentRow.Cells(0).Value)
            End Get
        End Property
        Public addtel As Boolean = False
        Public adddoc As Boolean = False

        Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Gridproveedores1.mostrarproveedores()
        End Sub


        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
            ProveedorDialog.Text = "..::Agregar Proveedor::.."
            ProveedorDialog.Button3.Visible = False
            ProveedorDialog.Button1.Visible = True
            ProveedorDialog.TextBox1.Text = ""
            ProveedorDialog.TextBox2.Text = ""
            ProveedorDialog.TextBox3.Text = ""
            ProveedorDialog.ShowDialog()
        End Sub



        Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
            ProveedorDialog.Text = "..::Modificar Proveedor::.."
            ProveedorDialog.Button1.Visible = False
            ProveedorDialog.Button3.Visible = True
            ProveedorDialog.cargarRegistro(Me.seleccionar)
            ProveedorDialog.ShowDialog()
        End Sub

        Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim prov As Proveedor = MnjProveedores.GetProveedor(Me.seleccionar, ds.DS)
            MnjProveedores.DelProveedor(prov, ds.DS, New NpgsqlConnection(ds.CadenaConexion))
            ds.ActualizarBD()
            Me.Gridproveedores1.mostrarproveedores()
            MsgBox("Registro eliminado", MsgBoxStyle.Information, "Información")
        End Sub

        Private Sub Gridproveedores1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gridproveedores1.SelectionChanged
            Me.GridDocumentos1.mostrarDocumentos(CInt(Me.Gridproveedores1.CurrentRow.Cells(0).Value))
            Me.GridTelefonos1.mostrarTelefonos(CInt(Me.Gridproveedores1.CurrentRow.Cells(0).Value))
        End Sub

        Private Sub btnDelDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelDoc.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
            MnjDocumentos.DelDocumento(MnjDocumentos.GetDocumento(CInt(Me.GridDocumentos1.CurrentRow.Cells("codigo").Value), ds.DS), ds.DS, New NpgsqlConnection(ds.CadenaConexion))
            Me.GridDocumentos1.mostrarDocumentos(Me.seleccionar)
        End Sub

        Private Sub btnDelTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelTel.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
            MnjTelefonos.DelTelefono(MnjTelefonos.GetTelefono(CInt(Me.GridTelefonos1.CurrentRow.Cells("codigo").Value), ds.DS), ds.DS, New NpgsqlConnection(ds.CadenaConexion))
            Me.GridTelefonos1.mostrarTelefonos(Me.seleccionar)
        End Sub

        Private Sub btnAddDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDoc.Click
            Me.adddoc = True
            AddEditDoc.ShowDialog()
        End Sub

        Private Sub btnEditDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.adddoc = False
            AddEditDoc.ShowDialog()
        End Sub

        Private Sub btnAddTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTel.Click
            Me.addtel = True
            AddEditTel.ShowDialog()
        End Sub

        Private Sub btnEditTel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.addtel = False
            AddEditTel.ShowDialog()
        End Sub
    End Class
End Namespace