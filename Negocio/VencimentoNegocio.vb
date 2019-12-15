Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class VencimentoNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vVencimento As Vencimento) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@CodigoProduto", vVencimento.vCodigoProduto)
            vAcessoSqlServer.AdicionarParametros("@Data", vVencimento.vDataVencimento)
            vAcessoSqlServer.AdicionarParametros("@Dataentrada", vVencimento.vDataEntrada)
            vAcessoSqlServer.AdicionarParametros("@Qtdeestoque", vVencimento.vQtdeEstoque)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vVencimento.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVencimentoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vVencimento As Vencimento) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@Codigo", vVencimento.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@CodigoProduto", vVencimento.vCodigoProduto)
            vAcessoSqlServer.AdicionarParametros("@Data", vVencimento.vDataVencimento)
            vAcessoSqlServer.AdicionarParametros("@Dataentrada", vVencimento.vDataEntrada)
            vAcessoSqlServer.AdicionarParametros("@Qtdeestoque", vVencimento.vQtdeEstoque)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vVencimento.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVencimentoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vVencimento As Vencimento) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vVencimento.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspVencimentoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function CarregarConsulta(vCodigo As Integer) As VencimentoColecao
        Try
            Dim colecVencimento As New VencimentoColecao
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vCodigo)
            Dim tabelaVencimento As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspVencimentoCarregarCodigo")

            For Each linha As DataRow In tabelaVencimento.Rows
                Dim aVencimento As New Vencimento
                aVencimento.vCodigo = Convert.ToInt32(linha("ven_cod"))
                aVencimento.vDataVencimento = Convert.ToString(linha("ven_data"))
                aVencimento.vDataEntrada = Convert.ToString(linha("ven_dataentrada"))
                aVencimento.vQtdeEstoque = Convert.ToString(linha("ven_qtdeestoque"))
                aVencimento.vCodigoProduto = Convert.ToString(linha("ven_prodcod"))
                aVencimento.vAtivo = Convert.ToString(linha("ven_ativo"))
                colecVencimento.Add(aVencimento)
            Next

            Return colecVencimento
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

End Class