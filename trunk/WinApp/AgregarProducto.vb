Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports System.IO
Namespace WinApp
    Public Class AgregarProducto
        Private Sub btnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImagen.Click
            If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim archivo As String = Me.OpenFileDialog1.FileName.Substring(Me.OpenFileDialog1.FileName.LastIndexOf("\") + 1)
                Me.txtImagen.Text = archivo
            End If

        End Sub


        Private Sub AgregarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Me.txtNombre.Text = ""
            'Me.txtDescripcion.Text = ""
            'Me.txtImagen.Text = ""
            'Me.txtMarca.Text = ""
            'Me.txtModelo.Text = ""
            Me.llenarCombo()
        End Sub
        Public Sub llenarCombo()
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tablas As DataTable = ds.DS.Tables("tiposproductos")
            Me.cmbtipo.Items.Clear()
            For Each fila As DataRow In tablas.Rows
                Me.cmbtipo.Items.Add(fila("codigo").ToString + "-" + fila("nombre").ToString)
            Next

        End Sub
        Public Sub cargarRegistro(ByVal cod As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim prod As Producto
            prod = MnjProductos.GetProducto(cod, ds.DS)
            Me.txtNombre.Text = prod.Nombre
            Me.txtDescripcion.Text = prod.Descripcion
            For i As Integer = 0 To Me.cmbtipo.Items.Count - 1
                If String.Compare(Me.cmbtipo.Items(i).ToString.Trim, prod.Tipo.ToString.Trim()) = 0 Then
                    Me.cmbtipo.SelectedIndex = i
                End If
            Next
            Me.btnImagen.Enabled = False
            Me.txtImagen.Text = prod.Imagen
            Me.txtMarca.Text = prod.marca
            Me.txtModelo.Text = prod.modelo
        End Sub

        Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tipo1 As New Producto(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtModelo.Text, MnjTiposProductos.GetTipoProducto(CInt(cmbtipo.Text.Split("-")(0)), ds.DS), Me.txtImagen.Text, 0, New List(Of CostoProducto), New List(Of PrecioProducto), Nothing)
            If Not File.Exists(Application.StartupPath + "\" + Me.txtImagen.Text) Then
                File.Copy(Me.OpenFileDialog1.FileName, Application.StartupPath + "\" + Me.txtImagen.Text)
            End If
            MnjProductos.AddProducto(tipo1, ds.DS)
            ds.ActualizarBD()
            Me.Close()
        End Sub


        Private Sub cmbtipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtipo.SelectedIndexChanged

        End Sub
    End Class
End Namespace