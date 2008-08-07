Imports Jupitech.Entidades
Imports Npgsql

namespace Manejadores
Public Class MnjDocumentos
	    Public Shared Function GetDocumento(ByVal codigo As Integer, ByVal ds As DataSet) As Documento
        For Each fila As DataRow In ds.Tables("documentos").Rows
                If (fila("codigo") = codigo) Then
                    Dim formato As String = ""
                    If Not (TypeOf (fila("formato")) Is System.DBNull) Then
                        formato = fila("formato")
                    End If
                    Return New Documento(fila("tipo"), fila("numero"), formato, fila("codigo"), fila("persona"))
                End If
            Next
        Return Nothing
    End Function
    
    Public shared Function GetDocumentosFrom(ByVal codPersona As Integer, ByVal ds As DataSet) As List(Of Documento)
    	Dim documentos As New List(Of Documento)
    	For Each fila As DataRow In ds.Tables("documentos").Rows
                If (fila("persona") = codPersona) Then
                    Dim formato As String = ""
                    If Not (TypeOf (fila("formato")) Is System.DBNull) Then
                        formato = fila("formato")
                    End If
                    documentos.Add(New Documento(fila("tipo"), fila("numero"), formato, fila("codigo"), (fila("persona"))))
                End If
    	Next
    	return documentos
    End Function

    Public Shared Sub AddDocumento(ByVal d As Documento, ByVal Ds As DataSet)
        Dim fila As DataRow = Ds.Tables("documentos").NewRow()
	fila("tipo") = d.Tipo
	fila("numero") = d.Numero
	fila("formato") = d.Formato
	fila("codigo") = d.Codigo
            fila("persona") = d.Persona
        Ds.Tables("documentos").Rows.Add(fila)
    End Sub

    Public Shared Sub EditDocumento(ByVal d As Documento, ByVal Ds As DataSet)
        For Each fila As DataRow In Ds.Tables("documentos").Rows
            If (fila("codigo") = d.Codigo) Then
		fila("tipo") = d.Tipo
		fila("numero") = d.Numero
		fila("formato") = d.Formato
                    fila("persona") = d.Persona
            End If
        Next
    End Sub

    Public Shared Sub DelDocumento(ByVal d as Documento, ByVal Ds As DataSet, ByVal cn As NpgsqlConnection)
        For Each fila As DataRow In Ds.Tables("documentos").Rows
            If (fila("codigo") = d.Codigo) Then
                Ds.Tables("documentos").Rows.Remove(fila)
                exit for
            End If
        Next
        Dim cmd As New NpgsqlCommand("Delete from documentos where codigo = :codigo", cn)
        cmd.Parameters.Add(New NpgsqlParameter(":codigo", d.Codigo))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
end namespace
