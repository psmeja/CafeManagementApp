Imports System.Data.SqlClient
Imports CafeManagementApp.My.Resources

Public Class SqlHelper

    Public Shared Function GetSqlConnection() As SqlConnection
        Return New SqlConnection(DataResources.ConnectionString)
    End Function

End Class
