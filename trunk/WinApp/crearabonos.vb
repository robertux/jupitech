Imports Jupitech.Manejadores
Imports Jupitech.Entidades
Imports CDS.PgSql
Imports System.Data
Namespace WinApp
    Public Class crearabonos
        Dim ds As CustomPgSqlDataSource
        Public fechas As List(Of Date)
        Public abns As New List(Of Abono)
        Public monto As Double

        Private Sub crearabonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ds = Manejador.GetDS
            Me.limpiartxt()
        End Sub

        Public Sub limpiartxt()
            Me.txtinteres.Text = ""
            Me.txtnumabonos.Text = ""
            Me.txtinteresmora.Text = ""
            Me.cmbperiodo.SelectedIndex = 0
            Me.txtnumabonos.Focus()
        End Sub

        Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
            Dim i As Integer
            If Me.txtnumabonos.Text <> "" And Me.txtinteresmora.Text <> "" And Me.txtinteres.Text <> "" Then
                MnjVentas.AddVenta(agregarventa.vnt, ds.DS)
                ds.ActualizarBD()
                ds.CargarDS()
                For Each itm As ItemTransaccion In agregarventa.items
                    itm.Transaccion = MnjVentas.GetLastCode(New Npgsql.NpgsqlConnection(ds.CadenaConexion))
                    MnjItemsTransaccion.AddItemTransaccion(itm, ds.DS)
                Next
                ds.ActualizarBD()
                calcularabonos()
                For i = 0 To abns.Count - 1
                    MnjAbonos.AddAbono(abns.Item(i), ds.DS)
                Next
                ds.ActualizarBD()
                Ventas.DataGridView1.llenar(ds.DS.Tables("ventas"), ds.DS)
                Ventas.DataGridView1.Refresh()
                agregarventa.Close()
                Me.Close()
            End If
        End Sub

        Public Sub calcularabonos()
            Me.monto = agregarventa.total / CDbl(Me.txtnumabonos.Text)
            cargarabonos()
        End Sub
        Public Function calcularfechas(ByVal d As Date) As Date
            If Me.cmbperiodo.Text = "Semanal" Then
                d = d.AddDays(7)
            End If
            If Me.cmbperiodo.Text = "Quincenal" Then
                d = d.AddDays(15)
            End If
            If Me.cmbperiodo.Text = "Mensual" Then
                d = d.AddMonths(1)
            End If
            If Me.cmbperiodo.Text = "Bimensual" Then
                d = d.AddMonths(2)
            End If
            If Me.cmbperiodo.Text = "Trimestral" Then
                d = d.AddMonths(3)
            End If
            Return d
        End Function

        Public Sub cargarabonos()
            Dim i As Integer
            Dim fecha As Date = Date.Now
            For i = 0 To CInt(Me.txtnumabonos.Text) - 1
                Dim nuevoabono As New Abono(0, (calcularfechas(fecha)), Nothing, (Me.monto + (Me.monto * (CDbl(Me.txtinteres.Text)) / 100)), CDbl(Me.txtinteres.Text), CDbl(Me.txtinteresmora.Text), MnjVentas.GetLastCode(New Npgsql.NpgsqlConnection(ds.CadenaConexion)))
                abns.Add(nuevoabono)
                fecha = (calcularfechas(fecha))
            Next
        End Sub

    End Class
End Namespace
