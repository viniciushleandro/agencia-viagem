Namespace AgenciaDeViagem

    Public Class Destino

        Private _Codigo As Integer
        Private _Cidade As String
        Private _Uf As String

        Sub New(codigo As Integer, cidade As String, uf As String)
            _Codigo = codigo
            _Cidade = cidade
            _Uf = uf
        End Sub

        Sub New(codigo As Integer)
            _Codigo = codigo

            Using dr = Dados.GetDataReader("SELECT * FROM DESTINO WHERE CODIGO_DESTINO = " & _Codigo)
                Do While dr.Read
                    _Cidade = dr.Item("Cidade")
                    _Uf = dr.Item("Uf")
                Loop
            End Using
        End Sub

        Public Property Codigo() As Integer
            Get
                Return _Codigo
            End Get
            Set(novoCodigo As Integer)
                _Codigo = novoCodigo
            End Set
        End Property

        Public Property Cidade() As String
            Get
                Return _Cidade
            End Get
            Set(novaCidade As String)
                _Cidade = novaCidade
            End Set
        End Property

        Public Property Uf() As String
            Get
                Return _Uf
            End Get
            Set(novoUf As String)
                _Uf = novoUf
            End Set
        End Property

        Public Sub GravaDestino()
            Dim command = $"insert into dbo.Destino 
                           (Codigo_Destino,
                            Cidade,
                            Uf)
                      values
                            ({Codigo}, '{Cidade}', '{Uf}')"

            Dados.ExecutaComando(command)
        End Sub



    End Class

End Namespace


