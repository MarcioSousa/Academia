Public Class Produto
    Private Codigo As Integer
    Private Nome As String
    Private Marca As String
    Private ValorCompra As Decimal
    Private ValorVenda As Decimal
    Private QtdeMinima As Integer
    Private CodigoFornecedor As Integer
    Private Ativo As String
    Private Foto As String
    Private DataCompra As Date
    Private DataVencimento As Date
    Private QtdeEstoque As Integer
    Private AtivoVencimento As String
    Private NomeFornecedor As String
    Private CodigoFornecProduto As Integer

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
    Public Property vMarca As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property
    Public Property vValorCompra As Decimal
        Get
            Return ValorCompra
        End Get
        Set(value As Decimal)
            ValorCompra = value
        End Set
    End Property
    Public Property vValorVenda As Decimal
        Get
            Return ValorVenda
        End Get
        Set(value As Decimal)
            ValorVenda = value
        End Set
    End Property
    Public Property vQtdeMinima As Integer
        Get
            Return QtdeMinima
        End Get
        Set(value As Integer)
            QtdeMinima = value
        End Set
    End Property
    Public Property vCodigoFornecedor As Integer
        Get
            Return CodigoFornecedor
        End Get
        Set(value As Integer)
            CodigoFornecedor = value
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
    Public Property vDataCompra As Date
        Get
            Return DataCompra
        End Get
        Set(value As Date)
            DataCompra = value
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
    Public Property vQtdeEstoque As Integer
        Get
            Return QtdeEstoque
        End Get
        Set(value As Integer)
            QtdeEstoque = value
        End Set
    End Property
    Public Property vAtivoVenc As String
        Get
            Return AtivoVencimento
        End Get
        Set(value As String)
            AtivoVencimento = value
        End Set
    End Property
    Public Property vNomeFornecedor As String
        Get
            Return NomeFornecedor
        End Get
        Set(value As String)
            NomeFornecedor = value
        End Set
    End Property
    Public Property vCodigoFornecProduto As Integer
        Get
            Return CodigoFornecProduto
        End Get
        Set(value As Integer)
            CodigoFornecProduto = value
        End Set
    End Property

End Class
