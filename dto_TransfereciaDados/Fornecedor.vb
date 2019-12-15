Public Class Fornecedor
    Inherits Pessoa
    Private Empresa As String
    Private ContatoUm As String
    Private ContatoDois As String

    Public Property vEmpresa As String
        Get
            Return Empresa
        End Get
        Set(value As String)
            Empresa = value
        End Set
    End Property
    Public Property vContatoUm As String
        Get
            Return ContatoUm
        End Get
        Set(value As String)
            ContatoUm = value
        End Set
    End Property
    Public Property vContatoDois As String
        Get
            Return ContatoDois
        End Get
        Set(value As String)
            ContatoDois = value
        End Set
    End Property

End Class