Imports Agencia.AgenciaDeViagem
Public Class FmAgendamentos
    Private Sub FmAgendamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.Nome &
            Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.DataFundacao & " - Agendamentos"

        txtDataAgendamento.Text = Today

        grdPacotes.DataSource = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.ListaPacotesDisponiveis

        Dim colSelecao As New DataGridViewCheckBoxColumn
        colSelecao.Name = "colSelecao"
        colSelecao.HeaderText = "Selecionar"

        grdPacotes.Columns.Add(colSelecao)

        Dim commandSql = "select Pacote.*, Destino.Cidade, Destino.Uf from dbo.Pacote left join PacoteDestino ON PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote 
                            left join Destino on destino.Codigo_Destino = PacoteDestino.Codigo_Destino;"
        grdPacotes.DataSource = Dados.GetDataTable(commandSql)

    End Sub

    Private Sub btnCadAgendamento_Click(sender As Object, e As EventArgs) Handles btnCadAgendamento.Click

        If FValidaCamposVaziosAgendamentos() = False Then Exit Sub

        Dim agendamento = New Agendamento(txtDataAgendamento.Text, chkPago.CheckState)


        If grdPacotes.Rows.Count > 0 Then
            For i = 0 To grdPacotes.Rows.Count - 1
                If grdPacotes.Rows(i).Cells("colselecao").Value = True Then
                    Dim numeroPacote = grdPacotes.Rows(i).Cells("numero_pacote").Value
                    Dim tipoPasseio = grdPacotes.Rows(i).Cells("tipo_passeio").Value
                    agendamento.GravaAgendamentoPacote(txtCodAgendamento.Text, numeroPacote, tipoPasseio)

                End If
            Next
        End If

        agendamento.Grava(txtCpfAgendar.Text, txtCodAgendamento.Text)

        MsgBox("Agendamento realizado com sucesso!")


    End Sub

    Private Sub txtCpfAgendar_Validated(sender As Object, e As EventArgs) Handles txtCpfAgendar.Validated
        If txtCpfAgendar.MaskCompleted Then
            Dim cliente = New Cliente(txtCpfAgendar.Text)
            lblNomeCliente.Text = cliente.Nome
            txtDataNascAgendamento.Text = cliente.DataNascimento
        Else
            MsgBox("Preencha o campo 'CPF'")
        End If
    End Sub

    Private Sub txtDataViagem_Validated(sender As Object, e As EventArgs) Handles txtDataViagem.Validated
        If txtDataViagem.MaskCompleted Then
            If FValidarData(txtDataViagem.Text) = True Then
                Dim commandSql = $"select pacote.*, Destino.Cidade, Destino.Uf from dbo.Pacote left join PacoteDestino 
                                on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote 
                                 left join Destino on destino.codigo_Destino = PacoteDestino.Codigo_Destino
                                  where Data_Viagem >= '{txtDataViagem.Text}'"

                grdPacotes.DataSource = Dados.GetDataTable(commandSql)
                Exit Sub
            End If
            txtDataViagem.Focus()
        End If

    End Sub

    Private Function FValidaCamposVaziosAgendamentos()

        If txtCodAgendamento.Text = "" Then
            MsgBox("Preencha o campo 'Código'", MsgBoxStyle.Information)
            txtCodAgendamento.Focus()
            Return False
        End If

        Return True
    End Function

End Class