
Imports Agencia.AgenciaDeViagem

Public Class FmDestino
    Private Sub FmDestino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.Nome &
            Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.DataFundacao & " - Destinos"
    End Sub

    Private Sub btnCadDestino_Click(sender As Object, e As EventArgs) Handles btnCadDestino.Click

        If FValidaCamposVaziosDestino() = False Then Exit Sub

        Dim AgenciaDestino = New Destino(txtCodDestino.Text, txtCidade.Text, txtUf.Text)

        'Destino.ListaDestinos.Add(AgenciaDestino)

        AgenciaDestino.GravaDestino()

        MsgBox("Cadastro realizado com sucesso!")

    End Sub

    Public Function FValidaCamposVaziosDestino()

        If txtCodDestino.Text = "" Then
            MsgBox("Preencha o campo 'Código'", MsgBoxStyle.Information)
            txtCodDestino.Focus()
            Return False
        End If

        If txtCidade.Text = "" Then
            MsgBox("Preencha o campo 'Cidade'", MsgBoxStyle.Information)
            txtCidade.Focus()
            Return False
        End If

        If txtUf.Text = "" Then
            MsgBox("Preencha o campo 'UF'", MsgBoxStyle.Information)
            txtUf.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub txtCodDestino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodDestino.KeyPress
        PermitirApenasNumeros(sender, e)
    End Sub

    Private Sub txtCidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCidade.KeyPress
        PermitirApenasLetras(sender, e)
    End Sub

    Private Sub txtUf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUf.KeyPress
        PermitirApenasLetras(sender, e)
    End Sub

End Class