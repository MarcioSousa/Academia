Imports MySql.Data.MySqlClient

Public Class frm_modalidades

    Private Sub lendo_dados()
        Try
            Dim vCodigo As Integer = 1
            Dim vContagem As Integer = 1

            Dim con As New MySqlConnection
            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

            con.Open()
            Dim comando As New MySqlCommand
            comando.CommandText = "SELECT * FROM modalidades ORDER BY id_mod"
            comando.CommandType = CommandType.Text
            comando.Connection = con

            Dim leitor As MySqlDataReader
            leitor = comando.ExecuteReader

            Do While leitor.Read
                dgvModalidade.Rows.Add(leitor("id_mod"), leitor("nome_mod"))
                If vCodigo <> leitor("id_mod") Then
                    vCodigo = vContagem
                Else
                    vContagem += 1
                End If
                vCodigo += 1
            Loop

            txtCodMod.Text = vContagem
            txtNome.Text = ""
            txtNome.Focus()
            con.Close()

            If dgvModalidade.Rows.Count = 0 Then
                btnExcluir.Enabled = False
            Else
                btnExcluir.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub frmCadastroModalidade_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If frm_servicos.Enabled = False Then
            frm_servicos.cbxModalidade.Items.Clear()
            frm_servicos.carrega_modalidades()
            frm_servicos.Enabled = True
        Else
            frm_principal.Enabled = True
        End If
    End Sub

    Private Sub frmCadastroModalidade_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lendo_dados()
    End Sub

    Private Sub btnSair_Click(sender As System.Object, e As System.EventArgs) Handles btnSair.Click
        If frm_servicos.Enabled = False Then
            frm_servicos.cbxModalidade.Items.Clear()
            frm_servicos.carrega_modalidades()
            frm_servicos.Enabled = True
        Else
            frm_principal.Enabled = True
        End If

        Me.Close()
    End Sub

    Private Sub btnAdicionar_Click(sender As System.Object, e As System.EventArgs) Handles btnAdicionar.Click
        Try
            If txtNome.Text <> "" Then
                Dim con As New MySqlConnection
                con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

                con.Open()
                Dim comando As New MySqlCommand
                comando.CommandText = "INSERT INTO modalidades VALUES(" & txtCodMod.Text & ",'" & txtNome.Text.ToUpper & "')"
                comando.CommandType = CommandType.Text
                comando.Connection = con

                comando.ExecuteNonQuery()

                con.Close()

                dgvModalidade.Rows.Clear()

                lendo_dados()
            Else
                MessageBox.Show("Campo Modalidade Vazio, Digite uma Modalidade de sua Empresa", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try



    End Sub

    Private Sub excluindo_dados()

        Try
            Dim linha As Integer = dgvModalidade.CurrentRow.Index
            Dim valor As Integer = dgvModalidade.Rows(linha).Cells(0).Value

            If MessageBox.Show("Cadastro de Codigo " & valor & " sendo excluido, deseja excluir permanentemente?", "Cadastro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                Dim con As New MySqlConnection
                con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

                con.Open()
                Dim comando As New MySqlCommand
                comando.CommandText = "DELETE FROM modalidades WHERE id_mod = " & valor
                comando.CommandType = CommandType.Text
                comando.Connection = con

                Dim leitor As String
                leitor = comando.ExecuteNonQuery()

                con.Close()

                dgvModalidade.Rows.Clear()

                lendo_dados()
            End If
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        excluindo_dados()
    End Sub

    Private Sub btnLimpar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpar.Click
        txtNome.Text = ""
    End Sub

End Class