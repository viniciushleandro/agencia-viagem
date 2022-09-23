Imports System.ComponentModel.Design
Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports Agencia.AgenciaDeViagem

Public Class FmPacote
    Private Sub FmPacote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.Nome &
            Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.DataFundacao & " - Pacotes"

        '##--- Listando Enums no Dropdown ---##

        Dim primeiroTipo As New List(Of KeyValuePair(Of String, String))()
        Dim tipoPasseio = [Enum].GetValues(GetType(PacoteTuristico.eTipoPasseio))

        For Each tipo As PacoteTuristico.eTipoPasseio In tipoPasseio
            primeiroTipo.Add(New KeyValuePair(Of String, String)(tipo.ToString(),
                         CInt(tipo).ToString()))
        Next
        cbTpPasseio.DataSource = primeiroTipo
        cbTpPasseio.DisplayMember = "Key"
        cbTpPasseio.ValueMember = "Value"

        '##----------------------------------##

        Dim commandSelect = "select * from dbo.Destino"
        grdDestinos.DataSource = Dados.GetDataTable(commandSelect)

        Dim colSelecao As New DataGridViewCheckBoxColumn
        colSelecao.Name = "colSelecao"
        colSelecao.HeaderText = "Selecionar"

        grdDestinos.Columns.Add(colSelecao)

    End Sub

    Private Sub btnCadPacote_Click(sender As Object, e As EventArgs) Handles btnCadPacote.Click

        Dim tpPasseio As Integer

        If cbTpPasseio.Text <> "" Then
            tpPasseio = cbTpPasseio.SelectedValue
        End If

        If FValidaCamposVaziosPacote() = False Then Exit Sub

        '##--- Validação de Data ---##

        If FValidarData(txtDataViagem.Text) = False Then
            txtDataViagem.Focus()
            If Not txtDataViagem.MaskCompleted Then
                MessageBox.Show("Campo 'Data de Viagem' incompleto")
            End If
            Exit Sub
        End If

        '##------------------------##

        Dim AgenciaPacote = New PacoteTuristico(txtNumPacote.Text, tpPasseio) With {
            .DataViagem = txtDataViagem.Text,
            .Diarias = txtDiarias.Text,
            .Preco = txtPreco.Text
        }

        If grdDestinos.Rows.Count > 0 Then
            For i = 0 To grdDestinos.Rows.Count - 1
                If grdDestinos.Rows(i).Cells("colselecao").Value = True Then
                    Dim codigoDestino As Integer = grdDestinos.Rows(i).Cells("codigo_destino").Value
                    Dim destino As New Destino(codigoDestino)
                    AgenciaPacote.AdicionaDestino(destino)
                End If
            Next
        End If

        AgenciaPacote.GravaPacote()
        AgenciaPacote.GravaPacoteDestino()

        MsgBox("Cadastro realizado com sucesso!")

    End Sub

    Private Sub txtNumPacote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumPacote.KeyPress
        PermitirApenasNumeros(sender, e)
    End Sub

    Private Sub txtDiarias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiarias.KeyPress
        PermitirApenasNumeros(sender, e)
    End Sub

    Private Sub txtPreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreco.KeyPress
        PermitirApenasNumeros(sender, e)
    End Sub

    Private Function FValidaCamposVaziosPacote()

        If txtNumPacote.Text = "" Then
            MsgBox("Preencha o campo 'Numero do Pacote'", MsgBoxStyle.Information)
            txtNumPacote.Focus()
            Return False
        End If

        If cbTpPasseio.Text = "" Then
            MsgBox("Preencha o campo 'Tipo de Passeio'", MsgBoxStyle.Information)
            cbTpPasseio.Focus()
            Return False
        End If

        If txtDiarias.Text = "" Then
            MsgBox("Preencha o campo 'Diarias'", MsgBoxStyle.Information)
            txtDiarias.Focus()
            Return False
        End If

        If txtPreco.Text = "" Then
            MsgBox("Preencha o campo 'Preço'", MsgBoxStyle.Information)
            txtPreco.Focus()
            Return False
        End If

        Return True

    End Function

End Class