Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class AulaNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vAula As Aula) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@Nome", vAula.vNome)
            vAcessoSqlServer.AdicionarParametros("@Categoria", vAula.vCategoria)
            vAcessoSqlServer.AdicionarParametros("@Inicio", vAula.vInicio)
            vAcessoSqlServer.AdicionarParametros("@Professor", vAula.vCodigoFuncionario)
            vAcessoSqlServer.AdicionarParametros("@Preco", vAula.vPreco)
            vAcessoSqlServer.AdicionarParametros("@Foto", vAula.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vAula.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAulaCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vAula As Aula) As String
        Try
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@Codigo", vAula.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Nome", vAula.vNome)
            vAcessoSqlServer.AdicionarParametros("@Categoria", vAula.vCategoria)
            vAcessoSqlServer.AdicionarParametros("@Inicio", vAula.vInicio)
            vAcessoSqlServer.AdicionarParametros("@Professor", vAula.vCodigoFuncionario)
            vAcessoSqlServer.AdicionarParametros("@Preco", vAula.vPreco)
            vAcessoSqlServer.AdicionarParametros("@Foto", vAula.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vAula.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAulaCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vAula As Aula) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vAula.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAulaCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function CarregarConsulta() As AulaColecao
        Try
            Dim colecAula As New AulaColecao
            vAcessoSqlServer.LimparParametros()

            Dim tabelaAula As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAulaCarregar")

            For Each linha As DataRow In tabelaAula.Rows
                Dim aAulas As New Aula
                aAulas.vCodigo = Convert.ToInt32(linha("aul_cod"))
                aAulas.vNome = Convert.ToString(linha("aul_nome"))
                aAulas.vCategoria = Convert.ToString(linha("aul_categoria"))
                aAulas.vInicio = Convert.ToString(linha("aul_inicio"))
                aAulas.vNomeFuncionario = Convert.ToString(linha("fun_nome"))
                aAulas.vCodigoFuncionario = Convert.ToInt32(linha("aul_funcod"))
                aAulas.vPreco = Convert.ToString(linha("aul_preco"))
                aAulas.vAtivo = Convert.ToString(linha("aul_ativo"))
                aAulas.vFoto = Convert.ToString(linha("aul_foto"))
                colecAula.Add(aAulas)
            Next

            Return colecAula
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

End Class