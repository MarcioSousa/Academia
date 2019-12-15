Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class JurosNegocio
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vJuros As Juros) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@Dia", vJuros.vJurDia)
            vAcessoSqlServer.AdicionarParametros("@Mes", vJuros.vJurMes)
            vAcessoSqlServer.AdicionarParametros("@Ano", vJuros.vjurAno)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vJuros.vAtivo)
            vAcessoSqlServer.AdicionarParametros("@Desdia", vJuros.vJurDesDia)
            vAcessoSqlServer.AdicionarParametros("@Desmes", vJuros.vJurDesMes)
            vAcessoSqlServer.AdicionarParametros("@Desano", vJuros.vjurDesAno)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspJuroCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vJuros As Juros) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vJuros.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@Dia", vJuros.vJurDia)
            vAcessoSqlServer.AdicionarParametros("@Mes", vJuros.vJurMes)
            vAcessoSqlServer.AdicionarParametros("@Ano", vJuros.vjurAno)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vJuros.vAtivo)
            vAcessoSqlServer.AdicionarParametros("@Desdia", vJuros.vJurDesDia)
            vAcessoSqlServer.AdicionarParametros("@Desmes", vJuros.vJurDesMes)
            vAcessoSqlServer.AdicionarParametros("@Desano", vJuros.vjurDesAno)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspJuroCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vJuros As Juros) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vJuros.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspJuroCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Carregar() As Juros
        Try
            Dim aJuros As New Juros
            vAcessoSqlServer.LimparParametros()

            Dim tabelaJuros As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspJuroCarrega")

            For Each linha As DataRow In tabelaJuros.Rows
                aJuros.vCodigo = Convert.ToInt32(linha("jur_cod"))
                aJuros.vJurDia = Convert.ToDecimal(linha("jur_dia"))
                aJuros.vJurMes = Convert.ToDecimal(linha("jur_mes"))
                aJuros.vjurAno = Convert.ToDecimal(linha("jur_ano"))
                aJuros.vJurDesDia = Convert.ToDecimal(linha("jur_desdia"))
                aJuros.vJurDesMes = Convert.ToDecimal(linha("jur_desmes"))
                aJuros.vjurDesAno = Convert.ToDecimal(linha("jur_desano"))
                aJuros.vAtivo = Convert.ToString(linha("jur_ativo"))
                Exit For
            Next

            Return aJuros
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

End Class
