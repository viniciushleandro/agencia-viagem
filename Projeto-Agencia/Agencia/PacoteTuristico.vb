Namespace AgenciaDeViagem
    Public Class PacoteTuristico

        Private _Numero As Integer
        Private _DataViagem As Date
        Private _Diarias As Integer
        Private _Preco As Decimal

        Public Property TipoPasseio As eTipoPasseio

        Public Enum eTipoPasseio
            Excursao = 0
            Particular = 1
            Outros = 2
        End Enum

        Sub New(numero As Integer, tpPasseio As eTipoPasseio)
            _Numero = numero
            TipoPasseio = tpPasseio
        End Sub

        ReadOnly Property Numero As Integer
            Get
                Return _Numero
            End Get
        End Property

        Public Property DataViagem As Date
            Get
                Return _DataViagem
            End Get
            Set(alterarData As Date)
                _DataViagem = alterarData
            End Set
        End Property

        Public Property Diarias As Integer
            Get
                Return _Diarias
            End Get
            Set(alterarDias As Integer)
                _Diarias = alterarDias
            End Set
        End Property

        Public Property Preco As Decimal
            Get
                Return _Preco
            End Get
            Set(alterarPreco As Decimal)
                _Preco = alterarPreco
            End Set
        End Property

        Public Property Destinos As Destino()

        Public Sub AdicionaDestino(paramdestino As Destino)
            If Destinos Is Nothing Then
                ReDim Destinos(0)
            Else
                ReDim Preserve Destinos(UBound(Destinos) + 1)
            End If

            Destinos(UBound(Destinos)) = paramdestino
        End Sub

        Public Sub GravaPacote()
            Dim dtViagem = ConverteDataSql.Conversor(DataViagem)
            Dim command = $"insert into dbo.Pacote 
                           (Numero_Pacote,
                            Tipo_Passeio,
                            Data_Viagem,
                            Diarias,
                            Preco)
                      values
                            ({Numero}, {CInt(TipoPasseio)}, {dtViagem}, {Diarias}, {Preco})"

            Dados.ExecutaComando(command)
        End Sub

        Public Sub GravaPacoteDestino()

            For Each pacote As Destino In Destinos
                Dim codigoDestino = pacote.Codigo

                Dim command = $"insert into dbo.PacoteDestino
                           (Codigo_Pacote,
                            Tipo_Passeio,
                            Codigo_Destino)
                      values
                            ({Numero}, {CInt(TipoPasseio)}, {codigoDestino})"

                Dados.ExecutaComando(command)
            Next
        End Sub

    End Class

End Namespace


