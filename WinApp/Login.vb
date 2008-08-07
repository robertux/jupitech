Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports CDS.PgSql
Imports XmlClassLib

Namespace WinApp
    Public Class Login

        Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
            Dim u As Usuario = MnjUsuarios.GetUsuario(Me.txtUsuario.Text, Me.txtClave.Text, ds.DS)
            If (u Is Nothing) Then
                Me.lblIncorrecto.Visible = True
            Else
                Dim cm As New ConfigManager("app.config")
                cm.EditValor("logued", u.Nombre)
                cm.EditValor("cod", u.Codigo.ToString)
                If (cm.GetClaves.Contains("sucursal")) Then
                    cm.EditValor("sucursal", Me.Cmbsucursales1.selected.ToString)
                Else
                    cm.AddClave("sucursal", Me.Cmbsucursales1.selected.ToString)
                End If
                Me.Close()
            End If
        End Sub

        Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged, txtClave.TextChanged
            Me.lblIncorrecto.Visible = False
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub

        Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.txtClave.Text = ""
            Me.txtUsuario.Text = ""
            Me.Cmbsucursales1.mostrar()
        End Sub

        
    End Class
End Namespace
