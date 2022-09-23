Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Agencia.AgenciaDeViagem
Public Class FmPesquisaAgendamento
    Private Sub FmPesquisaAgendamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.Nome &
            Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.DataFundacao & " - Pesquisa de Agendamentos"

        Dim commandSql = "select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                            inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                            left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                            left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                            left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                            left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino;"
        grdPesquisa.DataSource = Dados.GetDataTable(commandSql)

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        Dim commandSql

        If txtDataPesquisarAgendamento.MaskCompleted Then
            If FValidarData(txtDataPesquisarAgendamento.Text) = False Then
                txtDataPesquisarAgendamento.Focus()
                Exit Sub
            Else
                commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                        inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                        left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                        left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                        left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                        left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                        where Data_Viagem >= '{txtDataPesquisarAgendamento.Text}'"
                grdPesquisa.DataSource = Dados.GetDataTable(commandSql)

            End If
        End If

        If chkPagoPesquisa.Checked Then
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where Pago = {1}"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)

        Else
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where Pago = {0}"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)
        End If

        If txtCpfPesq.MaskCompleted And chkPagoPesquisa.Checked Then
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where Pago = {1} and CPF = '{txtCpfPesq.Text}'"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)

        ElseIf Not chkPagoPesquisa.Checked And txtCpfPesq.MaskCompleted Then
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where Pago = {0} and CPF = '{txtCpfPesq.Text}'"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)
        End If

        If txtCpfPesq.MaskCompleted Then
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where CPF = '{txtCpfPesq.Text}'"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)
        End If

        If txtDataPesquisarAgendamento.MaskCompleted And chkPagoPesquisa.Checked Then
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where Pago = {1} and Data_Viagem >= '{txtDataPesquisarAgendamento.Text}'"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)
        End If

        If txtDataPesquisarAgendamento.MaskCompleted And chkPagoPesquisa.Checked And txtCpfPesq.MaskCompleted Then
            commandSql = $"select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                                inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                                left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                                left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join PacoteDestino on PacoteDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                                left join Destino on Destino.Codigo_Destino = PacoteDestino.Codigo_Destino
                                where Pago = {1} and Data_Viagem >= '{txtDataPesquisarAgendamento.Text}' and CPF = '{txtCpfPesq.Text}'"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)
        End If

        If Not txtDataPesquisarAgendamento.MaskCompleted And chkPagoPesquisa.Checked = False And Not txtCpfPesq.MaskCompleted Then
            commandSql = "select Data_Agendamento, Pacote.Numero_Pacote as NumeroPacote, CPF, Cliente.Nome, Data_Viagem, Diarias, Preco as Preço, Cidade, UF from Agendamento
                            inner join Cliente on Agendamento.CPF_Cliente = Cliente.CPF
                            left join AgendamentoPacote ON Agendamento.Codigo_Agendamento = AgendamentoPacote.Codigo_Agendamento
                            left join Pacote on AgendamentoPacote.Numero_Pacote = Pacote.Numero_Pacote AND AgendamentoPacote.Tipo_Passeio = Pacote.Tipo_Passeio
                            left join PacoteDestino on PacotesDestino.Codigo_Pacote = Pacote.Numero_Pacote and PacoteDestino.Tipo_Passeio = Pacote.Tipo_Passeio
                            left join Destino on Destino.Codigo = PacoteDestino.Codigo_Destino;"
            grdPesquisa.DataSource = Dados.GetDataTable(commandSql)
        End If

        txtNomeClientePesq.Text = ""
        txtDataNascPesq.Text = ""
        txtCpfPesq.Text = ""
        txtDataPesquisarAgendamento.Text = ""
        chkPagoPesquisa.Checked = False

    End Sub

    Private Sub txtCpfPesq_Validated(sender As Object, e As EventArgs) Handles txtCpfPesq.Validated
        If txtCpfPesq.MaskCompleted Then
            Dim cliente = New Cliente(txtCpfPesq.Text)
            txtNomeClientePesq.Text = cliente.Nome
            txtDataNascPesq.Text = cliente.DataNascimento
        End If
    End Sub

End Class