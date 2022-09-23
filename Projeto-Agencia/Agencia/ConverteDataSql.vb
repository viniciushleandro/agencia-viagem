Namespace AgenciaDeViagem
    Public Class ConverteDataSql

        Public Shared Function Conversor(ByVal data As DateTime) As String
            If data = CDate(Nothing) Then
                Return "NULL"
            Else
                Return "CONVERT(DATETIME, '" & data.Year & "-" & data.Month & "-" & data.Day & " " & data.Hour & ":" & data.Minute & ":" & data.Second & "', 120)"
            End If
        End Function
    End Class
End Namespace

