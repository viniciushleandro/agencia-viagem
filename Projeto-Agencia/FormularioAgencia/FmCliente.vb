Imports Agencia.AgenciaDeViagem
Public Class FmCliente
    Private Sub FmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.Nome &
            Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.DataFundacao & " - Cliente"
    End Sub

    Private Sub btnCadCliente_Click(sender As Object, e As EventArgs) Handles btnCadCliente.Click

        If FValidaCamposVaziosCliente() = False Then Exit Sub

        If FValidarData(txtDataNascimento.Text) = False Then
            txtDataNascimento.Focus()
            If Not txtDataNascimento.MaskCompleted Then
                MessageBox.Show("Campo 'Data de Nascimento' incompleto")
            End If
            Exit Sub
        End If

        Dim cliente = New Cliente(txtNomeCliente.Text, txtCpf.Text, txtDataNascimento.Text)

        cliente.GravaCliente()

        MsgBox("Cadastro realizado com sucesso!")
    End Sub

    Private Sub txtNomeCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeCliente.KeyPress
        PermitirApenasLetras(sender, e)
    End Sub

    Private Sub txtCpf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCpf.KeyPress
        PermitirApenasNumeros(sender, e)
    End Sub

    Private Sub txtDataNascimento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDataNascimento.KeyPress
        PermitirApenasNumeros(sender, e)
    End Sub

    Private Function FValidaCamposVaziosCliente()
        If txtNomeCliente.Text = "" Then
            MsgBox("Preencha o campo 'Nome do Cliente'", MsgBoxStyle.Information)
            txtNomeCliente.Focus()
            Return False
        End If

        If Not txtCpf.MaskCompleted Then
            MsgBox("Campo 'CPF' incompleto!")
            txtCpf.Focus()
            Return False
        End If

        Return True
    End Function
End Class