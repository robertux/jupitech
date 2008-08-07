Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class gridcostos
        Inherits DataGridView
        Public Sub mostrarcostos(ByVal producto As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tbcostos As DataTable = ds.DS.Tables("costosproductos")
            tbcostos = formatear(tbcostos)
            llenar(tbcostos, ds.DS, producto)
        End Sub
        Public Function formatear(ByVal tb As DataTable) As DataTable
            Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.AllowUserToAddRows = False
            Me.AllowUserToDeleteRows = False
            Me.ReadOnly = True
            Me.MultiSelect = False
            Return tb
        End Function

        Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet, ByVal producto As Integer)
            Me.Columns.Clear()
            Me.Columns.Add("Fecha", "Fecha")
            Me.Columns.Add("Monto", "Monto")
            Me.Rows.Clear()
            For Each fila As DataRow In tb.Rows
                If CInt(fila("producto")) = producto Then
                    Me.Rows.Add()
                    Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("Fecha")
                    Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("Monto")
                End If
                    Next

        End Sub
    End Class
End Namespace
