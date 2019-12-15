Public Class Aluno
    Inherits Pessoa

    Private Rua As String
    Private Numero As String
    Private Complemento As String
    Private Apartamento As String
    Private Bairro As String
    Private Cidade As String
    Private Uf As String
    Private Cep As String
    Private Email As String
    Private TelCom As String
    Private TelCel As String

    Public Property vRua As String
        Get
            Return Rua
        End Get
        Set(value As String)
            Rua = value
        End Set
    End Property
    Public Property vNumero As String
        Get
            Return Numero
        End Get
        Set(value As String)
            Numero = value
        End Set
    End Property
    Public Property vComplemento As String
        Get
            Return Complemento
        End Get
        Set(value As String)
            Complemento = value
        End Set
    End Property
    Public Property vApartamento As String
        Get
            Return Apartamento
        End Get
        Set(value As String)
            Apartamento = value
        End Set
    End Property
    Public Property vBairro As String
        Get
            Return Bairro
        End Get
        Set(value As String)
            Bairro = value
        End Set
    End Property
    Public Property vCidade As String
        Get
            Return Cidade
        End Get
        Set(value As String)
            Cidade = value
        End Set
    End Property
    Public Property vUf As String
        Get
            Return Uf
        End Get
        Set(value As String)
            Uf = value
        End Set
    End Property
    Public Property vCep As String
        Get
            Return Cep
        End Get
        Set(value As String)
            Cep = value
        End Set
    End Property
    Public Property vEmail As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
    Public Property vTelCom As String
        Get
            Return TelCom
        End Get
        Set(value As String)
            TelCom = value
        End Set
    End Property
    Public Property vTelCel As String
        Get
            Return TelCel
        End Get
        Set(value As String)
            TelCel = value
        End Set
    End Property

End Class