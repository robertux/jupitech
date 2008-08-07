Imports system.data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports CDS.PgSql
Imports Npgsql

Namespace WinApp
    Public Class VendedorDialog
        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
            Me.Close()
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox3.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else
                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                Dim vend As New Vendedor(TextBox4.Text, CDbl(TextBox5.Text), MnjSucursales.GetSucursal(CInt(MainForm.CM("sucursal")), ds.DS), TextBox2.Text, TextBox1.Text, TextBox3.Text, 0, Nothing, New List(Of Documento), New List(Of Telefono))
                MnjVendedores.AddVendedor(vend, ds.DS)
                ds.ActualizarBD()
                Vendedores.Gridvendedores1.mostrarvendedores()
                MsgBox("El registro ha sido agregado.", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub
        Public Sub cargarRegistro(ByVal cod As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim vend As Vendedor
            vend = MnjVendedores.GetVendedor(cod, ds.DS)
            Me.TextBox1.Text = vend.Nombres.ToString
            Me.TextBox2.Text = vend.Apellidos.ToString
            Me.TextBox3.Text = vend.Direccion.ToString
            Me.TextBox4.Text = vend.Cargo
            Me.TextBox5.Text = vend.SueldoBase.ToString
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox3.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else

                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                Dim vend As Vendedor = MnjVendedores.GetVendedor(Vendedores.seleccionar, ds.DS)
                vend.Apellidos = TextBox2.Text
                vend.Nombres = TextBox1.Text
                vend.Direccion = TextBox3.Text
                vend.Cargo = Me.TextBox4.Text
                vend.SueldoBase = CDbl(Me.TextBox5.Text)
                MnjVendedores.EditVendedor(vend, ds.DS)
                ds.ActualizarBD()
                Vendedores.Gridvendedores1.mostrarvendedores()
                MsgBox("Operación completada", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub

    End Class
End Namespace