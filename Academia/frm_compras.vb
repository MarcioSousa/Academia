
Public Class frm_compras
    Dim passou As Boolean = False
    Dim vCPFcheio As Boolean = False
    Dim controle As String = ""
    Dim vgravar As Boolean = True
    Dim vDataConvertido As String = ""
    Dim vcadastroduplo As Boolean = False
    Dim gridvazio As Boolean = False
    Dim iniciaalteracao As Boolean = False
    Dim vescolha As String = ""

    Private Sub btnAlterar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnAlterar.MouseHover
        btnAlterar.SendToBack()
    End Sub
    Private Sub btnExcluir_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnExcluir.MouseHover
        btnExcluir.SendToBack()
    End Sub
    Private Sub btnConfirmar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.MouseHover
        btnConfirmar.SendToBack()
    End Sub
    Private Sub btnCancelar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnCancelar.MouseHover
        btnCancelar.SendToBack()
    End Sub
    Private Sub btnFechar_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnFechar.MouseHover
        btnFechar.SendToBack()
    End Sub
    Private Sub btnNovo_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnNovo.MouseHover
        btnNovo.SendToBack()
    End Sub
    Private Sub btnAlterar1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnAlterar1.MouseLeave
        btnAlterar.BringToFront()
    End Sub
    Private Sub btnExcluir1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnExcluir1.MouseLeave
        btnExcluir.BringToFront()
    End Sub
    Private Sub btnConfirmar1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnConfirmar1.MouseLeave
        btnConfirmar.BringToFront()
    End Sub
    Private Sub btnCancelar1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnCancelar1.MouseLeave
        btnCancelar.BringToFront()
    End Sub
    Private Sub btnFechar1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnFechar1.MouseLeave
        btnFechar.BringToFront()
    End Sub
    Private Sub btnNovo2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles btnNovo2.MouseLeave
        btnNovo.BringToFront()
    End Sub

    Private Sub abrindo_exclusao()
        btnAlterar.Visible = False
        btnAlterar1.Visible = False
        btnExcluir.Visible = False
        btnExcluir1.Enabled = False
        btnFechar.Visible = False
        btnFechar1.Visible = False
        btnNovo.Visible = False
        btnNovo2.Visible = False

        btnConfirmar.Visible = True
        btnConfirmar1.Visible = True
        btnCancelar.Visible = True
        btnCancelar1.Visible = True
    End Sub
    Private Sub alteracao_fecha_campos()
        btnConfirmar.Visible = False
        btnConfirmar1.Visible = False
        btnExcluir.Visible = False
        btnExcluir1.Visible = False
        btnFechar.Visible = False
        btnFechar1.Visible = False
        btnConfirmar.Visible = True
        btnConfirmar1.Visible = True
        btnCancelar.Visible = True
        btnCancelar1.Visible = True
        btnAlterar.Enabled = False
        btnAlterar1.Visible = True
        btnNovo.Visible = False
        btnNovo2.Visible = False
        btn3.Enabled = False

        txtNome.Enabled = False
        txtCodCli.Enabled = False
        mtbCPF.Enabled = False
    End Sub
    Private Sub carregando_campos()
        Dim linha As Integer = dgvServicos.CurrentRow.Index
        Dim valor As Integer = dgvServicos.Rows(linha).Cells(0).Value

        iniciaalteracao = True

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        Dim passou As Boolean = False

        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        con.Open()
        comando.CommandText = "SELECT A.cod_cli, A.cod_com, M.nome_mod, P.nome_pac, P.VALORS_PAC, A.dt_matric FROM (((compras A INNER JOIN clientes C ON A.cod_cli = C.cod_cli) INNER JOIN modalidades M ON A.cod_mod = M.id_mod) INNER JOIN pacotes P ON A.cod_pac = P.id_pac) WHERE cod_com = " & valor
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader

        leitor.Read()
        cbxModalidades.SelectedItem = leitor("nome_mod")
        cbxPacote.SelectedItem = leitor("nome_pac")
        txtpreco.Text = String.Format("{0:c}", leitor("VALORS_PAC"))
        passou = True

        con.Close()

        passou = False
        gridvazio = False

    End Sub
    Private Sub grid_comcadastro()
        btnAlterar.Visible = True
        btnAlterar1.Visible = True
        btnExcluir.Visible = True
        btnExcluir1.Visible = True
        btnCancelar.Visible = True
        btnCancelar1.Visible = True
        btnConfirmar.Visible = True
        btnConfirmar1.Visible = True
    End Sub
    Private Sub grid_vazio()
        btnAlterar.Visible = False
        btnAlterar1.Visible = False
        btnExcluir.Visible = False
        btnExcluir1.Visible = False
        btnCancelar.Visible = False
        btnCancelar1.Visible = False
        btnConfirmar.Visible = False
        btnConfirmar1.Visible = False
    End Sub
    Public Sub carrega_grid()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        Dim passou As Boolean = False

        dgvServicos.Rows.Clear()

        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        If txtCodCli.Text <> "" Then
            con.Open()
            comando.CommandText = "SELECT A.cod_cli, A.cod_com, M.nome_mod, P.nome_pac, P.VALORS_PAC, A.dt_matric FROM (((compras A INNER JOIN clientes C ON A.cod_cli = C.cod_cli) INNER JOIN modalidades M ON A.cod_mod = M.id_mod) INNER JOIN pacotes P ON A.cod_pac = P.id_pac) WHERE A.cod_cli = " & txtCodCli.Text & " ORDER BY cod_com"
            comando.CommandType = CommandType.Text
            comando.Connection = con
            leitor = comando.ExecuteReader

            Do While leitor.Read
                txtCompra.Text = leitor("cod_com")
                dgvServicos.Rows.Add(leitor("cod_com"), leitor("nome_mod"), leitor("nome_pac"), String.Format(("{0:c}"), leitor("VALORS_PAC")), String.Format(leitor("dt_matric")))
                passou = True
            Loop

            If passou = False Then
                gridvazio = True
                grid_vazio()
            Else
                btnAlterar.Visible = True
                btnAlterar1.Visible = True
                btnExcluir.Visible = True
                btnExcluir1.Visible = True
            End If

            con.Close()

            passou = False
        End If

        gridvazio = False

    End Sub
    Private Sub verificando_campos()
        If txtNome.Text = "" Then
            vgravar = False
            MessageBox.Show("Nenhum cliente foi selecionado!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbxModalidades.Text = "" Then
            vgravar = False
            MessageBox.Show("Nenhum cliente foi selecionado!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf cbxPacote.Text = "" Then
            vgravar = False
            MessageBox.Show("Nenhum cliente foi selecionado!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub convertendo_datas()
        Dim vdata As Date
        Dim vdia As Integer
        Dim vmes As Integer
        Dim vano As Integer
        vdata = Today.Date
        vdia = vdata.Day
        vmes = vdata.Month
        vano = vdata.Year

        vDataConvertido = vano & "-" & vmes & "-" & vdia
    End Sub
    Private Sub carrega_combomodalidade()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
        con.Open()

        comando.CommandText = "SELECT nome_mod FROM modalidades"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        leitor = comando.ExecuteReader

        Do While leitor.Read
            cbxModalidades.Items.Add(leitor("nome_mod"))
        Loop

        con.Close()
    End Sub
    Private Sub verificando_cadastros_duplos()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        Dim t As Integer = 0

        convertendo_datas()

        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
        con.Open()

        comando.CommandText = "SELECT A.cod_cli, M.nome_mod, P.nome_pac, P.VALORS_PAC, A.dt_matric FROM (((compras A INNER JOIN clientes C ON A.cod_cli = C.cod_cli) INNER JOIN modalidades M ON A.cod_mod = M.id_mod) INNER JOIN pacotes P ON A.cod_pac = P.id_pac) WHERE A.cod_cli = " & txtCodCli.Text
        comando.CommandType = CommandType.Text
        comando.Connection = con

        leitor = comando.ExecuteReader

        Do While leitor.Read
            If dgvServicos.Rows(t).Cells(1).Value = cbxModalidades.Text Then
                If dgvServicos.Rows(t).Cells(2).Value = cbxPacote.Text Then
                    MessageBox.Show("Já há um serviço para esse cadastro!!", "Duplo Serviço", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cbxPacote.Items.Clear()
                    cbxModalidades.Items.Clear()
                    txtpreco.Text = ""
                    carrega_combomodalidade()
                    cbxModalidades.Focus()
                    vcadastroduplo = True
                    Exit Do
                End If
            End If
            t += 1
        Loop

        con.Close()

    End Sub
    Private Sub gravando_banco()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As String

        convertendo_datas()

        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
        con.Open()

        comando.CommandText = "INSERT INTO compras VALUES(null," & txtCompra.Text & ",(SELECT id_mod FROM MODALIDADES WHERE nome_mod = '" & cbxModalidades.Text & "'),(SELECT id_pac FROM pacotes WHERE nome_pac = '" & cbxPacote.Text & "' AND cod_mod_pac = (SELECT id_mod from modalidades WHERE nome_mod = '" & cbxModalidades.Text & "')), '" & vDataConvertido & "')"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        leitor = comando.ExecuteNonQuery
        con.Close()

        carrega_grid()

    End Sub

    Private Sub criando_pagamentos()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As String
        Dim vdata As Date = Now
        Dim vdatahoje As Date = Now
        Dim adata As String = ""

        '=================================
        '=================================

        Dim adia As Integer
        Dim ames As Integer
        Dim aano As Integer
        vdatahoje.AddDays(30)

        adia = vdatahoje.Day
        ames = vdatahoje.Month
        aano = vdatahoje.Year

        adata = aano & "-" & ames & "-" & adia

        '=================================
        '=================================

        convertendo_datas()
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        For t = 0 To 1
            If t = 0 Then
                con.Open()
                '========================================= CODIGO DO CLIENTE NÃO ESTÁ CERTO =======================================
                '============================================= É CÓDIGO DA COMPRA =================================================
                comando.CommandText = "INSERT INTO pagamentos VALUES(Not Null," & txtCodCli.Text & ",'" & adata & "','" & vDataConvertido & "',1.02,1.00,'não',0.00)"
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteNonQuery
                con.Close()
            Else
                vdata = vdata.AddDays(30)

                con.Open()
                comando.CommandText = "INSERT INTO pagamentos VALUES(Not Null," & txtCodCli.Text & ",'" & adata & "','" & vDataConvertido & "',1.02,1.00,'não',0.00)"
                comando.Connection = con
                leitor = comando.ExecuteNonQuery
                con.Close()
            End If
        Next

    End Sub

    Private Sub frm_compras_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.Enabled = True
    End Sub

    Private Sub btnFechar1_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar1.Click
        Me.Close()
    End Sub
    Private Sub btnFechar_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnCancelar1_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar1.Click
        txtpreco.Text = ""
        cbxPacote.Items.Clear()
        cbxModalidades.Items.Clear()
        carrega_combomodalidade()

        iniciaalteracao = False
        txtNome.Enabled = True
        txtCodCli.Enabled = True
        mtbCPF.Enabled = True
        btnConfirmar.Visible = False
        btnConfirmar1.Visible = False
        btnCancelar.Visible = False
        btnCancelar1.Visible = False
        btnExcluir.Visible = True
        btnExcluir1.Visible = True
        btnExcluir.Enabled = True
        btnExcluir1.Enabled = True
        btnAlterar.Visible = True
        btnAlterar.Enabled = True

        btnNovo.Visible = True
        btnNovo2.Visible = True
        btnFechar.Visible = True
        btnFechar1.Visible = True
    End Sub
    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        txtpreco.Text = ""
        cbxPacote.Items.Clear()
        cbxModalidades.Items.Clear()
        carrega_combomodalidade()

        iniciaalteracao = False
        txtNome.Enabled = True
        txtCodCli.Enabled = True
        mtbCPF.Enabled = True
        btnConfirmar.Visible = False
        btnConfirmar1.Visible = False
        btnCancelar.Visible = False
        btnCancelar1.Visible = False
        btnExcluir.Visible = True
        btnExcluir1.Visible = True
        btnExcluir.Enabled = True
        btnExcluir1.Enabled = True
        btnAlterar.Visible = True
        btnAlterar.Enabled = True

        btnNovo.Visible = True
        btnNovo2.Visible = True
        btnFechar.Visible = True
        btnFechar1.Visible = True
    End Sub

    Private Sub btnConfirmar1_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar1.Click
        Dim linha As Integer = dgvServicos.CurrentRow.Index
        Dim vcodigo As Integer = dgvServicos.Rows(linha).Cells(0).Value

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        convertendo_datas()
        Dim leitor As String
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        If vescolha = "a" Then
            If MessageBox.Show("Deseja trocar a data da Matrícula pela data de Hoje?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                comando.CommandText = "UPDATE compras SET cod_mod = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "'), cod_pac = (SELECT id_pac FROM pacotes WHERE nome_pac = '" & cbxPacote.Text & "' AND cod_mod_pac = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "')), dt_matric = '" & vDataConvertido & "' WHERE cod_com = " & vcodigo
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteNonQuery
                con.Close()
            Else
                con.Open()
                comando.CommandText = "UPDATE compras SET cod_mod = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "'), cod_pac = (SELECT id_pac FROM pacotes WHERE nome_pac = '" & cbxPacote.Text & "' AND cod_mod_pac = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "')) WHERE cod_com = " & vcodigo
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteNonQuery
                con.Close()
            End If

        ElseIf vescolha = "e" Then
            con.Open()
            comando.CommandText = "DELETE FROM compras WHERE cod_com = " & vcodigo
            comando.CommandType = CommandType.Text
            comando.Connection = con
            leitor = comando.ExecuteNonQuery
            con.Close()
        End If

        dgvServicos.Rows.Clear()
        carrega_grid()

        btnAlterar.Visible = True
        btnAlterar1.Visible = True
        btnAlterar.Enabled = True
        btnAlterar1.Enabled = True
        btnExcluir.Visible = True
        btnExcluir1.Visible = True
        btnExcluir.Enabled = True
        btnExcluir1.Enabled = True

        btnNovo.Visible = True
        btnNovo2.Visible = True
        btnFechar.Visible = True
        btnFechar1.Visible = True

        btnConfirmar.Visible = False
        btnConfirmar1.Visible = False
        btnCancelar.Visible = False
        btnCancelar1.Visible = False

        txtpreco.Text = ""
        cbxPacote.Items.Clear()
        cbxModalidades.Items.Clear()
        carrega_combomodalidade()
        txtCodCli.Enabled = True
        mtbCPF.Enabled = True
        vescolha = ""

    End Sub
    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        Dim linha As Integer = dgvServicos.CurrentRow.Index
        Dim vcodigo As Integer = dgvServicos.Rows(linha).Cells(0).Value

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        convertendo_datas()
        Dim leitor As String
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        If vescolha = "a" Then
            If MessageBox.Show("Deseja trocar a data da Matrícula pela data de Hoje?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                con.Open()
                comando.CommandText = "UPDATE compras SET cod_mod = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "'), cod_pac = (SELECT id_pac FROM pacotes WHERE nome_pac = '" & cbxPacote.Text & "' AND cod_mod_pac = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "')), dt_matric = '" & vDataConvertido & "' WHERE cod_com = " & vcodigo
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteNonQuery
                con.Close()
            Else
                con.Open()
                comando.CommandText = "UPDATE compras SET cod_mod = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "'), cod_pac = (SELECT id_pac FROM pacotes WHERE nome_pac = '" & cbxPacote.Text & "' AND cod_mod_pac = (SELECT id_mod FROM modalidades WHERE nome_mod = '" & cbxModalidades.Text & "')) WHERE cod_com = " & vcodigo
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteNonQuery
                con.Close()
            End If

        ElseIf vescolha = "e" Then
            con.Open()
            comando.CommandText = "DELETE FROM compras WHERE cod_com = " & vcodigo
            comando.CommandType = CommandType.Text
            comando.Connection = con
            leitor = comando.ExecuteNonQuery
            con.Close()
        End If

        dgvServicos.Rows.Clear()
        carrega_grid()

        btnAlterar.Visible = True
        btnAlterar1.Visible = True
        btnAlterar.Enabled = True
        btnAlterar1.Enabled = True
        btnExcluir.Visible = True
        btnExcluir1.Visible = True
        btnExcluir.Enabled = True
        btnExcluir1.Enabled = True

        btnNovo.Visible = True
        btnNovo2.Visible = True
        btnFechar.Visible = True
        btnFechar1.Visible = True

        btnConfirmar.Visible = False
        btnConfirmar1.Visible = False
        btnCancelar.Visible = False
        btnCancelar1.Visible = False

        txtpreco.Text = ""
        cbxPacote.Items.Clear()
        cbxModalidades.Items.Clear()
        carrega_combomodalidade()
        txtCodCli.Enabled = True
        mtbCPF.Enabled = True
        vescolha = ""

    End Sub

    Private Sub btnExcluir1_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir1.Click
        abrindo_exclusao()
        vescolha = "e"
    End Sub
    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        abrindo_exclusao()
        vescolha = "e"
    End Sub

    Private Sub btnAlterar1_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar1.Click
        alteracao_fecha_campos()
        iniciaalteracao = True
        carregando_campos()
        vescolha = "a"
    End Sub
    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        alteracao_fecha_campos()
        iniciaalteracao = True
        carregando_campos()
        vescolha = "a"
    End Sub

    Private Sub btnNovo_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo.Click
        verificando_campos()

        If vgravar = True Then
            verificando_cadastros_duplos()
            If vcadastroduplo = False Then
                gravando_banco()
                criando_pagamentos()
            End If
        End If

        vcadastroduplo = False
        vgravar = True
    End Sub
    Private Sub btnNovo2_Click(sender As System.Object, e As System.EventArgs) Handles btnNovo2.Click
        verificando_campos()

        If vgravar = True Then
            verificando_cadastros_duplos()
            If vcadastroduplo = False Then
                gravando_banco()
                criando_pagamentos()
            End If
        End If

        vcadastroduplo = False
        vgravar = True

    End Sub

    Private Sub btn3_Click(sender As System.Object, e As System.EventArgs) Handles btn3.Click
        mtbCPF.Visible = False
        cbxModalidades.Visible = False
        cbxPacote.Visible = False
        frm_consulta.Show()
        Me.Enabled = False
    End Sub

    Private Sub frm_compras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader


        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
        con.Open()

        comando.CommandText = "select nome_mod from modalidades"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        Try
            leitor = comando.ExecuteReader
            Do While leitor.Read()
                cbxModalidades.Items.Add(leitor("nome_mod"))
            Loop
            con.Close()
        Catch ex As Exception
            passou = True
            MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
            txtCodCli.Text = ""
        End Try

        If dgvServicos.Rows.Count = 0 Then
            grid_vazio()
        End If

    End Sub

    Private Sub cbxModalidades_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxModalidades.SelectedIndexChanged
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        cbxPacote.Items.Clear()
        txtpreco.Text = ""
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
        con.Open()

        comando.CommandText = "select nome_pac, nome_mod from pacotes INNER JOIN modalidades ON pacotes.cod_mod_pac = modalidades.id_mod WHERE nome_mod = '" & cbxModalidades.Text & "'"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Try
            leitor = comando.ExecuteReader
            Do While leitor.Read()
                cbxPacote.Items.Add(leitor("nome_pac"))
            Loop
            con.Close()
        Catch ex As Exception
            passou = True
            MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
            txtCodCli.Text = ""
        End Try

    End Sub

    Private Sub cbxPacote_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbxPacote.SelectedIndexChanged
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        txtpreco.Text = ""
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
        con.Open()

        comando.CommandText = "SELECT P.VALORS_PAC FROM pacotes P INNER JOIN modalidades M ON P.cod_mod_pac = M.id_mod WHERE M.nome_mod = '" & cbxModalidades.Text & "' AND P.nome_pac = '" & cbxPacote.Text & "'"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        Try
            leitor = comando.ExecuteReader
            Do While leitor.Read()
                txtpreco.Text = Format(leitor("VALORS_PAC"), "c")
            Loop
            con.Close()
        Catch ex As Exception
            passou = True
            MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
            txtCodCli.Text = ""
        End Try

    End Sub

    Private Sub txtCodCli_GotFocus(sender As Object, e As System.EventArgs) Handles txtCodCli.GotFocus
        controle = "caixatexto"
    End Sub

    Private Sub txtCodCli_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodCli.TextChanged
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        dgvServicos.Rows.Clear()

        If controle = "caixatexto" Then
            con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
            If vCPFcheio = False Then
                con.Open()
                comando.CommandText = "select cod_cli, nome_cli, cpf_cli,foto_cli from clientes WHERE cod_cli = " & txtCodCli.Text
                comando.CommandType = CommandType.Text
                comando.Connection = con

                Try
                    leitor = comando.ExecuteReader
                    If leitor.Read() Then
                        txtCodCli.Text = leitor("cod_cli")
                        txtNome.Text = leitor("nome_cli")
                        mtbCPF.Text = leitor("cpf_cli")
                        If My.Computer.FileSystem.FileExists("C:\FotosCadas\" & leitor("foto_cli") & ".png") Then
                            pbxCliente.Image = Image.FromFile("C:\FotosCadas\" & leitor("foto_cli") & ".png")
                        End If
                    Else
                        txtNome.Text = ""
                        mtbCPF.Text = ""
                        pbxCliente.Image = Nothing
                    End If
                    con.Close()
                Catch ex As Exception
                    If txtCodCli.Text <> "" Then
                        If passou = False Then
                            passou = True
                            con.Close()
                        End If
                    Else
                        txtNome.Text = ""
                        mtbCPF.Text = ""
                        pbxCliente.Image = Nothing
                        btnAlterar.Visible = False
                        btnAlterar1.Visible = False
                        btnExcluir.Visible = False
                        btnExcluir1.Visible = False
                    End If
                End Try

                passou = False

            End If
            carrega_grid()
        End If

    End Sub

    Private Sub mtbCPF_GotFocus(sender As Object, e As System.EventArgs) Handles mtbCPF.GotFocus
        controle = "caixamasked"
    End Sub

    Private Sub mtbCPF_TextChanged(sender As System.Object, e As System.EventArgs) Handles mtbCPF.TextChanged
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        passou = False

        If controle = "caixamasked" Then
            If mtbCPF.Text <> "" Then
                con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
                con.Open()

                comando.CommandText = "SELECT cod_cli, nome_cli, cpf_cli, foto_cli FROM clientes WHERE cpf_cli = '" & mtbCPF.Text & "'"
                comando.CommandType = CommandType.Text
                comando.Connection = con
                Try
                    leitor = comando.ExecuteReader
                    Do While leitor.Read()
                        vCPFcheio = True
                        passou = True
                        txtCodCli.Text = leitor("cod_cli")
                        txtNome.Text = leitor("nome_cli")
                        If My.Computer.FileSystem.FileExists("C:\FotosCadas\" & leitor("foto_cli") & ".png") Then
                            pbxCliente.Image = Image.FromFile("C:\FotosCadas\" & leitor("foto_cli") & ".png")
                        End If
                        cbxModalidades.Focus()
                    Loop
                    If passou = False Then
                        vCPFcheio = True
                        txtNome.Text = ""
                        txtCodCli.Text = ""
                        pbxCliente.Image = Nothing
                    End If
                    con.Close()
                Catch ex As Exception
                    passou = True
                    MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    con.Close()
                    txtCodCli.Text = ""
                End Try
            End If
            passou = False
            vCPFcheio = False
        End If
    End Sub

    Private Sub txtCodCli_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodCli.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvServicos_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles dgvServicos.SelectionChanged
        Dim linha As Integer = dgvServicos.CurrentRow.Index
        Dim valor As Integer = dgvServicos.Rows(linha).Cells(0).Value

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader
        Dim passou As Boolean = False

        If iniciaalteracao = True Then

            con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

            con.Open()
            comando.CommandText = "SELECT A.cod_cli, M.nome_mod, P.nome_pac, P.VALORS_PAC, A.dt_matric FROM (((compras A INNER JOIN clientes C ON A.cod_cli = C.cod_cli) INNER JOIN modalidades M ON A.cod_mod = M.id_mod) INNER JOIN pacotes P ON A.cod_pac = P.id_pac) WHERE A.cod_com = " & valor
            comando.CommandType = CommandType.Text
            comando.Connection = con
            leitor = comando.ExecuteReader

            leitor.Read()

            cbxModalidades.Text = leitor("nome_mod")
            cbxPacote.Text = leitor("nome_pac")
            txtpreco.Text = String.Format(("{0:c}"), leitor("VALORS_PAC"))

            con.Close()

        End If
        iniciaalteracao = False
    End Sub

End Class