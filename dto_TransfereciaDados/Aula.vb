Public Class Aula
    Private Codigo As Integer
    Private Nome As String
    Private Categoria As String
    Private Inicio As Date
    Private CodigoFuncionario As Integer
    Private Preco As Decimal
    Private Ativo As String
    Private Foto As String
    Private NomeFuncionario As String

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
    Public Property vCategoria As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property
    Public Property vInicio As Date
        Get
            Return Inicio
        End Get
        Set(value As Date)
            Inicio = value
        End Set
    End Property
    Public Property vCodigoFuncionario As Integer
        Get
            Return CodigoFuncionario
        End Get
        Set(value As Integer)
            CodigoFuncionario = value
        End Set
    End Property
    Public Property vPreco As Decimal
        Get
            Return Preco
        End Get
        Set(value As Decimal)
            Preco = value
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
    Public Property vFoto As String
        Get
            Return Foto
        End Get
        Set(value As String)
            Foto = value
        End Set
    End Property
    Public Property vNomeFuncionario As String
        Get
            Return NomeFuncionario
        End Get
        Set(value As String)
            NomeFuncionario = value
        End Set
    End Property

End Class
