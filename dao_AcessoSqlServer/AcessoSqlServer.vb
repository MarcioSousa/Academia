Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class AcessoSqlServer
    '//Cria conexão
    Private Function CriarConexao() As SqlConnection
        Return New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\Marcio Sousa\Documents\Visual Studio 2013\Projects\Academia\Academia\Academia.mdf';Integrated Security=True;Connect Timeout=30")
        'Return New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename='" & Application.StartupPath & "\Academia.mdf';Integrated Security=True;Connect Timeout=30")
    End Function

    '//Parâmetros que vão  para o Banco
    Private colecaoParametros As SqlParameterCollection = New SqlCommand().Parameters
    Public Sub LimparParametros()
        colecaoParametros.Clear()
    End Sub
    Public Sub AdicionarParametros(nomeParametro As String, valorParametro As Object)
        colecaoParametros.Add(New SqlParameter(nomeParametro, valorParametro))
    End Sub

    '//Persistência - Inserir, Alterar, Excluir
    Public Function ExecutarManipulacao(tipocomando As CommandType, nomeProcedure As String) As Object
        Try
            '//Criar a conexão
            Dim conexao As SqlConnection = CriarConexao()
            '//Abre Conexão
            conexao.Open()
            '//Cria o comando que vai levar a inoformação para o banco.
            Dim comando As SqlCommand = conexao.CreateCommand()
            '//Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = nomeProcedure
            comando.CommandTimeout = 7200 '//7200 Segundos, equivale a 2 Horas

            '//Adicionar os parâmetros no comando
            For Each parametros As SqlParameter In colecaoParametros
                comando.Parameters.Add(New SqlParameter(parametros.ParameterName, parametros.Value))
            Next

            '//Executar o comando, ou seja, mandar o comando ir até o banco de dados
            Return comando.ExecuteScalar
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    '//Consultar registros do banco de dados
    Public Function ExecutarConsulta(tipocomando As CommandType, nomeProcedure As String) As DataTable
        Try
            '//Criar a conexão
            Dim conexao As SqlConnection = CriarConexao()
            '//Abre Conexão
            conexao.Open()
            '//Cria o comando que vai levar a inoformação para o banco.
            Dim comando As SqlCommand = conexao.CreateCommand()
            '//Colocando as coisas dentro do comando (dentro da caixa que vai trafegar na conexão)
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = nomeProcedure
            comando.CommandTimeout = 7200 '//7200 Segundos, equivale a 2 Horas

            '//Adicionar os parâmetros no comando
            For Each parametros As SqlParameter In colecaoParametros
                comando.Parameters.Add(New SqlParameter(parametros.ParameterName, parametros.Value))
            Next

            '//Cria adaptador
            Dim adaptador As SqlDataAdapter = New SqlDataAdapter(comando)
            '//DataTable = Tabela de Dados vazia onde vou colocar os dados que vem do banco
            Dim tabela As DataTable = New DataTable
            '//Mandar o comando ir até o banco buscar os dados e o adaptador para preencher o datatable
            adaptador.Fill(tabela)

            Return tabela
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
