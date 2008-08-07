Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports CDS.PgSql
Imports System.Data

Namespace WinApp
    Public Class Compras
     
        Private Sub Compras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Gridcompras1.mostrarcompras(CInt(MainForm.CM("sucursal")))
            If Me.Gridcompras1.RowCount <> 0 Then
                If Me.Gridcompras1.CurrentRow Is Nothing Then
                    Me.Griditemscompra1.mostraritems(CInt(Me.Gridcompras1.Rows(0).Cells(0).Value))
                Else
                    Me.Griditemscompra1.mostraritems(CInt(Me.Gridcompras1.CurrentRow.Cells(0).Value))
                End If
                Me.lbltotal.Text = Me.Griditemscompra1.total.ToString
                If Me.Gridcompras1.CurrentRow.Cells(3).Value.ToString.Trim = "Credito" Then
                    Me.btncargos.Enabled = True
                Else
                    Me.btncargos.Enabled = False
                End If
            Else
                Me.btncargos.Enabled = False
            End If
        End Sub


        Private Sub Gridcompras1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gridcompras1.SelectionChanged
            If Me.Gridcompras1.CurrentRow.Cells(3).Value Is Nothing Then
            Else
                If Me.Gridcompras1.CurrentRow.Cells(3).Value.ToString.Trim = "Credito" Then
                    Me.btncargos.Enabled = True
                Else
                    Me.btncargos.Enabled = False
                End If
                Me.Griditemscompra1.mostraritems(CInt(Me.Gridcompras1.CurrentRow.Cells(0).Value))
                Me.lbltotal.Text = Me.Griditemscompra1.total.ToString
            End If
        End Sub


        Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
            agregarcompra.ShowDialog()
        End Sub

        Private Sub btncargos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargos.Click
            cargos.ShowDialog()
        End Sub
    End Class
End Namespace