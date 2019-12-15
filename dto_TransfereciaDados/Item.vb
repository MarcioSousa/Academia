Public Class Item
    Private Codigo As Integer
    Private CodigoCaixa As Integer
    Private CodigoProduto As Integer
    Private CodigoMensalidade As Integer
    Private ValorUnidade As Double
    Private Qtde As Integer
    Private Ativo As Char
    Private ValorEntrada As Double

    Public Property vCodigo() As Integer
        Get
            Return Codigo
        End Get
        Set(ByVal value As Integer)
            Codigo = value
        End Set
    End Property
    Public Property vCodigoCaixa() As Integer
        Get
            Return CodigoCaixa
        End Get
        Set(ByVal value As Integer)
            CodigoCaixa = value
        End Set
    End Property
    Public Property vCodigoProduto() As Integer
        Get
            Return CodigoProduto
        End Get
        Set(ByVal value As Integer)
            CodigoProduto = value
        End Set
    End Property
    Public Property vCodigoMensalidade() As Integer
        Get
            Return CodigoMensalidade
        End Get
        Set(ByVal value As Integer)
            CodigoMensalidade = value
        End Set
    End Property
    Public Property vValorUnidade() As Double
        Get
            Return ValorUnidade
        End Get
        Set(ByVal value As Double)
            ValorUnidade = value
        End Set
    End Property
    Public Property vQtde() As Integer
        Get
            Return Qtde
        End Get
        Set(ByVal value As Integer)
            Qtde = value
        End Set
    End Property
    Public Property vAtivo() As Char
        Get
            Return Ativo
        End Get
        Set(ByVal value As Char)
            Ativo = value
        End Set
    End Property
    Public Property vValorEntrada() As Double
        Get
            Return ValorEntrada
        End Get
        Set(ByVal value As Double)
            ValorEntrada = value
        End Set
    End Property

End Class
