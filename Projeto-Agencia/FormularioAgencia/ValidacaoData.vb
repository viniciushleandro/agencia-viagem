Module ValidacaoData
    Public Function FValidarData(Data As String) As Boolean
        If Not IsDate(Data) Then
            FValidarData = False
            MessageBox.Show("Data inválida")
        ElseIf Year(Data) < 1900 Or Year(Data) > 2100 Then
            FValidarData = False
            MessageBox.Show("Ano inválido")
        Else
            FValidarData = True
        End If

    End Function
End Module
