Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Public Class gridventa
    Inherits DataGridView

    Public Sub mostrarventas(ByVal codsucursal As Integer)
        Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
        Dim tempvnt As DataView = ds.DS.Tables("ventas").DefaultView
        tempvnt.RowFilter = "sucursal=" + codsucursal.ToString
        Dim tbventas As DataTable = tempvnt.ToTable
        tbventas = formatear(tbventas)
        llenar(tbventas, ds.DS)
    End Sub

    Public Function formatear(ByVal tb As DataTable) As DataTable
        tb.Columns.Remove("sucursal")
        tb.Columns.Remove("tipo")
        tb.Columns.Remove("forma_pago")
        tb.Columns.Remove("pedido")
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.ReadOnly = True
        Me.MultiSelect = False
        Return tb
    End Function

    Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet)
        Me.Columns.Clear()
        Me.Columns.Add("Codigo", "Codigo")
        Me.Columns.Add("Fecha", "Fecha")
        Me.Columns.Add("Cliente", "Cliente")
        Me.Columns.Add("Vendedor", "Vendedor")
        Me.Columns.Add("Tipo de Pago", "Tipo de Pago")
        Me.Rows.Clear()
        For Each fila As DataRow In tb.Rows
            Me.Rows.Add()
            Dim cl As Cliente = MnjClientes.GetCliente(CInt(fila("cliente")), ds)
            Dim vnd As Vendedor = MnjVendedores.GetVendedor(CInt(fila("vendedor")), ds)
            Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("codigo")
            Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("fecha")
            Me.Rows(Me.Rows.Count - 1).Cells(2).Value = cl.Apellidos + ", " + cl.Nombres
            Me.Rows(Me.Rows.Count - 1).Cells(3).Value = vnd.Apellidos + ", " + vnd.Nombres
            Me.Rows(Me.Rows.Count - 1).Cells(4).Value = fila("tipo_pago")
        Next
    End Sub
End Class
