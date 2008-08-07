Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores

Public Class gridcompras
    Inherits DataGridView
    Public Sub mostrarcompras(ByVal codsucursal As Integer)
        Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
        Dim tempcmp As DataView = ds.DS.Tables("compras").DefaultView
        tempcmp.RowFilter = "sucursal=" + codsucursal.ToString
        Dim tbcompras As DataTable = tempcmp.ToTable
        tbcompras = formatear(tbcompras)
        llenar(tbcompras, ds.DS)
    End Sub

    Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet)
        Me.Columns.Clear()
        Me.Columns.Add("Codigo", "Codigo")
        Me.Columns.Add("Fecha", "Fecha")
        Me.Columns.Add("proveedor", "Proveedor")
        Me.Columns.Add("Tipo de Pago", "Tipo de Pago")
        Me.Rows.Clear()
        For Each fila As DataRow In tb.Rows
            Me.Rows.Add()
            Dim pv As Proveedor = MnjProveedores.GetProveedor(CInt(fila("proveedor")), ds)
            Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("codigo")
            Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("fecha")
            Me.Rows(Me.Rows.Count - 1).Cells(2).Value = pv.Apellidos + ", " + pv.Nombres
            Me.Rows(Me.Rows.Count - 1).Cells(3).Value = fila("tipo_pago")
        Next
    End Sub

    Public Function formatear(ByVal tb As DataTable) As DataTable
        tb.Columns.Remove("sucursal")
        tb.Columns.Remove("tipo")
        tb.Columns.Remove("forma_pago")
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.ReadOnly = True
        Me.MultiSelect = False
        Return tb
    End Function
End Class
