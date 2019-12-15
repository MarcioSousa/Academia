Imports MySql.Data.MySqlClient

Public Class frm_PrimAcess
    Dim vdata As String
    Dim passou As Boolean

    Private Sub convertendo_data()
        Dim vdia As Integer
        Dim vmes As Integer
        Dim vano As Integer
        vdia = Date.Today.Day
        vmes = Date.Today.Month
        vano = Date.Today.Year
        vdata = vano & "-" & vmes & "-" & vdia
    End Sub

    Private Sub verificando_campos()
        If txtUsuario.Text = "" Then
            MessageBox.Show("Nome do usuário Vazio. Digite o nome do usuário!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Focus()
            passou = True
            Exit Sub
        ElseIf txtSenha.Text = "" Then
            MessageBox.Show("Senha Vazio. Digite uma senha no campo Senha!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSenha.Focus()
            passou = True
            Exit Sub
        ElseIf txtConfiSenha.Text = "" Then
            MessageBox.Show("Campo Confirmação da Senha vazio. Confime a Senha anterior!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtConfiSenha.Focus()
            passou = True
            Exit Sub
        ElseIf txtLicença.Text = "" Then
            MessageBox.Show("Campo de Licença Vazio. Digite a licença do produto ou clique em Demo!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtLicença.Focus()
            passou = True
            Exit Sub
        ElseIf txtSenha.Text <> txtConfiSenha.Text Then
            MessageBox.Show("Confirmação de Senha não coincide com a Senha acima. Digite novamente a senha e a confirmação de sua senha!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtSenha.Text = ""
            txtConfiSenha.Text = ""
            txtSenha.Focus()
            passou = True
            Exit Sub
        End If

    End Sub

    Private Sub btnDemo_Click(sender As System.Object, e As System.EventArgs) Handles btnDemo.Click
        txtLicença.Text = "ABCDE12345"
    End Sub

    Private Sub btnCadastrar_Click(sender As System.Object, e As System.EventArgs) Handles btnCadastrar.Click
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As String
        convertendo_data()
        verificando_campos()

        If passou = False Then
            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

            If txtLicença.Text = "ABCDE12345" Then
                Try
                    con.Open()
                    comando.CommandText = "INSERT INTO acesso VALUES(1,'" & txtSenha.Text & "','" & txtLicença.Text & "','" & vdata & "','" & txtUsuario.Text & "')"
                    comando.CommandType = CommandType.Text
                    comando.Connection = con
                    leitor = comando.ExecuteNonQuery
                Catch ex As Exception
                    MessageBox.Show("Cadastro já existente!", "Aviso de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                con.Close()
            ElseIf txtLicença.Text = "3DLJK6YI8U" Then
                Try
                    con.Open()
                    comando.CommandText = "INSERT INTO acesso VALUES(2,'" & txtSenha.Text & "','" & txtLicença.Text & "','2020-31-12','" & txtUsuario.Text & "')"
                    comando.CommandType = CommandType.Text
                    comando.Connection = con
                    leitor = comando.ExecuteNonQuery
                Catch ex As Exception
                    MessageBox.Show("Cadastro já existente!", "Aviso de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try

                con.Close()
            End If
        End If
        passou = False
    End Sub

    Private Sub btnLimpar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpar.Click
        txtUsuario.Text = ""
        txtSenha.Text = ""
        txtConfiSenha.Text = ""
        txtLicença.Text = ""
    End Sub

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frm_PrimAcess_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm1.Enabled = True
    End Sub

End Class