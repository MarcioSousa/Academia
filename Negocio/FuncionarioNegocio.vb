Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class FuncionarioNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vFuncionario As Funcionario) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@Nome", vFuncionario.vNome)
            vAcessoSqlServer.AdicionarParametros("@Cargo", vFuncionario.vCargo)
            vAcessoSqlServer.AdicionarParametros("@Dataentrada", vFuncionario.vDataEntrada)
            vAcessoSqlServer.AdicionarParametros("@Datasaida", vFuncionario.vDataSaida)
            vAcessoSqlServer.AdicionarParametros("@Pagamento", vFuncionario.vPagamento)
            vAcessoSqlServer.AdicionarParametros("@Foto", vFuncionario.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vFuncionario.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vFuncionario As Funcionario) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@Codigo", vFuncionario.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Nome", vFuncionario.vNome)
            vAcessoSqlServer.AdicionarParametros("@Cargo", vFuncionario.vCargo)
            vAcessoSqlServer.AdicionarParametros("@Dataentrada", vFuncionario.vDataEntrada)
            vAcessoSqlServer.AdicionarParametros("@Datasaida", vFuncionario.vDataSaida)
            vAcessoSqlServer.AdicionarParametros("@Pagamento", vFuncionario.vPagamento)
            vAcessoSqlServer.AdicionarParametros("@Foto", vFuncionario.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vFuncionario.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vFuncionario As Funcionario) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            vAcessoSqlServer.AdicionarParametros("@Codigo", vFuncionario.vCodigo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Carregar() As FuncionarioColecao
        Try
            Dim colecFuncionario As New FuncionarioColecao
            vAcessoSqlServer.LimparParametros()

            Dim tabelaFuncionario As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspFuncionarioCarregar")

            For Each linha As DataRow In tabelaFuncionario.Rows
                Dim aFuncionario As New Funcionario
                aFuncionario.vCodigo = Convert.ToInt32(linha("fun_cod"))
                aFuncionario.vNome = Convert.ToString(linha("fun_nome"))
                aFuncionario.vCargo = Convert.ToString(linha("fun_cargo"))
                If Convert.ToString(linha("fun_dataentrada")) <> Nothing Then
                    aFuncionario.vDataEntrada = Convert.ToString(linha("fun_dataentrada"))
                Else
                    aFuncionario.vDataEntrada = Nothing
                End If
                If Convert.ToString(linha("fun_datasaida")) <> Nothing Then
                    aFuncionario.vDataSaida = Convert.ToString(linha("fun_datasaida"))
                Else
                    aFuncionario.vDataSaida = Nothing
                End If

                aFuncionario.vPagamento = Convert.ToString(linha("fun_pagamento"))
                aFuncionario.vFoto = Convert.ToString(linha("fun_foto"))
                aFuncionario.vAtivo = Convert.ToString(linha("fun_ativo"))
                colecFuncionario.Add(aFuncionario)
            Next

            Return colecFuncionario
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

End Class
