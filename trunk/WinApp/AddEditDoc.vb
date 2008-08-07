Imports CDS.PgSql
Imports Jupitech.Manejadores
Imports Jupitech.Entidades

Namespace WinApp
    Public Class AddEditDoc
        Private doc As Documento

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            If Not Proveedores.adddoc Then
            Else
                doc = New Documento(txtTipo.Text, CInt(txtNumero.Text), txtFormato.Text, 0, Proveedores.seleccionar)
                MnjDocumentos.AddDocumento(doc, ds.DS)
                ds.ActualizarBD()
                Proveedores.GridDocumentos1.mostrarDocumentos(Proveedores.seleccionar)
                Me.Close()
            End If
        End Sub
    End Class
End Namespace