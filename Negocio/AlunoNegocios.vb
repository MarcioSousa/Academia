Imports dao_AcessoSqlServer
Imports dto_TransfereciaDados

Public Class AlunoNegocios
    Private vAcessoSqlServer As New AcessoSqlServer

    Public Function Inserir(vAluno As Aluno) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Acao", 0)
            vAcessoSqlServer.AdicionarParametros("@nome", vAluno.vNome)
            vAcessoSqlServer.AdicionarParametros("@Foto", vAluno.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Rg", vAluno.vRg)
            vAcessoSqlServer.AdicionarParametros("@Cpf", vAluno.vCpf)
            vAcessoSqlServer.AdicionarParametros("@DataNascimento", vAluno.vDataNascimento)
            vAcessoSqlServer.AdicionarParametros("@Rua", vAluno.vRua)
            vAcessoSqlServer.AdicionarParametros("@Numero", vAluno.vNumero)
            vAcessoSqlServer.AdicionarParametros("@Complemento", vAluno.vComplemento)
            vAcessoSqlServer.AdicionarParametros("@Apartamento", vAluno.vApartamento)
            vAcessoSqlServer.AdicionarParametros("@Bairro", vAluno.vBairro)
            vAcessoSqlServer.AdicionarParametros("@Cidade", vAluno.vCidade)
            vAcessoSqlServer.AdicionarParametros("@Uf", vAluno.vUf)
            vAcessoSqlServer.AdicionarParametros("@Cep", vAluno.vCep)
            vAcessoSqlServer.AdicionarParametros("@Email", vAluno.vEmail)
            vAcessoSqlServer.AdicionarParametros("@Telcom", vAluno.vTelCom)
            vAcessoSqlServer.AdicionarParametros("@Telcel", vAluno.vTelCel)
            vAcessoSqlServer.AdicionarParametros("@Observacao", vAluno.vObservacao)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vAluno.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Alterar(vAluno As Aluno) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vAluno.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 1)
            vAcessoSqlServer.AdicionarParametros("@nome", vAluno.vNome)
            vAcessoSqlServer.AdicionarParametros("@Foto", vAluno.vFoto)
            vAcessoSqlServer.AdicionarParametros("@Rg", vAluno.vRg)
            vAcessoSqlServer.AdicionarParametros("@Cpf", vAluno.vCpf)
            vAcessoSqlServer.AdicionarParametros("@DataNascimento", vAluno.vDataNascimento)
            vAcessoSqlServer.AdicionarParametros("@Rua", vAluno.vRua)
            vAcessoSqlServer.AdicionarParametros("@Numero", vAluno.vNumero)
            vAcessoSqlServer.AdicionarParametros("@Complemento", vAluno.vComplemento)
            vAcessoSqlServer.AdicionarParametros("@Apartamento", vAluno.vApartamento)
            vAcessoSqlServer.AdicionarParametros("@Bairro", vAluno.vBairro)
            vAcessoSqlServer.AdicionarParametros("@Cidade", vAluno.vCidade)
            vAcessoSqlServer.AdicionarParametros("@Uf", vAluno.vUf)
            vAcessoSqlServer.AdicionarParametros("@Cep", vAluno.vCep)
            vAcessoSqlServer.AdicionarParametros("@Email", vAluno.vEmail)
            vAcessoSqlServer.AdicionarParametros("@Telcom", vAluno.vTelCom)
            vAcessoSqlServer.AdicionarParametros("@Telcel", vAluno.vTelCel)
            vAcessoSqlServer.AdicionarParametros("@Observacao", vAluno.vObservacao)
            vAcessoSqlServer.AdicionarParametros("@Ativo", vAluno.vAtivo)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function Excluir(vAluno As Aluno) As String
        Try
            vAcessoSqlServer.LimparParametros()
            vAcessoSqlServer.AdicionarParametros("@Codigo", vAluno.vCodigo)
            vAcessoSqlServer.AdicionarParametros("@Acao", 2)
            Return (vAcessoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoCUD")).ToString
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function CarregarConsulta(CodigoNomeProcura As String) As AlunoColecao
        Try
            Dim colecAluno As New AlunoColecao

            vAcessoSqlServer.LimparParametros()

            If IsNumeric(CodigoNomeProcura) Then
                vAcessoSqlServer.AdicionarParametros("@Codigo", CodigoNomeProcura)
            Else
                vAcessoSqlServer.AdicionarParametros("@Nome", CodigoNomeProcura)
            End If

            Dim tabelaAluno As DataTable = vAcessoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspAlunoConsultar")

            For Each linha As DataRow In tabelaAluno.Rows
                Dim aAluno As New Aluno

                aAluno.vCodigo = Convert.ToInt32(linha("alu_cod"))
                aAluno.vNome = Convert.ToString(linha("alu_nome"))
                If linha("alu_datacadastro").ToString = "" Then
                    aAluno.vDataCadastro = Nothing
                Else
                    aAluno.vDataCadastro = Convert.ToDateTime(linha("alu_datacadastro"))
                End If
                aAluno.vFoto = Convert.ToString(linha("alu_foto"))
                aAluno.vRg = Convert.ToString(linha("alu_rg"))
                aAluno.vCpf = Convert.ToString(linha("alu_cpf"))
                If linha("alu_datanascimento").ToString = "" Then
                    aAluno.vDataNascimento = Nothing
                Else
                    aAluno.vDataNascimento = Convert.ToDateTime(linha("alu_datanascimento"))
                End If
                aAluno.vObservacao = Convert.ToString(linha("alu_observacao"))
                aAluno.vAtivo = Convert.ToString(linha("alu_ativo"))
                aAluno.vCodigo = Convert.ToInt32(linha("alu_cod"))
                aAluno.vRua = Convert.ToString(linha("alu_rua"))
                aAluno.vNumero = Convert.ToString(linha("alu_numero"))
                aAluno.vComplemento = Convert.ToString(linha("alu_complemento"))
                aAluno.vApartamento = Convert.ToString(linha("alu_apartamento"))
                aAluno.vBairro = Convert.ToString(linha("alu_bairro"))
                aAluno.vCidade = Convert.ToString(linha("alu_cidade"))
                aAluno.vUf = Convert.ToString(linha("alu_uf"))
                aAluno.vCep = Convert.ToString(linha("alu_cep"))
                aAluno.vEmail = Convert.ToString(linha("alu_email"))
                aAluno.vTelCom = Convert.ToString(linha("alu_telcom"))
                aAluno.vTelCel = Convert.ToString(linha("alu_telcel"))
                colecAluno.Add(aAluno)
            Next

            Return colecAluno
        Catch ex As Exception
            Throw New Exception("Não foi possível carregar suas anotações. Detalhes: " & ex.Message)
        End Try
    End Function

End Class