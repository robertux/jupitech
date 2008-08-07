Namespace WinApp
    Public Class seleccionarcliente
        Public seleccion As Integer
        Public aceptado As Boolean

        Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
            Me.aceptado = False
            Me.Close()

        End Sub

        Private Sub seleccionarcliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.Gridcliente1.mostrarclientes()
        End Sub

        Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
            seleccion = CInt(Me.Gridcliente1.CurrentRow.Cells(0).Value)
            Me.aceptado = True
            Me.Close()

        End Sub

        Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
            Dim i As Integer
            Dim encontrado As Boolean
            If Me.Gridcliente1.CurrentRow.Index = Me.Gridcliente1.Rows.Count - 1 Then
                Me.Gridcliente1.CurrentCell = Me.Gridcliente1.Rows(0).Cells(0)
            End If
            For i = Me.Gridcliente1.CurrentRow.Index + 1 To Me.Gridcliente1.Rows.Count - 1
                If Me.Gridcliente1.Rows(i).Cells(1).Value.ToString.ToUpper.Contains(Me.txtbuscar.Text.ToUpper) Then
                    Me.Gridcliente1.CurrentCell = Me.Gridcliente1.Rows(i).Cells(1)
                    encontrado = True
                    Exit For
                Else
                    encontrado = False
                End If
                If i = Me.Gridcliente1.Rows.Count - 1 Then
                    i = 0
                End If
                If i = Me.Gridcliente1.CurrentRow.Index Then
                    encontrado = False
                    Exit For
                End If
            Next
            If encontrado = False Then
                MsgBox("No se encontro el nombre del cliente")
            End If
        End Sub
    End Class
End Namespace
