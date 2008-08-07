'
' Created by SharpDevelop.
' User: _
' Date: 01/01/2001
' Time: 13:17
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Namespace WinApp
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

        ''' <summary>
        ''' Designer variable used to keep track of non-visual components.
        ''' </summary>
        Private components As System.ComponentModel.IContainer

        ''' <summary>
        ''' Disposes resources used by the form.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        ''' <summary>
        ''' This method is required for Windows Forms designer support.
        ''' Do not change the method contents inside the source code editor. The Forms designer might
        ''' not be able to load this method if it was changed manually.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
            Me.CatálogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.PromocionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.mnuCerrarSesion = New System.Windows.Forms.ToolStripMenuItem
            Me.mnuIniSesion = New System.Windows.Forms.ToolStripMenuItem
            Me.AplicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.mnuAcercaDe = New System.Windows.Forms.ToolStripMenuItem
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem
            Me.lblUsuario = New System.Windows.Forms.Label
            Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatálogosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.ArchivoToolStripMenuItem, Me.AplicacionToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "MenuStrip1"
            '
            'CatálogosToolStripMenuItem
            '
            Me.CatálogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.PromocionesToolStripMenuItem})
            Me.CatálogosToolStripMenuItem.Name = "CatálogosToolStripMenuItem"
            Me.CatálogosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
            Me.CatálogosToolStripMenuItem.Text = "Catálogos"
            '
            'ComprasToolStripMenuItem
            '
            Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
            Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.ComprasToolStripMenuItem.Text = "Compras"
            '
            'VentasToolStripMenuItem
            '
            Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
            Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.VentasToolStripMenuItem.Text = "Ventas"
            '
            'ClientesToolStripMenuItem
            '
            Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
            Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.ClientesToolStripMenuItem.Text = "Clientes"
            '
            'ProveedoresToolStripMenuItem
            '
            Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
            Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
            '
            'ProductosToolStripMenuItem
            '
            Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
            Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.ProductosToolStripMenuItem.Text = "Productos"
            '
            'PromocionesToolStripMenuItem
            '
            Me.PromocionesToolStripMenuItem.Name = "PromocionesToolStripMenuItem"
            Me.PromocionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.PromocionesToolStripMenuItem.Text = "Vendedores"
            '
            'ArchivoToolStripMenuItem
            '
            Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCerrarSesion, Me.mnuIniSesion})
            Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
            Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
            Me.ArchivoToolStripMenuItem.Text = "Sesion"
            '
            'mnuCerrarSesion
            '
            Me.mnuCerrarSesion.Name = "mnuCerrarSesion"
            Me.mnuCerrarSesion.Size = New System.Drawing.Size(150, 22)
            Me.mnuCerrarSesion.Text = "Cerrar Sesion"
            '
            'mnuIniSesion
            '
            Me.mnuIniSesion.Name = "mnuIniSesion"
            Me.mnuIniSesion.Size = New System.Drawing.Size(150, 22)
            Me.mnuIniSesion.Text = "Iniciar Sesion"
            '
            'AplicacionToolStripMenuItem
            '
            Me.AplicacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAcercaDe, Me.ToolStripSeparator1, Me.mnuSalir})
            Me.AplicacionToolStripMenuItem.Name = "AplicacionToolStripMenuItem"
            Me.AplicacionToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
            Me.AplicacionToolStripMenuItem.Text = "Aplicacion"
            '
            'mnuAcercaDe
            '
            Me.mnuAcercaDe.Name = "mnuAcercaDe"
            Me.mnuAcercaDe.Size = New System.Drawing.Size(145, 22)
            Me.mnuAcercaDe.Text = "Acerca de..."
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(142, 6)
            '
            'mnuSalir
            '
            Me.mnuSalir.Name = "mnuSalir"
            Me.mnuSalir.Size = New System.Drawing.Size(145, 22)
            Me.mnuSalir.Text = "Salir"
            '
            'lblUsuario
            '
            Me.lblUsuario.AutoSize = True
            Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblUsuario.Location = New System.Drawing.Point(12, 36)
            Me.lblUsuario.Name = "lblUsuario"
            Me.lblUsuario.Size = New System.Drawing.Size(100, 16)
            Me.lblUsuario.TabIndex = 1
            Me.lblUsuario.Text = "Desconocido"
            '
            'ReportesToolStripMenuItem
            '
            Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
            Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
            Me.ReportesToolStripMenuItem.Text = "Reportes"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(792, 573)
            Me.Controls.Add(Me.lblUsuario)
            Me.Controls.Add(Me.MenuStrip1)
            Me.MainMenuStrip = Me.MenuStrip1
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "MainForm"
            Me.Text = "JupiTEC"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuCerrarSesion As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CatálogosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PromocionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuIniSesion As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents lblUsuario As System.Windows.Forms.Label
        Friend WithEvents AplicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuAcercaDe As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuSalir As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace