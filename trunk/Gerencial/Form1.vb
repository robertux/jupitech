Public Class Reportes
    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub PersonasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CrystalReportViewer1.Visible = True
        Dim informe1 As New Informe
        CrystalReportViewer1.ReportSource = informe1
    End Sub


    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        CrystalReportViewer1.Visible = False
    End Sub

    Private Sub ClientesRegidtradosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesRegidtradosToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim clientesReg As New ClientesRegistrados
        CrystalReportViewer1.ReportSource = clientesReg
    End Sub

    Private Sub TotalVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalVendedoresToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim vendedors As New RptVendedores
        CrystalReportViewer1.ReportSource = vendedors
    End Sub


    Private Sub VentasVendedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasVendedoresToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim vendedors As New RptTopVendedores
        CrystalReportViewer1.ReportSource = vendedors
    End Sub

    Private Sub ClientesEstrellasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesEstrellasToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim vendedors As New RptClienteEstrella
        CrystalReportViewer1.ReportSource = vendedors
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim vendedors As New RptCatalogo
        CrystalReportViewer1.ReportSource = vendedors
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim vendedors As New RptExistencias
        CrystalReportViewer1.ReportSource = vendedors
    End Sub

    Private Sub LocalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalesToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim pedidos As New RptPedidos
        CrystalReportViewer1.ReportSource = pedidos
    End Sub

    Private Sub PorProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProductoToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim ventasxprod As New RptVentasXProducto
        CrystalReportViewer1.ReportSource = ventasxprod
    End Sub

    Private Sub PorDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorDiaToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim dias As New RptComprasXFechaD
        CrystalReportViewer1.ReportSource = dias
    End Sub

    Private Sub PorMesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorMesToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim meses As New RptComprasXFechaM
        CrystalReportViewer1.ReportSource = meses
    End Sub

    Private Sub PorDiaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorDiaToolStripMenuItem1.Click
        CrystalReportViewer1.Visible = True
        Dim dias As New RptVentasXFechaD
        CrystalReportViewer1.ReportSource = dias
    End Sub

    Private Sub PorAñoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorAñoToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim anio As New RptComprasXFechaA
        CrystalReportViewer1.ReportSource = anio
    End Sub

    Private Sub PorMesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorMesToolStripMenuItem1.Click
        CrystalReportViewer1.Visible = True
        Dim mes As New RptVentasXFechaM
        CrystalReportViewer1.ReportSource = mes
    End Sub

    Private Sub PorAñoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorAñoToolStripMenuItem1.Click
        CrystalReportViewer1.Visible = True
        Dim anio As New RptVentasXFechaA
        CrystalReportViewer1.ReportSource = anio
    End Sub

    Private Sub PorProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProductoToolStripMenuItem1.Click
        CrystalReportViewer1.Visible = True
        Dim comprod As New RptComprasXProd
        CrystalReportViewer1.ReportSource = comprod
    End Sub

    Private Sub ADomicilioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADomicilioToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim tipo As New RptTiposVenta
        CrystalReportViewer1.ReportSource = tipo
    End Sub

    Private Sub TipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim tipo As New RptTiposCompra
        CrystalReportViewer1.ReportSource = tipo
    End Sub

    Private Sub TopVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopVentasToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim topventas As New RptTopVentas
        CrystalReportViewer1.ReportSource = topventas
    End Sub

    Private Sub TopProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopProductosToolStripMenuItem.Click
        CrystalReportViewer1.Visible = True
        Dim top As New RptTopProductos
        CrystalReportViewer1.ReportSource = top
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
