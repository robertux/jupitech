Imports system.data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports CDS.PgSql

Namespace WinApp
    Public Class ClientesDialog

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
            Me.Close()
        End Sub
        Public Sub cargarRegistro(ByVal cod As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim cl As Cliente
            cl = MnjClientes.GetCliente(cod, ds.DS)
            Me.TextBox1.Text = cl.Nombres.ToString
            Me.TextBox2.Text = cl.Apellidos.ToString
            For i As Integer = 0 To Me.ComboBox1.Items.Count - 1
                If String.Compare(Me.ComboBox1.Items(i).ToString().Trim(), cl.Estado.Trim()) = 0 Then
                    Me.ComboBox1.SelectedIndex = i
                End If
                Me.TextBox4.Text = cl.Direccion.ToString
            Next
        End Sub

        Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox4.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else
                Dim cl As New Cliente(ComboBox1.SelectedItem.ToString, TextBox2.Text, TextBox1.Text, TextBox4.Text, "0", Nothing, New List(Of Documento), New List(Of Telefono))
                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                MnjClientes.AddCliente(cl, ds.DS)
                ds.ActualizarBD()
                Clientes.GridClientes1.mostrarclientes()
                MsgBox("El registro ha sido agregado.", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub


        Private Sub btnmodificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmodificar.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox4.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else

                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                Dim cl As Cliente = MnjClientes.GetCliente(Clientes.seleccionar, ds.DS)
                cl.Estado = ComboBox1.SelectedItem.ToString
                cl.Apellidos = TextBox2.Text
                cl.Nombres = TextBox1.Text
                cl.Direccion = TextBox4.Text
                MnjClientes.EditCliente(cl, ds.DS)
                ds.ActualizarBD()
                Clientes.GridClientes1.mostrarclientes()
                MsgBox("Operación completada", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub

        Private Sub btneliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btneliminar.Click
            If (Me.TextBox1.Text = "") Or (Me.TextBox2.Text = "") Or (Me.TextBox4.Text = "") Then
                MsgBox("Debe llenar los campos vacios!!", MsgBoxStyle.Critical, "Información")
            Else

                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                Dim cl As Cliente = MnjClientes.GetCliente(Clientes.seleccionar, ds.DS)
                cl.Estado = ComboBox1.SelectedItem.ToString
                cl.Apellidos = TextBox2.Text
                cl.Nombres = TextBox1.Text
                cl.Direccion = TextBox4.Text
                MnjClientes.EditCliente(cl, ds.DS)
                ds.ActualizarBD()
                Clientes.GridClientes1.mostrarclientes()
                MsgBox("Operación completada", MsgBoxStyle.Information, "Información")
                Me.Close()
            End If
        End Sub
    End Class
End Namespace