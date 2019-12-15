Public Class Funcionario
    Inherits Pessoa
    Private Cargo As String
    Private DataEntrada As Date
    Private DataSaida As Date
    Private Pagamento As Decimal

    Public Property vCargo As String
        Get
            Return Cargo
        End Get
        Set(value As String)
            Cargo = value
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
    Public Property vDataSaida As Date
        Get
            Return DataSaida
        End Get
        Set(value As Date)
            DataSaida = value
        End Set
    End Property
    Public Property vPagamento As Decimal
        Get
            Return Pagamento
        End Get
        Set(value As Decimal)
            Pagamento = value
        End Set
    End Property

End Class
