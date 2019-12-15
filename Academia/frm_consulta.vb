Imports MySql.Data.MySqlClient

Public Class frm_consulta
    Dim passou As Boolean = False

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frm_consulta_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_compras.Enabled = True
        frm_compras.mtbCPF.Visible = True
        frm_compras.cbxModalidades.Visible = True
        frm_compras.cbxPacote.Visible = True
    End Sub

    Private Sub frm_consulta_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()

        comando.CommandText = "SELECT cod_cli, nome_cli, cpf_cli FROM clientes"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Try
            leitor = comando.ExecuteReader
            Do While leitor.Read
                dgvConsulta.Rows.Add(leitor("cod_cli"), leitor("nome_cli"), leitor("cpf_cli"))
            Loop
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
        End Try

        txtNome.Focus()

    End Sub

    Private Sub txtNome_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNome.TextChanged
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        dgvConsulta.Rows.Clear()

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()

        comando.CommandText = "SELECT cod_cli, nome_cli, cpf_cli FROM clientes WHERE nome_cli like '%" & txtNome.Text & "%'"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Try
            leitor = comando.ExecuteReader
            Do While leitor.Read
                dgvConsulta.Rows.Add(leitor("cod_cli"), leitor("nome_cli"), leitor("cpf_cli"))
                passou = True
            Loop
            con.Close()

            If passou = False Then
                If txtNome.Text = "" Then
                    con.Open()
                    comando.CommandText = "SELECT cod_cli, nome_cli, cpf_cli FROM clientes"
                    comando.CommandType = CommandType.Text
                    comando.Connection = con

                    leitor = comando.ExecuteReader
                    Do While leitor.Read
                        dgvConsulta.Rows.Add(leitor("cod_cli"), leitor("nome_cli"), leitor("cpf_cli"))
                    Loop
                    con.Close()
                End If
            End If

        Catch ex As Exception
            If txtNome.Text <> "" Then
                If passou = False Then
                    passou = True
                    MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                    txtNome.Text = ""
                End If
            End If
        End Try

        passou = False

    End Sub

    Private Sub btnSelecionar_Click(sender As System.Object, e As System.EventArgs) Handles btnSelecionar.Click
        Dim linha As Integer = dgvConsulta.CurrentRow.Index
        Dim valor As Integer = dgvConsulta.Rows(linha).Cells(0).Value

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()

        comando.CommandText = "SELECT cod_cli, nome_cli, cpf_cli, foto_cli FROM clientes WHERE cod_cli = " & valor
        comando.CommandType = CommandType.Text
        comando.Connection = con

        leitor = comando.ExecuteReader
        leitor.Read()

        frm_compras.txtCodCli.Text = leitor("cod_cli")
        frm_compras.txtNome.Text = leitor("nome_cli")
        frm_compras.mtbCPF.Text = leitor("cpf_cli")
        frm_compras.carrega_grid()

        If My.Computer.FileSystem.FileExists("C:\FotosCadas\" & leitor("foto_cli") & ".png") Then
            frm_compras.pbxCliente.Image = Image.FromFile("C:\FotosCadas\" & leitor("foto_cli") & ".png")
        End If

        con.Close()

        Me.Close()

    End Sub

End Class