Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class GridDocumentos
        Inherits DataGridView
        Public Sub mostrarDocumentos(ByVal codProveedor As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tbdocumentos As DataTable = ds.DS.Tables("documentos")
            tbdocumentos = formatear(tbdocumentos)
            llenar(codProveedor, ds.DS)
        End Sub
        Public Function formatear(ByVal tb As DataTable) As DataTable
            Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.AllowUserToAddRows = False
            Me.AllowUserToDeleteRows = False
            Me.ReadOnly = True
            Me.MultiSelect = False
            Return tb
        End Function
        Public Sub llenar(ByVal codProveedor As Integer, ByVal ds As DataSet)
            Dim vista As DataView = ds.Tables("documentos").DefaultView
            vista.RowFilter = "persona=" + codProveedor.ToString()
            Me.DataSource = vista
            Me.Columns("persona").Visible = False
            Me.Columns("formato").Visible = False
            Me.Columns("codigo").Visible = False
        End Sub
    End Class
End Namespace
