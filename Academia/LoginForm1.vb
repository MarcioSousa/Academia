Public Class LoginForm1
    Dim snomefoto(0) As String

    Private Sub verificando_cadastro()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()
        comando.CommandText = "SELECT * FROM acesso ORDER BY id_acc"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader
        leitor.Read()
        If leitor("id_acc") = 1 Then
            If txtUsuario.Text = leitor("nome_acc") Then
                If txtSenha.Text = leitor("vers_acc") Then
                    MessageBox.Show("Versão para avaliação, adquira agora mesmo seu produto acessando o email: marciofrapeso@gmail.com!", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    frm_principal.Show()
                    Me.Close()
                    Exit Sub
                Else
                    MessageBox.Show("Senha incorreta! Digite novamente", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtSenha.Text = ""
                    txtSenha.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Nome incorreto! Digite novamente", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtUsuario.Text = ""
                txtUsuario.Focus()
                Exit Sub
            End If
        Else
            If leitor("chave_acc") = "3DLJK6YI8U" Then
                If txtUsuario.Text = leitor("nome_acc") Then
                    If txtSenha.Text = leitor("vers_acc") Then
                        frm_principal.Show()
                        Me.Close()
                        Exit Sub
                    Else
                        MessageBox.Show("Senha incorreta! Digite novamente", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtSenha.Text = ""
                        txtSenha.Focus()
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("Nome incorreto! Digite novamente", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtUsuario.Text = ""
                    txtUsuario.Focus()
                    Exit Sub
                End If
            End If
        End If

        con.Close()

    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        verificando_cadastro()
    End Sub

    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Deletando_fotos_sistema()
        Dim t As Integer = 0
        Dim vpassou As Boolean = False

        '==================================================================================
        '=======================PEGANDO NOME DAS FOTOS DO ARRAY============================
        '==================================================================================
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()
        comando.CommandText = "select foto_cli From clientes"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader

        Do While leitor.Read()
            ReDim Preserve snomefoto(t)
            snomefoto(t) = "C:\FotosCadas\" & (leitor("foto_cli")) & ".png"
            t += 1
        Loop
        con.Close()

        '===============================================================================================
        '========================================== DELETANDO DA PASTA =================================
        '===============================================================================================

        Dim vqtdefotos = My.Computer.FileSystem.GetFiles("C:\FotosCadas\").Count

        If My.Computer.FileSystem.DirectoryExists("C:\FotosCadas") Then
            For Each arquivos As String In My.Computer.FileSystem.GetFiles("C:\FotosCadas\", FileIO.SearchOption.SearchAllSubDirectories)
                For t = 0 To t - 1
                    If arquivos = snomefoto(t) Then
                        vpassou = True
                    End If
                Next
                If vpassou = False Then
                    My.Computer.FileSystem.DeleteFile(arquivos)
                End If
                vpassou = False
            Next

        End If
    End Sub

    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Deletando_fotos_sistema()
    End Sub

    Private Sub btnPrimeiroUso_Click(sender As System.Object, e As System.EventArgs) Handles btnPrimeiroUso.Click
        frm_PrimAcess.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As String

        If MessageBox.Show("Deseja limpar o acesso? Lembrando que retirando o acesso não terá mais permissão para conectar aos cadastros de seus clientes!", "Cuidado!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

            con.Open()
            comando.CommandText = "DELETE FROM acesso"
            comando.CommandType = CommandType.Text
            comando.Connection = con
            leitor = comando.ExecuteNonQuery

            con.Close()
        End If


    End Sub

End Class
