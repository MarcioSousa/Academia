Public Class Pessoa
    Private Codigo As Integer
    Private Nome As String
    Private Foto As String
    Private Ativo As String
    Private DataCadastro As Date
    Private DataNascimento As Date
    Private Observacao As String
    Private Rg As String
    Private Cpf As String

    Public Property vCodigo As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
        End Set
    End Property
    Public Property vNome As String
        Get
            Return Nome
        End Get
        Set(value As String)
            Nome = value
        End Set
    End Property
    Public Property vFoto As String
        Get
            Return Foto
        End Get
        Set(value As String)
            Foto = value
        End Set
    End Property
    Public Property vAtivo As String
        Get
            Return Ativo
        End Get
        Set(value As String)
            Ativo = value
        End Set
    End Property
    Public Property vDataCadastro As Date
        Get
            Return DataCadastro
        End Get
        Set(value As Date)
            DataCadastro = value
        End Set
    End Property
    Public Property vDataNascimento As Date
        Get
            Return DataNascimento
        End Get
        Set(value As Date)
            DataNascimento = value
        End Set
    End Property
    Public Property vObservacao As String
        Get
            Return Observacao
        End Get
        Set(value As String)
            Observacao = value
        End Set
    End Property
    Public Property vRg As String
        Get
            Return Rg
        End Get
        Set(value As String)
            Rg = value
        End Set
    End Property
    Public Property vCpf As String
        Get
            Return Cpf
        End Get
        Set(value As String)
            Cpf = value
        End Set
    End Property

End Class