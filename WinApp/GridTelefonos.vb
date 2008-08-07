
Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class GridTelefonos
        Inherits DataGridView
        Public Sub mostrarTelefonos(ByVal codProveedor As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tbtelef As DataTable = ds.DS.Tables("telefonos")
            tbtelef = formatear(tbtelef)
            llenar(tbtelef, ds.DS, codProveedor)
        End Sub
        Public Function formatear(ByVal tb As DataTable) As DataTable
            Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.AllowUserToAddRows = False
            Me.AllowUserToDeleteRows = False
            Me.ReadOnly = True
            Me.MultiSelect = False
            Return tb
        End Function
        Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet, ByVal codProveedor As Integer)
            Dim vista As DataView = ds.Tables("telefonos").DefaultView
            vista.RowFilter = "persona=" + codProveedor.ToString()
            Me.DataSource = vista
            Me.Columns("persona").Visible = False
            Me.Columns("codigo").Visible = False
        End Sub

    End Class
End Namespace