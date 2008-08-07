Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class gridClientes
        Inherits DataGridView

        Public Sub mostrarclientes()
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tbclientes As DataTable = ds.DS.Tables("clientes")
            tbclientes = formatear(tbclientes)
            llenar(tbclientes, ds.DS)
        End Sub
        Public Function formatear(ByVal tb As DataTable) As DataTable
            Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.AllowUserToAddRows = False
            Me.AllowUserToDeleteRows = False
            Me.ReadOnly = True
            Me.MultiSelect = False
            Return tb
        End Function

        Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet)
            Me.Columns.Clear()
            Me.Columns.Add("codigo", "codigo")
            Me.Columns.Add("Apellidos", "Apellidos")
            Me.Columns.Add("Nombres", "Nombres")
            Me.Columns.Add("Direccion", "Direccion")
            Me.Columns.Add("Estado", "Estado")
            Me.Rows.Clear()
            For Each fila As DataRow In tb.Rows
                Me.Rows.Add()
                Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("codigo")
                Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("Apellidos")
                Me.Rows(Me.Rows.Count - 1).Cells(2).Value = fila("Nombres")
                Me.Rows(Me.Rows.Count - 1).Cells(3).Value = fila("Direccion")
                Me.Rows(Me.Rows.Count - 1).Cells(4).Value = fila("Estado")

            Next

        End Sub


    End Class
End Namespace
