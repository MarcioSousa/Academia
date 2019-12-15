Public Class Vencimento
    Private Codigo As Integer
    Private DataVencimento As Date
    Private DataEntrada As Date
    Private QtdeEstoque As Integer
    Private CodigoProduto As Integer
    Private Ativo As String

    Public Property vCodigo As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
        End Set
    End Property
    Public Property vDataVencimento As Date
        Get
            Return DataVencimento
        End Get
        Set(value As Date)
            DataVencimento = value
        End Set
    End Property
    Public Property vDataEntrada As Date
        Get
            Return DataEntrada
        End Get
        Set(value As Date)
            DataEntrada = value
        End Set
    End Property
    Public Property vQtdeEstoque As Integer
        Get
            Return QtdeEstoque
        End Get
        Set(value As Integer)
            QtdeEstoque = value
        End Set
    End Property
    Public Property vCodigoProduto As Integer
        Get
            Return CodigoProduto
        End Get
        Set(value As Integer)
            CodigoProduto = value
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

End Class
