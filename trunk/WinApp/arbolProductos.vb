Imports CDS.PgSql
Imports Jupitech.Entidades
Imports Jupitech.Manejadores
Imports System.Collections.Generic
Namespace WinApp
    Public Class arbolProductos
        Inherits System.Windows.Forms.UserControl
        Public Event NodeClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs)
        Private Sub arbolProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Rellenar()
        End Sub
        Public Sub Rellenar()
            Dim ds As CustomPgSqlDataSource = Manejador.GetDS()
            Dim tipos As List(Of TipoProducto) = MnjTiposProductos.GetTiposProductos(ds.DS)
            Me.TreeView1.Nodes.Clear()
            For Each tipo As TipoProducto In tipos
                If (tipo.Superior = 0) Then
                    Dim nodo As New TreeNode(tipo.Codigo.ToString + "-" + tipo.Nombre)
                    nodo.ToolTipText = tipo.Descripcion
                    Me.TreeView1.Nodes.Add(nodo)
                End If
            Next
            Me.AddSubTipos(Me.TreeView1.Nodes(0), tipos)
        End Sub

        Public Sub AddSubTipos(ByVal nodoInicial As TreeNode, ByVal tipos As List(Of TipoProducto))
            For Each tipo As TipoProducto In tipos
                Dim items As String() = nodoInicial.Text.Split("-")
                If (tipo.Superior = CInt(items(0))) Then
                    Dim nuevoNodo As New TreeNode(tipo.Codigo.ToString + "-" + tipo.Nombre)
                    nuevoNodo.ToolTipText = tipo.Descripcion
                    nodoInicial.Nodes.Add(nuevoNodo)
                    Me.AddSubTipos(nuevoNodo, tipos)
                End If
            Next
        End Sub
        Public Sub InternalNodeClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
            RaiseEvent NodeClick(sender, e)
        End Sub
    End Class
End Namespace
