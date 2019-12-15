Public Class Caixa
    Private Codigo As Integer
    Private DataPagamento As Date
    Private ValorTotal As Double
    Private Tipo As Char
    Private Ativo As Char
    Private ValorEntrada As Double

    Public Property vCodigo As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
        End Set
    End Property
    Public Property vDataPagamento As Date
        Get
            Return DataPagamento
        End Get
        Set(value As Date)
            DataPagamento = value
        End Set
    End Property
    Public Property vValorTotal As Double
        Get
            Return ValorTotal
        End Get
        Set(value As Double)
            ValorTotal = value
        End Set
    End Property
    Public Property vTipo As Char
        Get
            Return Tipo
        End Get
        Set(value As Char)
            Tipo = value
        End Set
    End Property
    Public Property vAtivo As Char
        Get
            Return Ativo
        End Get
        Set(value As Char)
            Ativo = value
        End Set
    End Property
    Public Property vValorEntrada As Double
        Get
            Return ValorEntrada
        End Get
        Set(value As Double)
            ValorEntrada = value
        End Set
    End Property

End Class
