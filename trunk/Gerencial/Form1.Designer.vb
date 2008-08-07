<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Reportes
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CrystalReport11 = New Gerencial.Informe
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.LocalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesRegidtradosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesEstrellasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TotalVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorDiaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PorMesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PorAñoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PorProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ADomicilioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevolucionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AnulacionesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasPorPagarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TopVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorFechaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.PorDiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorAñoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PorProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AnulacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CatalogoPrroductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TopProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(792, 542)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LocalesToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.CatalogoPrroductosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LocalesToolStripMenuItem
        '
        Me.LocalesToolStripMenuItem.Name = "LocalesToolStripMenuItem"
        Me.LocalesToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.LocalesToolStripMenuItem.Text = "Pedidos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesRegidtradosToolStripMenuItem, Me.ClientesEstrellasToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ClientesRegidtradosToolStripMenuItem
        '
        Me.ClientesRegidtradosToolStripMenuItem.Name = "ClientesRegidtradosToolStripMenuItem"
        Me.ClientesRegidtradosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClientesRegidtradosToolStripMenuItem.Text = "Clientes Registrados"
        '
        'ClientesEstrellasToolStripMenuItem
        '
        Me.ClientesEstrellasToolStripMenuItem.Name = "ClientesEstrellasToolStripMenuItem"
        Me.ClientesEstrellasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClientesEstrellasToolStripMenuItem.Text = "Clientes Estrellas"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TotalVendedoresToolStripMenuItem, Me.VentasVendedoresToolStripMenuItem})
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'TotalVendedoresToolStripMenuItem
        '
        Me.TotalVendedoresToolStripMenuItem.Name = "TotalVendedoresToolStripMenuItem"
        Me.TotalVendedoresToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TotalVendedoresToolStripMenuItem.Text = "Total Vendedores"
        '
        'VentasVendedoresToolStripMenuItem
        '
        Me.VentasVendedoresToolStripMenuItem.Name = "VentasVendedoresToolStripMenuItem"
        Me.VentasVendedoresToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VentasVendedoresToolStripMenuItem.Text = "Top Vendedores"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorFechaToolStripMenuItem, Me.PorProductoToolStripMenuItem, Me.ADomicilioToolStripMenuItem, Me.DevolucionesToolStripMenuItem1, Me.AnulacionesToolStripMenuItem1, Me.CuentasPorPagarToolStripMenuItem1, Me.TopVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'PorFechaToolStripMenuItem
        '
        Me.PorFechaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorDiaToolStripMenuItem1, Me.PorMesToolStripMenuItem1, Me.PorAñoToolStripMenuItem1})
        Me.PorFechaToolStripMenuItem.Name = "PorFechaToolStripMenuItem"
        Me.PorFechaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PorFechaToolStripMenuItem.Text = "Por Fecha"
        '
        'PorDiaToolStripMenuItem1
        '
        Me.PorDiaToolStripMenuItem1.Name = "PorDiaToolStripMenuItem1"
        Me.PorDiaToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.PorDiaToolStripMenuItem1.Text = "Por Dia "
        '
        'PorMesToolStripMenuItem1
        '
        Me.PorMesToolStripMenuItem1.Name = "PorMesToolStripMenuItem1"
        Me.PorMesToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.PorMesToolStripMenuItem1.Text = "Por Mes"
        '
        'PorAñoToolStripMenuItem1
        '
        Me.PorAñoToolStripMenuItem1.Name = "PorAñoToolStripMenuItem1"
        Me.PorAñoToolStripMenuItem1.Size = New System.Drawing.Size(123, 22)
        Me.PorAñoToolStripMenuItem1.Text = "Por Año"
        '
        'PorProductoToolStripMenuItem
        '
        Me.PorProductoToolStripMenuItem.Name = "PorProductoToolStripMenuItem"
        Me.PorProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PorProductoToolStripMenuItem.Text = "Por Producto"
        '
        'ADomicilioToolStripMenuItem
        '
        Me.ADomicilioToolStripMenuItem.Name = "ADomicilioToolStripMenuItem"
        Me.ADomicilioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ADomicilioToolStripMenuItem.Text = "Tipo"
        '
        'DevolucionesToolStripMenuItem1
        '
        Me.DevolucionesToolStripMenuItem1.Name = "DevolucionesToolStripMenuItem1"
        Me.DevolucionesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DevolucionesToolStripMenuItem1.Text = "Devoluciones"
        '
        'AnulacionesToolStripMenuItem1
        '
        Me.AnulacionesToolStripMenuItem1.Name = "AnulacionesToolStripMenuItem1"
        Me.AnulacionesToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AnulacionesToolStripMenuItem1.Text = "Anulaciones"
        '
        'CuentasPorPagarToolStripMenuItem1
        '
        Me.CuentasPorPagarToolStripMenuItem1.Name = "CuentasPorPagarToolStripMenuItem1"
        Me.CuentasPorPagarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CuentasPorPagarToolStripMenuItem1.Text = "Cuentas por Cobrar"
        '
        'TopVentasToolStripMenuItem
        '
        Me.TopVentasToolStripMenuItem.Name = "TopVentasToolStripMenuItem"
        Me.TopVentasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TopVentasToolStripMenuItem.Text = "Top Ventas"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorFechaToolStripMenuItem1, Me.PorProductoToolStripMenuItem1, Me.TipoToolStripMenuItem, Me.DevolucionesToolStripMenuItem, Me.AnulacionesToolStripMenuItem, Me.CuentasPorPagarToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'PorFechaToolStripMenuItem1
        '
        Me.PorFechaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PorDiaToolStripMenuItem, Me.PorMesToolStripMenuItem, Me.PorAñoToolStripMenuItem})
        Me.PorFechaToolStripMenuItem1.Name = "PorFechaToolStripMenuItem1"
        Me.PorFechaToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.PorFechaToolStripMenuItem1.Text = "Por Fecha"
        '
        'PorDiaToolStripMenuItem
        '
        Me.PorDiaToolStripMenuItem.Name = "PorDiaToolStripMenuItem"
        Me.PorDiaToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PorDiaToolStripMenuItem.Text = "Por Dia"
        '
        'PorMesToolStripMenuItem
        '
        Me.PorMesToolStripMenuItem.Name = "PorMesToolStripMenuItem"
        Me.PorMesToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PorMesToolStripMenuItem.Text = "Por Mes"
        '
        'PorAñoToolStripMenuItem
        '
        Me.PorAñoToolStripMenuItem.Name = "PorAñoToolStripMenuItem"
        Me.PorAñoToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PorAñoToolStripMenuItem.Text = "Por año"
        '
        'PorProductoToolStripMenuItem1
        '
        Me.PorProductoToolStripMenuItem1.Name = "PorProductoToolStripMenuItem1"
        Me.PorProductoToolStripMenuItem1.Size = New System.Drawing.Size(175, 22)
        Me.PorProductoToolStripMenuItem1.Text = "Por Producto"
        '
        'TipoToolStripMenuItem
        '
        Me.TipoToolStripMenuItem.Name = "TipoToolStripMenuItem"
        Me.TipoToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.TipoToolStripMenuItem.Text = "Tipo"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'AnulacionesToolStripMenuItem
        '
        Me.AnulacionesToolStripMenuItem.Name = "AnulacionesToolStripMenuItem"
        Me.AnulacionesToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AnulacionesToolStripMenuItem.Text = "Anulaciones"
        '
        'CuentasPorPagarToolStripMenuItem
        '
        Me.CuentasPorPagarToolStripMenuItem.Name = "CuentasPorPagarToolStripMenuItem"
        Me.CuentasPorPagarToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.CuentasPorPagarToolStripMenuItem.Text = "Cuentas por Pagar"
        '
        'CatalogoPrroductosToolStripMenuItem
        '
        Me.CatalogoPrroductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogoToolStripMenuItem, Me.ExistenciasToolStripMenuItem, Me.TopProductosToolStripMenuItem})
        Me.CatalogoPrroductosToolStripMenuItem.Name = "CatalogoPrroductosToolStripMenuItem"
        Me.CatalogoPrroductosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CatalogoPrroductosToolStripMenuItem.Text = "Productos"
        '
        'CatalogoToolStripMenuItem
        '
        Me.CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        Me.CatalogoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CatalogoToolStripMenuItem.Text = "Catalogo"
        '
        'ExistenciasToolStripMenuItem
        '
        Me.ExistenciasToolStripMenuItem.Name = "ExistenciasToolStripMenuItem"
        Me.ExistenciasToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExistenciasToolStripMenuItem.Text = "Existencias"
        '
        'TopProductosToolStripMenuItem
        '
        Me.TopProductosToolStripMenuItem.Name = "TopProductosToolStripMenuItem"
        Me.TopProductosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.TopProductosToolStripMenuItem.Text = "Top Productos"
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As Informe
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents LocalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesRegidtradosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesEstrellasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalVendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasVendedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ADomicilioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnulacionesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasPorPagarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorFechaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorProductoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnulacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasPorPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoPrroductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorDiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorMesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorAñoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorDiaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorMesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PorAñoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
