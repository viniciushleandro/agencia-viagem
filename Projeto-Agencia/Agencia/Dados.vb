Imports System.Data.SqlClient

Namespace AgenciaDeViagem
    Public Class Dados

        Public Shared Function GetConnection() As SqlConnection
            Try
                Dim sql As String = $"Data Source=; Integrated Security=False; Initial Catalog=; User ID=; Password="
                Dim conn As New SqlConnection(sql)
                conn.Open()
                Return conn
            Catch ex As Exception
                Throw ex
            End Try

            Return Nothing
        End Function

        Public Shared Sub ExecutaComando(command As String)

            Using sqlComm = New SqlCommand
                sqlComm.Connection = GetConnection()
                sqlComm.CommandText = command
                sqlComm.ExecuteNonQuery()
            End Using

        End Sub

        Public Shared Function GetDataReader(command As String) As SqlDataReader
            Using sqlComm = New SqlCommand
                sqlComm.Connection = GetConnection()
                sqlComm.CommandText = command

                Dim dataReader = sqlComm.ExecuteReader()
                Return dataReader
            End Using

        End Function

        Public Shared Function GetDataTable(command As String) As DataTable
            Using sqlDataAdapter = New SqlDataAdapter(command, GetConnection)
                Using sqlDataTable = New DataTable
                    sqlDataAdapter.Fill(sqlDataTable)

                    Return sqlDataTable

                End Using
            End Using
        End Function


    End Class

End Namespace

