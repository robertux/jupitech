Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class AgregarTipoProducto
        Public tipo As TipoProducto
        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            
            If Productos.editar = True Then
                Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                tipo.Nombre = txtNombre.Text
                tipo.Descripcion = txtdescripcion.Text
                MnjTiposProductos.EditTipoProducto(tipo, ds.DS)
                ds.ActualizarBD()
                Productos.ArbolProductos1.Rellenar()
                Me.Close()
            Else
                If Productos.subtipo = True Then
                    Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                    Dim superior As TipoProducto = MnjTiposProductos.GetTipoProducto(Productos.codtipo, ds.DS)
                    Dim tipo As New TipoProducto(txtNombre.Text, txtdescripcion.Text, superior.Codigo, 0)
                    MnjTiposProductos.AddTipoProducto(tipo, ds.DS)
                    ds.ActualizarBD()
                    Productos.ArbolProductos1.Rellenar()
                    Me.Close()
                Else
                    Dim ds As CustomPgSqlDataSource = Manejador.GetDS
                    Dim hermano As TipoProducto = MnjTiposProductos.GetTipoProducto(Productos.codtipo, ds.DS)
                    Dim tipo As New TipoProducto(txtNombre.Text, txtdescripcion.Text, hermano.Superior, 0)
                    MnjTiposProductos.AddTipoProducto(tipo, ds.DS)
                    ds.ActualizarBD()
                    Productos.ArbolProductos1.Rellenar()
                    Me.Close()

                End If
            End If
        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub

        Private Sub AgregarTipoProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            tipo = MnjTiposProductos.GetTipoProducto(Productos.codtipo, ds.DS)
            txtNombre.Text = tipo.Nombre
            txtdescripcion.Text = tipo.Descripcion
        End Sub
    End Class
End Namespace