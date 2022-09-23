Namespace AgenciaDeViagem

    <Serializable()>
    Public Class Cliente

        Private _Nome As String
        Private _Cpf As String
        Private _dataNascimento As Date

        Sub New(nome As String, cpf As String, dataNascimento As Date)
            _Nome = nome
            _Cpf = cpf
            _dataNascimento = dataNascimento
        End Sub

        Sub New(cpf As String)
            _Cpf = cpf
            Using dr = Dados.GetDataReader($"select * from dbo.Cliente where CPF = '{_Cpf}'")
                If dr.HasRows Then
                    Do While dr.Read
                        _Nome = dr.Item("Nome")
                        _dataNascimento = dr.Item("Data_Nascimento")
                    Loop
                Else
                    MsgBox("Cliente não encontrado!")
                End If

            End Using
        End Sub

        'Public Shared Property ClienteGlobal As New Cliente

        Public Property Nome As String
            Get
                Return _Nome
            End Get
            Set(alterarNomeCliente As String)
                _Nome = alterarNomeCliente
            End Set
        End Property

        Public Property Cpf As String
            Get
                Return _Cpf
            End Get
            Set(alterarCpf As String)
                _Cpf = alterarCpf
            End Set
        End Property

        Public Property DataNascimento As Date
            Get
                Return _dataNascimento
            End Get
            Set(alterarDataNascimento As Date)
                _dataNascimento = alterarDataNascimento
            End Set
        End Property

        Public Sub GravaCliente()
            Dim dtNasc = ConverteDataSql.Conversor(DataNascimento)
            Dim command = $"insert into dbo.Cliente 
                           (Nome,
                            CPF,
                            Data_Nascimento)
                      values
                            ('{Nome}', '{Cpf}', {dtNasc})"

            Dados.ExecutaComando(command)
        End Sub

    End Class


End Namespace


