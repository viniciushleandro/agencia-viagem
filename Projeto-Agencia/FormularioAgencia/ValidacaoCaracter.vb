Module ValidacaoCaracter
    Public Sub PermitirApenasNumeros(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Public Sub PermitirApenasLetras(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub
End Module
