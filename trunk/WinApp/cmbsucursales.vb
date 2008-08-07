Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Public Class cmbsucursales
    Public ReadOnly Property selected() As Integer
        Get
            Dim cadenas As String() = Me.ComboBox1.Text.ToString.Split(" ")        
            Return CInt(cadenas(0))
        End Get
    End Property

    Public Sub mostrar()
        Dim ds As CustomPgSqlDataSource = Manejador.GetDS
        For Each fila As DataRow In ds.DS.Tables("sucursales").Rows
            Me.ComboBox1.Items.Add(fila("codigo").ToString + " " + fila("nombre").ToString)
        Next
        If Me.ComboBox1.Items.Count > 0 Then
            Me.ComboBox1.SelectedIndex = 0
        End If
    End Sub
End Class
