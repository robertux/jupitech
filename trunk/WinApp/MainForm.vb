Imports XmlClassLib
Imports Gerencial


Namespace WinApp
    Partial Public Class MainForm
        Private _cm As ConfigManager

        Public Property CM() As ConfigManager
            Get
                Return Me._cm
            End Get
            Set(ByVal value As ConfigManager)
                Me._cm = value
            End Set
        End Property
        Public Sub New()
            Me.InitializeComponent()
            CM = New ConfigManager("App.config")
        End Sub

        Private Sub mnuCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCerrarSesion.Click
            CM.EditValor("logued", "nobody")
            Me.CheckLog()
            Me.MenuStrip1.Items(0).Enabled = False
            Me.MenuStrip1.Items(1).Enabled = False
        End Sub

        Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.MenuStrip1.Items(0).Enabled = False
            Me.MenuStrip1.Items(1).Enabled = False
            Me.CheckLog()
        End Sub

        Private Sub mnuIniSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIniSesion.Click
            Login.ShowDialog(Me)
            Me.CheckLog()
        End Sub

        Public Sub CheckLog()
            CM = Nothing
            CM = New ConfigManager("App.config")
            If (Not CM.GetClaves().Contains("logued")) Then
                CM.AddClave("logued", "nobody")
            End If
            If Not CM.GetClaves.Contains("cod") Then
                CM.AddClave("cod", "0")
            End If
            If (CM("logued") = "nobody") Then
                Me.lblUsuario.Text = "Desconocido"
                Me.mnuCerrarSesion.Text = "Cerrar Sesion"
                Me.mnuCerrarSesion.Visible = False
                Me.mnuIniSesion.Visible = True
            Else
                Me.lblUsuario.Text = CM("logued")
                Me.mnuCerrarSesion.Text = "Cerrar Sesion: " + CM("logued")
                Me.mnuCerrarSesion.Visible = True
                Me.mnuIniSesion.Visible = False
                Me.MenuStrip1.Items(0).Enabled = True
                Me.MenuStrip1.Items(1).Enabled = True
            End If
        End Sub

        Private Sub mnuSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSalir.Click
            CM.EditValor("logued", "nobody")
            Application.Exit()
        End Sub

        Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
            Compras.ShowDialog()
        End Sub

      
        Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
            Ventas.ShowDialog()

        End Sub

        Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            CM.EditValor("logued", "nobody")

        End Sub

        Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
            Proveedores.ShowDialog()
        End Sub

        Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
            Productos.ShowDialog()
        End Sub

        Private Sub PromocionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromocionesToolStripMenuItem.Click
            Vendedores.ShowDialog()
        End Sub

        Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
            Clientes.ShowDialog()
        End Sub

        Private Sub ReportesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportesToolStripMenuItem.Click
            Dim rpt As New Gerencial.Reportes()
            rpt.ShowDialog()
        End Sub

    End Class
End Namespace