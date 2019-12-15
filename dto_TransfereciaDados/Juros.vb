Public Class Juros
    Private Codigo As Integer
    Private JurDia As Decimal
    Private JurMes As Decimal
    Private JurAno As Decimal
    Private JurDesDia As Decimal
    Private JurDesMes As Decimal
    Private JurDesAno As Decimal
    Private Ativo As String

    Public Property vCodigo As Integer
        Get
            Return Codigo
        End Get
        Set(value As Integer)
            Codigo = value
        End Set
    End Property
    Public Property vJurDia As Decimal
        Get
            Return JurDia
        End Get
        Set(value As Decimal)
            JurDia = value
        End Set
    End Property
    Public Property vJurMes As Decimal
        Get
            Return JurMes
        End Get
        Set(value As Decimal)
            JurMes = value
        End Set
    End Property
    Public Property vjurAno As Decimal
        Get
            Return JurAno
        End Get
        Set(value As Decimal)
            JurAno = value
        End Set
    End Property
    Public Property vJurDesDia As Decimal
        Get
            Return JurDesDia
        End Get
        Set(value As Decimal)
            JurDesDia = value
        End Set
    End Property
    Public Property vJurDesMes As Decimal
        Get
            Return JurDesMes
        End Get
        Set(value As Decimal)
            JurDesMes = value
        End Set
    End Property
    Public Property vjurDesAno As Decimal
        Get
            Return JurDesAno
        End Get
        Set(value As Decimal)
            JurDesAno = value
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
