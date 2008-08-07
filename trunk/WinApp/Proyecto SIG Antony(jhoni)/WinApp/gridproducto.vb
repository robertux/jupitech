Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class gridproducto
        Inherits DataGridView
        Public Sub mostrarproductos(ByVal codtipoproducto As Integer)
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS
            Dim tbproductos As DataTable = ds.DS.Tables("productos")
            tbproductos = formatear(tbproductos)
            llenar(tbproductos, ds.DS, codtipoproducto)
        End Sub
        Public Function formatear(ByVal tb As DataTable) As DataTable
            tb.Columns.Remove("promocion")
            tb.Columns.Remove("imagen")
            Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            Me.AllowUserToAddRows = False
            Me.AllowUserToDeleteRows = False
            Me.ReadOnly = True
            Me.MultiSelect = False
            Return tb
        End Function

        Public Sub llenar(ByVal tb As DataTable, ByVal ds As DataSet, ByVal codtipoproducto As Integer)
            Me.Columns.Clear()
            Me.Columns.Add("Codigo", "Codigo")
            Me.Columns.Add("Nombre", "Nombre")
            Me.Columns.Add("Descripcion", "Descripcion")
            Me.Columns.Add("Marca", "Marca")
            Me.Columns.Add("Modelo", "Modelo")
            Me.Columns.Add("Proveedores", "Proveedores")
            Me.Columns.Add("Existencia", "Existencia")
            Me.Columns.Add("ExistenciaMinima", "ExistenciaMinima")
            Me.Rows.Clear()
            For Each fila As DataRow In tb.Rows
                If CInt(fila("tipo")) = codtipoproducto Then
                    Me.Rows.Add()
                    Me.Rows(Me.Rows.Count - 1).Cells(0).Value = fila("Codigo")
                    Me.Rows(Me.Rows.Count - 1).Cells(1).Value = fila("Nombre")
                    Me.Rows(Me.Rows.Count - 1).Cells(2).Value = fila("Descripcion")
                    Me.Rows(Me.Rows.Count - 1).Cells(3).Value = fila("Marca")
                    Me.Rows(Me.Rows.Count - 1).Cells(4).Value = fila("Modelo")
                    For Each fila3 As DataRow In ds.Tables("proveedoresproductos").Rows
                        If CInt(fila3("producto")) = CInt(fila("codigo")) Then
                            Dim prv As Proveedor = MnjProveedores.GetProveedor(CInt(fila3("proveedor")), ds)
                            Me.Rows(Me.Rows.Count - 1).Cells(5).Value = CStr(Me.Rows(Me.Rows.Count - 1).Cells(5).Value) + prv.Apellidos + " " + prv.Nombres + ", "

                        End If
                    Next
                    For Each fila2 As DataRow In ds.Tables("prodsucursal").Rows
                        If CInt(fila2("producto")) = CInt(fila("codigo")) And CInt(fila2("sucursal")) = CInt(MainForm.CM("sucursal")) Then
                            Me.Rows(Me.Rows.Count - 1).Cells(6).Value = fila2("existencia_actual")
                            Me.Rows(Me.Rows.Count - 1).Cells(7).Value = fila2("existencia_minima")
                        End If
                    Next
                End If
            Next
        End Sub
    End Class
End Namespace
