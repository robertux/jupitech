Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Public Class griditemscompra
    Inherits DataGridView
    Private _total As Double
    Public Property total() As Double
        Get
            Return _total
        End Get
        Set(ByVal value As Double)
            _total = value
        End Set
    End Property

    Public Sub mostraritems(ByVal codcompra As Integer)
        Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
        formatear()
        llenar(codcompra, ds.DS)
    End Sub

    Public Sub formatear()
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.AllowUserToAddRows = False
        Me.AllowUserToDeleteRows = False
        Me.ReadOnly = True
        Me.MultiSelect = False
    End Sub

    Public Sub llenar(ByVal codcompra As Integer, ByVal ds As DataSet)
        Me.Columns.Clear()
        Me.Columns.Add("Producto", "Producto")
        Me.Columns.Add("Cantidad", "Cantidad")
        Me.Columns.Add("Precio Unitario", "Precio Unitario")
        Me.Columns.Add("Subtotal", "Subtotal")
        Me.Rows.Clear()
        Me.total = 0
        For Each fila As DataRow In ds.Tables("itemstransaccion").Rows
            If CInt(fila("transaccion")) = codcompra Then
                Dim prd As Producto = MnjProductos.GetProducto(CInt(fila("producto")), ds)
                Me.Rows.Add()
                Me.Rows(Me.Rows.Count - 1).Cells(0).Value = prd.Nombre + " " + prd.Descripcion
                Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("cantidad")
                Me.Rows(Me.Rows.Count - 1).Cells(2).Value = prd.precios(prd.precios.Count - 1).Monto
                Me.Rows(Me.Rows.Count - 1).Cells(3).Value = (CDbl(fila("cantidad")) * prd.precios(prd.precios.Count - 1).Monto)
                Me.total += (CDbl(fila("cantidad")) * prd.precios(prd.precios.Count - 1).Monto)
            End If
        Next
    End Sub
End Class
