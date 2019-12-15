Imports MySql.Data.MySqlClient

Public Class frm_pagamentos
    Dim zerocadastro As Boolean
    Dim vescolha As String
    Dim diajuros As Integer
    Dim vjuros As Decimal

    Private Sub fecha_campos()
        txtNome.ReadOnly = True
        mtbCep.ReadOnly = True
        dtpDataCad.Enabled = False

        If zerocadastro = False Then
            txtPesq.Enabled = True
            btnOkei.Enabled = True
            btnAlterar.Enabled = True
            btnEfetPagam.Enabled = True
            btnExcluir.Enabled = True
            btnAntes.Enabled = True
            btnDepois.Enabled = True
        Else
            txtPesq.Enabled = False
            btnOkei.Enabled = False
            btnAlterar.Enabled = False
            btnEfetPagam.Enabled = True
            btnExcluir.Enabled = False
            btnAntes.Enabled = False
            btnDepois.Enabled = False
        End If

        btnFechar.Enabled = True
        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False

    End Sub

    Private Sub fechando_todo_conteudo()
        txtCodigo.Text = 0
        txtNome.Text = ""
        mtbCep.Text = ""
        dtpDataCad.Value = Now
        pbxCliente.Image = Nothing

        btnAntes.Enabled = False
        btnDepois.Enabled = False

        txtPesq.Enabled = False
        btnOkei.Enabled = False

        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub carrega_campos()
        zerocadastro = True

        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "SELECT * FROM clientes"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As MySqlDataReader
        leitor = comando.ExecuteReader
        Do While leitor.Read
            txtCodigo.Text = leitor("cod_cli")
            txtNome.Text = leitor("nome_cli")
            mtbCep.Text = leitor("cep_cli")
            dtpDataCad.Value = leitor("datacad_cli")
            carrega_foto()
            zerocadastro = False
            Exit Do
        Loop

        If zerocadastro = True Then
            fechando_todo_conteudo()
        End If

        con.Close()
    End Sub

    Private Sub proximo_cadastro()
        Dim vulticadastro As Integer
        Dim valorlinha As Integer
        Dim contador As Integer

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        dgvMensalid.Rows.Clear()
        vescolha = "Z"
        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
        contador = txtCodigo.Text

        con.Open()
        comando.CommandText = "SELECT MAX(cod_cli) FROM clientes"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader
        leitor.Read()
        vulticadastro = leitor("MAX(cod_cli)")
        con.Close()
        '===============================================================================
        '===============================================================================
        '===============================================================================

        If txtCodigo.Text <> vulticadastro Then
            For t = 0 To 1
                con.Open()
                comando.CommandText = "SELECT count(*) FROM clientes where cod_cli = " & contador + 1
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteReader
                leitor.Read()

                If leitor("count(*)") = 1 Then
                    valorlinha = contador
                    con.Close()
                    Exit For
                End If

                contador += 1
                t = -1
                con.Close()
            Next
        End If

        '===============================================================================
        '===============================================================================
        '===============================================================================

        con.Open()

        comando.CommandText = "SELECT * FROM clientes WHERE cod_cli > " & valorlinha & " ORDER BY cod_cli"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        leitor = comando.ExecuteReader
        leitor.Read()
        txtCodigo.Text = leitor("cod_cli")
        txtNome.Text = leitor("nome_cli")
        mtbCep.Text = leitor("cep_cli")
        dtpDataCad.Value = leitor("datacad_cli")

        con.Close()

        carrega_grid()

    End Sub

    Private Sub carrega_grid()
        Dim vdatahoje As Date = Today.Date
        Dim vdatavenc As Date

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()
        comando.CommandText = "SELECT P.cod_pag, C.dt_matric, P.venc_pag, P.dt_pag, P.desc_pag, P.juros, P.efetu_pag from compras C INNER JOIN pagamentos P ON C.cod_com = P.cod_com AND C.cod_cli = " & txtCodigo.Text & " ORDER BY P.efetu_pag"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader

        Do While leitor.Read
            vdatavenc = leitor("venc_pag")
            diajuros = vdatahoje.Subtract(vdatavenc).Days

            If leitor("efetu_pag") = "não" Then
                calcula_juros()
                dgvMensalid.Rows.Add(leitor("cod_pag"), String.Format(leitor("dt_matric")), String.Format(leitor("venc_pag")), String.Format(leitor("dt_pag")), String.Format("{0:c}", leitor("desc_pag")), String.Format("{0:c}", vjuros))
                'lblValorTotal.Text = leitor("")
            Else
                dgvMensalid.Rows.Add(leitor("cod_pag"), String.Format(leitor("dt_matric")), String.Format(leitor("venc_pag")), String.Format(leitor("dt_pag")), leitor("desc_pag"), leitor("juros"), leitor("efetu_pag"))
            End If
        Loop
        con.Close()

    End Sub

    Private Sub calcula_juros()
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()
        comando.CommandText = "SELECT dia_jur, carencia_jur, mes_jur FROM juros"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader
        leitor.Read()

        vjuros = diajuros * leitor("dia_jur")

        If leitor("carencia_jur") < diajuros Then
            If diajuros > 30 Then
                For t = 1 To diajuros Step 30
                    vjuros = vjuros + leitor("mes_jur")
                Next
            End If
        End If

        con.Close()
    End Sub

    Private Sub anterior_cadastro()
        Dim vulticadastro As Integer
        Dim valorlinha As Integer
        Dim contador As Integer
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        vescolha = "Z"
        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"
        contador = txtCodigo.Text

        con.Open()
        comando.CommandText = "SELECT MIN(cod_cli) FROM clientes"
        comando.CommandType = CommandType.Text
        comando.Connection = con
        leitor = comando.ExecuteReader
        leitor.Read()
        vulticadastro = leitor("MIN(cod_cli)")
        con.Close()
        '===========================================================================================================
        '===========================================================================================================
        '===========================================================================================================

        If txtCodigo.Text <> vulticadastro And txtCodigo.Text <> 0 Then
            For t = 0 To 1
                con.Open()
                comando.CommandText = "SELECT count(*) FROM clientes where cod_cli = " & contador - 1
                comando.CommandType = CommandType.Text
                comando.Connection = con
                leitor = comando.ExecuteReader
                leitor.Read()

                If leitor("count(*)") = 1 Then
                    valorlinha = contador
                    con.Close()
                    Exit For
                End If

                contador -= 1
                t = -1
                con.Close()
            Next
        Else
            con.Open()
            comando.CommandText = "SELECT MAX(cod_cli) FROM clientes"
            comando.CommandType = CommandType.Text
            comando.Connection = con
            leitor = comando.ExecuteReader
            leitor.Read()
            valorlinha = leitor("MAX(cod_cli)") + 1
            con.Close()
        End If

        '===========================================================================================================
        '===========================================================================================================
        '===========================================================================================================

        con.Open()

        comando.CommandText = "SELECT * FROM clientes WHERE cod_cli < " & valorlinha & " ORDER BY cod_cli DESC"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        leitor = comando.ExecuteReader
        leitor.Read()
        txtCodigo.Text = leitor("cod_cli")
        txtNome.Text = leitor("nome_cli")
        mtbCep.Text = leitor("cep_cli")
        dtpDataCad.Value = leitor("datacad_cli")

        con.Close()
        carrega_grid()

    End Sub

    Private Sub carrega_foto()
        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "SELECT foto_cli FROM clientes WHERE cod_cli = " & txtCodigo.Text
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As MySqlDataReader
        leitor = comando.ExecuteReader
        leitor.Read()

        If leitor("foto_cli") <> "" Then
            If Not My.Computer.FileSystem.DirectoryExists("C:\FotosCadas") Then
                My.Computer.FileSystem.CreateDirectory("C:\FotosCadas")
            End If

            If My.Computer.FileSystem.FileExists("C:\FotosCadas\" & leitor("foto_Cli") & ".png") Then
                pbxCliente.Image = Image.FromFile("C:\FotosCadas\" & leitor("foto_cli") & ".png")
            End If
        Else
            pbxCliente.Image = Nothing
        End If

        con.Close()

    End Sub

    Private Sub frm_pagamentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fecha_campos()
    End Sub

    Private Sub btnDepois_Click(sender As System.Object, e As System.EventArgs) Handles btnDepois.Click
        If txtCodigo.Text = "" Then
            txtCodigo.Text = 0
        End If

        vescolha = "P"
        proximo_cadastro()
        carrega_foto()
        vescolha = ""
    End Sub

    Private Sub btnAntes_Click(sender As System.Object, e As System.EventArgs) Handles btnAntes.Click
        If txtCodigo.Text = "" Then
            txtCodigo.Text = 0
        End If

        vescolha = "X"
        anterior_cadastro()
        carrega_foto()
        vescolha = ""
    End Sub

    Private Sub btnOkei_Click(sender As System.Object, e As System.EventArgs) Handles btnOkei.Click
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'oicram27'; database ='academia'"

        con.Open()

        comando.CommandText = "SELECT * FROM clientes WHERE cod_cli = " & txtPesq.Text
        comando.CommandType = CommandType.Text
        comando.Connection = con
        Try
            leitor = comando.ExecuteReader
            leitor.Read()
            txtCodigo.Text = leitor("cod_cli")
            txtNome.Text = leitor("nome_cli")
            mtbCep.Text = leitor("cep_cli")
            dtpDataCad.Value = leitor("datacad_cli")
            carrega_foto()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
            txtPesq.Text = ""
            txtPesq.Focus()
        End Try

        carrega_grid()
    End Sub

    Private Sub txtPesq_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesq.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub frm_pagamentos_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.Enabled = True
    End Sub

End Class