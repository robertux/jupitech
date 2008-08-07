Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class gridcliente
        Inherits DataGridView
        Public Sub mostrarclientes()
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
            Dim cl As DataTable = ds.DS.Tables("clientes")
            formatear()
            llenar(cl, ds.DS)
        End Sub

        Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet)
            Me.Columns.Clear()
            Me.Columns.Add("Codigo", "Codigo")
            Me.Columns.Add("Nombre", "Nombre")
            Me.Columns.Add("Apelldios", "Apellidos")
            Me.Columns.Add("Estado", "Estado")
            Me.Rows.Clear()
            For Each fila As DataRow In tb.Rows
                Me.Rows.Add()
                Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("codigo")
                Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("nombres")
                Me.Rows(Me.Rows.Count - 1).Cells(2).Value = fila("apellidos")
                Me.Rows(Me.Rows.Count - 1).Cells(3).Value = fila("estado")
            Next
        End Sub
        Public Sub formatear()
            Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.AllowUserToAddRows = False
            Me.AllowUserToDeleteRows = False
            Me.ReadOnly = True
            Me.MultiSelect = False
        End Sub
    End Class
End Namespace
