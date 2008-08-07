Imports CDS.PgSql
Imports System.Data
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Namespace WinApp
    Public Class Ventas
        Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.DataGridView1.mostrarventas(CInt(MainForm.CM("sucursal")))
            If Me.DataGridView1.RowCount <> 0 Then
                If Me.DataGridView1.CurrentRow Is Nothing Then
                    Me.Griditemsventa1.mostraritems(CInt(Me.DataGridView1.Rows(0).Cells(0).Value))
                Else
                    Me.Griditemsventa1.mostraritems(CInt(Me.DataGridView1.CurrentRow.Cells(0).Value))
                End If
                Me.lbltotal.Text = Me.Griditemsventa1.total.ToString
                If Me.DataGridView1.CurrentRow.Cells(4).Value.ToString.Trim = "Credito" Then
                    Me.btnabonos.Enabled = True
                Else
                    Me.btnabonos.Enabled = False
                End If

            else
                Me.btnabonos.Enabled = False
            End If
        End Sub

        Private Sub DataGridView1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
            If Me.DataGridView1.CurrentRow.Cells(4).Value Is Nothing Then
            Else
                If Me.DataGridView1.CurrentRow.Cells(4).Value.ToString.Trim = "Credito" Then
                    Me.btnabonos.Enabled = True
                Else
                    Me.btnabonos.Enabled = False
                End If
                Me.Griditemsventa1.mostraritems(CInt(Me.DataGridView1.CurrentRow.Cells(0).Value))
                Me.lbltotal.Text = Me.Griditemsventa1.total.ToString
            End If
        End Sub

        Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
            Dim i As Integer
            Dim encontrado As Boolean
            For i = 0 To Me.DataGridView1.Rows.Count - 1
                If Me.DataGridView1.Rows(i).Cells(0).Value.ToString = Me.txtbuscar.Text Then
                    Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(i).Cells(0)
                    Me.Griditemsventa1.mostraritems(CInt(Me.DataGridView1.CurrentRow.Cells(0).Value))
                    Me.lbltotal.Text = Me.Griditemsventa1.total.ToString
                    encontrado = True
                    Exit For
                Else
                    encontrado = False
                End If
            Next
            If Me.DataGridView1.CurrentRow.Cells(4).Value.ToString.Trim = "Credito" Then
                Me.btnabonos.Enabled = True
            Else
                Me.btnabonos.Enabled = False
            End If
            If encontrado = False Then
                MsgBox("No se encontro la venta")
            End If
        End Sub

        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
            agregarventa.ShowDialog()
        End Sub

        Private Sub btnabonos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabonos.Click
            abonos.ShowDialog()

        End Sub
    End Class
End Namespace
