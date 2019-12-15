Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class ProdutoNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vProduto As Produto) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@CodigoFornecedor", vProduto.vCodigoFornecedor)
            vAcessoSqlServer.AdicionarParametros("@Nome", vProduto.vNome)
            vAcessoSqlServer.AdicionarParametros("@Marca", vProduto.vMarca)
            vAcessoSqlServer.AdicionarParametros("@ValorCompra", vProduto.vValorCompra)
            vAcessoSqlServer.AdicionarParametros("@ValorVenda", vProduto.vValorVenda)
            vAcessoSqlServer.AdicionarParametros("@QtdeMinima", vProduto.vQtdeMinima)
            vAcessoSqlServer.AdicionarParametros("@Foto", vProduto.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vProduto.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vProduto As Produto) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@Codigo", vProduto.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@CodigoFornecedor", vProduto.vCodigoFornecedor)
            vAcessoSqlServer.AdicionarParametros("@Nome", vProduto.vNome)
            vAcessoSqlServer.AdicionarParametros("@Marca", vProduto.vMarca)
            vAcessoSqlServer.AdicionarParametros("@ValorCompra", vProduto.vValorCompra)
            vAcessoSqlServer.AdicionarParametros("@ValorVenda", vProduto.vValorVenda)
            vAcessoSqlServer.AdicionarParametros("@QtdeMinima", vProduto.vQtdeMinima)
            vAcessoSqlServer.AdicionarParametros("@Foto", vProduto.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vProduto.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vProduto As Produto) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vProduto.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function CarregarConsulta() As ProdutoColecao
        Try
            Dim colecProduto As New ProdutoColecao
            vAcessoSqlServer.LimparParametros()

            Dim tabelaProduto As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoCarregar")

            For Each linha As DataRow In tabelaProduto.Rows
                Dim aProduto As New Produto
                aProduto.vCodigo = Convert.ToInt32(linha("pro_cod"))
                aProduto.vNome = Convert.ToString(linha("pro_nome"))
                aProduto.vMarca = Convert.ToString(linha("pro_marca"))
                aProduto.vValorCompra = Convert.ToString(linha("pro_vcompra"))
                aProduto.vValorVenda = Convert.ToString(linha("pro_vvenda"))
                aProduto.vQtdeMinima = Convert.ToString(linha("pro_qtdeminima"))
                aProduto.vCodigoFornecedor = Convert.ToString(linha("pro_forcod"))
                aProduto.vAtivo = Convert.ToString(linha("pro_ativo"))
                aProduto.vFoto = Convert.ToString(linha("pro_foto"))
                aProduto.vNomeFornecedor = Convert.ToString(linha("for_nome"))
                aProduto.vCodigoFornecProduto = Convert.ToInt32(linha("pro_forcod"))

                colecProduto.Add(aProduto)
            Next

            Return colecProduto
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

    Public Function CarregarConsultaCodigo(CodigoProduto As Integer) As ProdutoColecao
        Try
            Dim colecProduto As New ProdutoColecao
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", CodigoProduto)
            Dim tabelaProduto As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoPesquisa")

            Dim aProduto As New Produto

            If tabelaProduto.Rows.Count = 1 Then
                aProduto.vNome = tabelaProduto.Rows(0)("pro_nome").ToString
                aProduto.vValorVenda = tabelaProduto.Rows(0)("pro_vvenda").ToString
                aProduto.vFoto = tabelaProduto.Rows(0)("pro_foto").ToString
            End If

            colecProduto.Add(aProduto)
            Return colecProduto
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function
End Class