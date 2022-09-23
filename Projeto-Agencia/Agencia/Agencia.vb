Namespace AgenciaDeViagem
    Public Class Agencia

        Private _Nome As String
        Private _dataFundacao As Date

        Public Property ListaPacotesDisponiveis As PacoteTuristico()
        Public Property ListaAgendamentos As Agendamento()

        Sub New(nome As String, dataFundacao As Date)
            _Nome = nome
            _dataFundacao = dataFundacao
        End Sub

        Public Shared Property AgenciaGlobal As New Agencia("DataPlus ERP - ", "14/08/1995")

        Public Property Nome As String
            Get
                Return _Nome
            End Get
            Set(alteraNomeAgencia As String)
                _Nome = alteraNomeAgencia
            End Set
        End Property

        Public Property DataFundacao As Date
            Get
                Return _dataFundacao
            End Get
            Set(alteraDataFundacao As Date)
                _dataFundacao = alteraDataFundacao
            End Set
        End Property

    End Class

End Namespace

