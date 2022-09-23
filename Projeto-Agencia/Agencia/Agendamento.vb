Namespace AgenciaDeViagem
    Public Class Agendamento

        Private _Data As Date
        Private _Pago As Boolean

        Public Property Cliente As Cliente
        Public Property ListaPacote As PacoteTuristico()

        Sub New(data As Date, pago As Boolean)
            _Data = data
            _Pago = pago
        End Sub

        Public Property Data As Date
            Get
                Return _Data
            End Get
            Set(alteraData As Date)
                _Data = alteraData
            End Set
        End Property


        Public Property Pago As Boolean
            Get
                Return _Pago
            End Get
            Set(alteraStatusPagamento As Boolean)
                _Pago = alteraStatusPagamento
            End Set
        End Property

        Public Sub Grava(cpf As String, codigo As Integer)
            Dim dtAgendamento = ConverteDataSql.Conversor(Data)
            Dim command = $"insert into dbo.Agendamento (
                        Data_Agendamento,
                        Pago,
                        CPF_Cliente,
                        Codigo_Agendamento)
                    values
                        ({dtAgendamento}, {If(Pago, "1", "0")}, '{cpf}', {codigo})"

            Dados.ExecutaComando(command)
        End Sub

        Public Sub GravaAgendamentoPacote(codigo As Integer, numeroPacote As Integer, tipoPasseio As Integer)
            Dim command = $"insert into dbo.AgendamentoPacote (
                             Codigo_Agendamento,
                             Numero_Pacote,
                             Tipo_Passeio)
                         values
                             ({codigo}, {numeroPacote}, {tipoPasseio})"
            Dados.ExecutaComando(command)
        End Sub

    End Class

End Namespace

