Imports system.data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports CDS.PgSql

Namespace WinApp
    Public Class ProveedorDialog
        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
            Me.Close()
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox3.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else
                Dim prov As New Proveedor(ComboBox1.SelectedItem.ToString, TextBox2.Text, TextBox1.Text, TextBox3.Text, "0", Nothing, New List(Of Documento), New List(Of Telefono))
                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                MnjProveedores.AddProveedor(prov, ds.DS)
                ds.ActualizarBD()
                Proveedores.Gridproveedores1.mostrarproveedores()
                MsgBox("El registro ha sido agregado.", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub
        Public Sub cargarRegistro(ByVal cod As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim prov As Proveedor
            prov = MnjProveedores.GetProveedor(cod, ds.DS)
            Me.TextBox1.Text = prov.Nombres.ToString
            Me.TextBox2.Text = prov.Apellidos.ToString
            For i As Integer = 0 To Me.ComboBox1.Items.Count - 1
                If String.Compare(Me.ComboBox1.Items(i).ToString().Trim(), prov.Tipo.Trim()) = 0 Then
                    Me.ComboBox1.SelectedIndex = i
                End If
                Me.TextBox3.Text = prov.Direccion.ToString
            Next
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox3.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else

                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                Dim prov As Proveedor = MnjProveedores.GetProveedor(Proveedores.seleccionar, ds.DS)
                prov.Tipo = ComboBox1.SelectedItem.ToString
                prov.Apellidos = TextBox2.Text
                prov.Nombres = TextBox1.Text
                prov.Direccion = TextBox3.Text
                MnjProveedores.EditProveedor(prov, ds.DS)
                ds.ActualizarBD()
                Proveedores.Gridproveedores1.mostrarproveedores()
                MsgBox("Operación completada", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub

    End Class
End Namespace