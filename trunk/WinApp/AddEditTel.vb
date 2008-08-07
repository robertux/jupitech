Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports CDS.PgSql

Namespace WinApp
    Public Class AddEditTel
        Private tel As Telefono

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            If Not (Proveedores.addtel) Then
            Else
                tel = New Telefono(Me.txtTipo.Text, CInt(Me.txtNumero.Text), 0, Proveedores.seleccionar)
                MnjTelefonos.AddTelefono(tel, ds.DS)
                ds.ActualizarBD()
                Proveedores.GridTelefonos1.mostrarTelefonos(Proveedores.seleccionar)
                Me.Close()
            End If
        End Sub

        Private Sub AddEditTel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub
    End Class
End Namespace