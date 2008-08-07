Namespace WinApp
    Public Class abonos

        Private Sub abonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Gridabonos1.mostrarabonos(CInt(Ventas.DataGridView1.CurrentRow.Cells(0).Value.ToString.Trim))
        End Sub
    End Class
End Namespace
