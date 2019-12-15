Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class CaixaNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vCaixa As Caixa) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@DataPagamento", vCaixa.vDataPagamento)
            vAcessoSqlServer.AdicionarParametros("@ValorEntrada", vCaixa.vValorEntrada)
            vAcessoSqlServer.AdicionarParametros("@ValorTotal", vCaixa.vValorTotal)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vCaixa.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vCaixa As Caixa) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vCaixa.vDataPagamento)
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@DataPagamento", vCaixa.vDataPagamento)
            vAcessoSqlServer.AdicionarParametros("@ValorEntrada", vCaixa.vValorEntrada)
            vAcessoSqlServer.AdicionarParametros("@ValorTotal", vCaixa.vValorTotal)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vCaixa.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vCaixa As Caixa) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vCaixa.vDataPagamento)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCaixaCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

End Class
