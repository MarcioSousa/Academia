Public Class frm_servicos
    Dim aModalidades(0) As String
    Dim aPassou As Boolean = False
    Dim codModalidade As Integer
    Dim vPassouModalid As Boolean = False
    Dim mEscolha As String

    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        frm_principal.Enabled = True
        Me.Close()
    End Sub

    Private Sub frmCadastroPacote_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.Enabled = True
    End Sub

    Private Sub fechando_campos()
        dgvPacotes.Enabled = True
        cbxModalidade.Enabled = False
        txtPacote.Enabled = False
        txtValorSocio.Enabled = False
        btnConfirmar.Visible = False
        btnCancelar.Visible = False
        btnDeletar.Visible = True
        btnAlterar.Visible = True
        btnNovo.Visible = True
        btnAdd.Visible = False
    End Sub

    Private Sub carrega_grid_pacote()
        dgvPacotes.Enabled = True
        dgvPacotes.Rows.Clear()

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "SELECT A.ID_PAC, B.nome_mod, A.nome_pac, A.VALORS_PAC FROM pacotes A INNER JOIN modalidades B  ON B.id_mod = A.COD_MOD_PAC ORDER BY ID_PAC"
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader

            Do While leitor.Read
                mEscolha = ""
                dgvPacotes.Rows.Add(leitor("ID_PAC"), leitor("nome_mod"), leitor("nome_pac"), String.Format("{0:c}", leitor("VALORS_PAC")))
            Loop

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmCadastroPacote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_modalidades()
        carrega_grid_pacote()
        fechando_campos()

        If dgvPacotes.Rows.Count = 0 Then
            btnAlterar.Visible = False
            btnDeletar.Visible = False
        End If

    End Sub

    Private Sub dgvPacotes_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvPacotes.SelectionChanged
        Dim linha As Integer = dgvPacotes.CurrentRow.Index
        Dim valor As Integer = dgvPacotes.Rows(linha).Cells(0).Value

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "SELECT A.ID_PAC, A.NOME_PAC, B.nome_mod, A.VALORS_PAC FROM pacotes A INNER JOIN modalidades B ON B.id_mod = A.COD_MOD_PAC WHERE ID_PAC = " & valor
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader
            leitor.Read()

            If mEscolha <> "D" Then
                txtCodPac.Text = valor
                cbxModalidade.Text = leitor("nome_mod")
                txtPacote.Text = leitor("NOME_PAC")
                txtValorSocio.Text = String.Format("{0:f2}", leitor("VALORS_PAC"))
            End If


            con.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub abrindo_campos()
        cbxModalidade.Enabled = True
        txtPacote.Enabled = True
        txtValorSocio.Enabled = True
        dgvPacotes.Enabled = False
        btnAlterar.Visible = False
        btnNovo.Visible = False
        btnDeletar.Visible = False
        btnConfirmar.Visible = True
        btnCancelar.Visible = True
        btnAdd.Visible = True
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        mEscolha = "A"
        abrindo_campos()
        carrega_modalidades()
    End Sub

    Public Sub carrega_modalidades()
        Dim t As Integer = 0
        cbxModalidade.Items.Clear()

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "SELECT *FROM modalidades"
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader

            Do While leitor.Read
                ReDim Preserve aModalidades(t)
                cbxModalidade.Items.Add(leitor("nome_mod"))
                aModalidades(t) = leitor("nome_mod")
                t += 1
            Loop

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try


    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        carrega_grid_pacote()
        fechando_campos()
        btnDeletar.Visible = True
        btnAlterar.Visible = True
        btnNovo.Visible = True
        If dgvPacotes.Rows.Count = 0 Then
            limpando_campos()
            txtCodPac.Text = ""
            btnDeletar.Visible = False
            btnAlterar.Visible = False
        End If
    End Sub

    Private Sub alterando_valores()

        Try
            Dim vValorSocio As String
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As String

            vValorSocio = Val(txtValorSocio.Text.Replace(",", "."))

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "UPDATE pacotes SET COD_MOD_PAC = " & codModalidade & ", NOME_PAC = '" & txtPacote.Text.ToUpper & "', VALORS_PAC = " & vValorSocio & " WHERE ID_PAC = " & txtCodPac.Text
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteNonQuery

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub verificando_disponibilidade()

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            aPassou = True
            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "SELECT A.ID_PAC, B.nome_mod, B.id_mod, A.NOME_PAC, A.VALORS_PAC FROM pacotes A INNER JOIN modalidades B ON B.id_mod = A.COD_MOD_PAC WHERE ID_PAC <> 4 ORDER BY ID_PAC"
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader

            Do While leitor.Read
                If cbxModalidade.Text.ToUpper = leitor("nome_mod") Then
                    If txtPacote.Text.ToUpper = leitor("NOME_PAC") Then

                        If txtValorSocio.Text = leitor("VALORS_PAC") Then
                            aPassou = False
                            MessageBox.Show("Já existe cadastro com as informações acima!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Do
                        End If
                    End If
                End If
                aPassou = True
            Loop

            con.Close()


        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            aPassou = False
        End Try

    End Sub

    Private Sub verificando_modalidade()

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "SELECT * FROM Modalidades"
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader

            Do While leitor.Read
                If leitor("nome_mod") = cbxModalidade.Text Then
                    codModalidade = leitor("id_mod")
                    vPassouModalid = True
                    Exit Do
                End If
            Loop

            con.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            aPassou = False
        End Try

    End Sub

    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        verificando_modalidade()
        If vPassouModalid = False Then
            MessageBox.Show("Essa modalidade não há em seu cadastro. Cadastre antes algumas Modalidades ou entre em contato com um técnico para mais informações!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        verificando_disponibilidade()

        If aPassou = True Then
            If mEscolha = "A" Then
                alterando_valores()
            ElseIf mEscolha = "N" Then
                gravando_novos_dados()
            End If
            carrega_grid_pacote()
            fechando_campos()
        End If

    End Sub

    Private Sub deletando_Pacotes()

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As String

            If MessageBox.Show("Deseja Deletar de seus arquivos o Pacote de Código " & txtCodPac.Text & "?", "Cadastro de Clientes", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
                con.Open()

                comando.CommandText = "DELETE FROM pacotes WHERE ID_PAC = " & txtCodPac.Text
                comando.CommandType = CommandType.Text

                comando.Connection = con
                leitor = comando.ExecuteNonQuery

                con.Close()
                MessageBox.Show("Pacote com o Código de Número " & txtCodPac.Text & " Deletado com sucesso!!", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                carrega_grid_pacote()
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnDeletar_Click(sender As System.Object, e As System.EventArgs) Handles btnDeletar.Click
        mEscolha = "D"
        deletando_Pacotes()
        If dgvPacotes.Rows.Count = 0 Then
            btnAlterar.Visible = False
            btnDeletar.Visible = False
        End If
    End Sub

    Private Sub gravando_novos_dados()

        Try
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "INSERT INTO pacotes values(" & txtCodPac.Text & "," & codModalidade & ",'" & txtPacote.Text.ToUpper & "'," & Val(txtValorSocio.Text.Replace(",", ".")) & ")"
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub codigos_disponivel()
        Dim cont As Integer = 1

        Try
            txtCodPac.Text = ""
            Dim con As New MySqlConnection
            Dim comando As New MySqlCommand
            Dim leitor As MySqlDataReader

            con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
            con.Open()

            comando.CommandText = "SELECT ID_PAC FROM pacotes ORDER BY ID_PAC"
            comando.CommandType = CommandType.Text

            comando.Connection = con
            leitor = comando.ExecuteReader

            Do While leitor.Read
                If leitor("ID_PAC") <> cont Then
                    txtCodPac.Text = cont
                    Exit Do
                End If
                cont += 1
            Loop

            If txtCodPac.Text = "" Then
                txtCodPac.Text = cont
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show("Erro ao acessar Banco de Dados... Entre em contato com o fabricante do software pelo site: https://www.facebook.com/pages/Dr-Hardware/385320148204842?ref_type=bookmark", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        mEscolha = "N"
        codigos_disponivel()
        carrega_modalidades()
        limpando_campos()
        abrindo_campos()
    End Sub

    Private Sub limpando_campos()
        cbxModalidade.Text = ""
        txtPacote.Text = ""
        txtValorSocio.Text = ""
    End Sub

    Private Sub txtValorSocio_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtValorSocio.KeyPress

        If Char.IsPunctuation(e.KeyChar) Then
            If e.KeyChar <> "," Then
                e.Handled = True
                Exit Sub
            Else
                e.Handled = False
                Exit Sub
            End If
        End If


        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtValorNSocio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsPunctuation(e.KeyChar) Then
            If e.KeyChar <> "," Then
                e.Handled = True
                Exit Sub
            Else
                e.Handled = False
                Exit Sub
            End If
        End If


        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        frm_modalidades.Show()
        Me.Enabled = False
    End Sub

End Class