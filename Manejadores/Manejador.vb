Imports System.Data
Imports CDS.PgSql
Imports Jupitech.Entidades
Imports Npgsql

Namespace Manejadores
    Public Class Manejador
    	
        Public Shared Function GetDS() As CustomPgSqlDataSource
            Dim ds As New CustomPgSqlDataSource("localhost", "postgres", "passwd", "jupitec")
            ds.CargarDS()
            Return ds
        End Function
        
    End Class
End Namespace
