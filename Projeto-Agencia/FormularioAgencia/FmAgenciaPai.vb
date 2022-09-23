Imports System.Windows.Forms

Public Class FmAgenciaPai

    Private Sub FmAgencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.Nome &
            Agencia.AgenciaDeViagem.Agencia.AgenciaGlobal.DataFundacao
    End Sub

    Private Sub mnPacotes_Click(sender As Object, e As EventArgs) Handles mnPacotes.Click
        If Application.OpenForms.OfType(Of FmPacote).Count = 0 Then
            Dim pacotes As New FmPacote
            pacotes.MdiParent = Me
            pacotes.Show()
        Else
            Application.OpenForms.OfType(Of FmPacote).First().WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub mnAgendamentos_Click(sender As Object, e As EventArgs) Handles mnAgendamentos.Click
        If Application.OpenForms.OfType(Of FmAgendamentos).Count = 0 Then
            Dim agendamentos As New FmAgendamentos
            agendamentos.MdiParent = Me
            agendamentos.Show()
        Else
            Application.OpenForms.OfType(Of FmAgendamentos).First().WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub mnCliente_Click(sender As Object, e As EventArgs) Handles mnCliente.Click
        If Application.OpenForms.OfType(Of FmCliente).Count = 0 Then
            Dim cliente As New FmCliente
            cliente.MdiParent = Me
            cliente.Show()
        Else
            Application.OpenForms.OfType(Of FmCliente).First().WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub mnDestino_Click(sender As Object, e As EventArgs) Handles mnDestino.Click
        If Application.OpenForms.OfType(Of FmDestino).Count = 0 Then
            Dim destino As New FmDestino
            destino.MdiParent = Me
            destino.Show()
        Else
            Application.OpenForms.OfType(Of FmDestino).First().WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub mnPesqAgend_Click(sender As Object, e As EventArgs) Handles mnPesqAgend.Click
        If Application.OpenForms.OfType(Of FmPesquisaAgendamento).Count = 0 Then
            Dim pesquisaAgendamento As New FmPesquisaAgendamento
            pesquisaAgendamento.MdiParent = Me
            pesquisaAgendamento.Show()
        Else
            Application.OpenForms.OfType(Of FmPesquisaAgendamento).First().WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
