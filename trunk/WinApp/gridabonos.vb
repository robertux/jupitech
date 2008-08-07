Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Public Class gridabonos
    Inherits DataGridView
    Public Sub mostrarabonos(ByVal codventa As Integer)
        Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
        Dim tempabn As DataView = ds.DS.Tables("abonos").DefaultView
        tempabn.RowFilter = "venta=" + codventa.ToString
        Dim tbabn As DataTable = tempabn.ToTable
        tbabn = formatear(tbabn)
        llenar(tbabn, ds.DS)
    End Sub

    Public Function formatear(ByVal tb As DataTable) As DataTable
        tb.Columns.Remove("venta")
        tb.Columns.Remove("codigo")
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.ReadOnly = True
        Me.MultiSelect = False
        Return tb
    End Function

    Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet)
        Me.Columns.Clear()
        Me.Columns.Add("Fecha Limite de Pago", "Fecha Limite de Pago")
        Me.Columns.Add("Fecha Pago", "Fecha Pago")
        Me.Columns.Add("Monto", "Monto")
        Me.Columns.Add("Interes", "Interes %")
        Me.Columns.Add("Tnteres Mora", "Interes Mora %")
        Me.Rows.Clear()
        For Each fila As DataRow In tb.Rows
            Me.Rows.Add()
            Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("fecha_limite_pago")
            Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("fecha_pago")
            Me.Rows(Me.Rows.Count - 1).Cells(2).Value = fila("monto")
            Me.Rows(Me.Rows.Count - 1).Cells(3).Value = fila("prctn_interes_normal")
            Me.Rows(Me.Rows.Count - 1).Cells(4).Value = fila("prctn_interes_mora")
        Next
    End Sub
End Class
