Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class FornecedorNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vFornecedor As Fornecedor) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@Nome", vFornecedor.vNome)
            vAcessoSqlServer.AdicionarParametros("@Empresa", vFornecedor.vEmpresa)
            vAcessoSqlServer.AdicionarParametros("@Contato", vFornecedor.vContatoUm)
            vAcessoSqlServer.AdicionarParametros("@Contatodois", vFornecedor.vContatoDois)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vFornecedor.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vFornecedor As Fornecedor) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@Codigo", vFornecedor.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Nome", vFornecedor.vNome)
            vAcessoSqlServer.AdicionarParametros("@Empresa", vFornecedor.vEmpresa)
            vAcessoSqlServer.AdicionarParametros("@Contato", vFornecedor.vContatoUm)
            vAcessoSqlServer.AdicionarParametros("@Contatodois", vFornecedor.vContatoDois)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vFornecedor.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vFornecedor As Fornecedor) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vFornecedor.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFornecedorCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Carregar() As FornecedorColecao
        Try
            Dim colecFornecedor As New FornecedorColecao
            vAcessoSqlServer.LimparParametros()

            Dim tabelaFornec As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFornecedorCarregar")

            For Each linha As DataRow In tabelaFornec.Rows
                Dim aFornec As New Fornecedor
                aFornec.vCodigo = Convert.ToInt32(linha("for_cod"))
                aFornec.vNome = Convert.ToString(linha("for_nome"))
                aFornec.vEmpresa = Convert.ToString(linha("for_empresa"))
                aFornec.vContatoUm = Convert.ToString(linha("for_contato"))
                aFornec.vContatoDois = Convert.ToString(linha("for_contatodois"))
                aFornec.vAtivo = Convert.ToString(linha("for_ativo"))
                colecFornecedor.Add(aFornec)
            Next

            Return colecFornecedor
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

End Class
