Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjDocumentosPago
	    Public Shared Function GetDocumentoPago(ByVal codigo As Integer, ByVal ds As DataSet) As DocumentoPago
        For Each fila As DataRow In ds.Tables("documentospago").Rows
            If (fila("codigo") = codigo) Then
                    Return New DocumentoPago(fila("tipo"), fila("numero"), fila("formato"), fila("codigo"), (fila("cliente")))
            End If
        Next
        Return Nothing
    End Function
    
        Public Shared Function GetDocumentosFrom(ByVal codCliente As Integer, ByVal ds As DataSet) As List(Of DocumentoPago)
            Dim docs As New List(Of DocumentoPago)
            For Each fila As DataRow In ds.Tables("documentospago").Rows
                If (fila("cliente") = codCliente) Then
                    docs.Add(New DocumentoPago(fila("tipo"), fila("numero"), fila("formato"), fila("codigo"), fila("cliente")))
                End If
            Next
            Return docs
        End Function

    Public Shared Sub AddDocumentoPago(ByVal d As DocumentoPago, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("documentospago").NewRow()
	fila("tipo") = d.Tipo
	fila("numero") = d.Numero
	fila("formato") = d.Formato
	fila("codigo") = d.Codigo
            fila("cliente") = d.Cliente
        Ds.Tables("documentospago").Rows.Add(fila)
    End Sub

    Public Shared Sub EditDocumentoPago(ByVal d As DocumentoPago, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("documentospago").Rows
            If (fila("codigo") = d.Codigo) Then
		fila("numero") = d.Numero
		fila("formato") = d.Formato
                    fila("cliente") = d.Cliente
            End If
        Next
    End Sub

    Public Shared Sub DelDocumentoPago(ByVal d as DocumentoPago, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("documentospago").Rows
            If (fila("codigo") = d.Codigo) Then
                Ds.Tables("documentospago").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from documentospago where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", d.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
