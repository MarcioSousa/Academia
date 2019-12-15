Imports MySql.Data.MySqlClient

Public Class frm_clientes
    Public vImagem As Boolean = False
    Dim codigofoto As String
    Dim zerocadastro As Boolean
    Dim verificacao As Boolean

    Dim adatacad As String
    Dim adatanasc As String
    Dim codigocliente As Integer = 1
    Dim vescolha As String

    Private Sub novo_codigo()
        Dim passou As Boolean = False
        Dim con As New MySqlConnection

        codigocliente = 1
        txtCodigo.Enabled = False
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "SELECT cod_cli FROM clientes order by cod_cli"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As MySqlDataReader
        leitor = comando.ExecuteReader

        Do While leitor.Read
            If leitor("cod_cli") <> codigocliente Then
                txtCodigo.Text = codigocliente
                passou = True
                Exit Do
            End If
            codigocliente += 1
        Loop

        If passou = False Then
            txtCodigo.Text = codigocliente
        End If

        con.Close()
    End Sub

    Private Sub recarrega_campos()
        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "SELECT * FROM Clientes WHERE cod_cli = (SELECT MIN(cod_cli) FROM clientes)"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As MySqlDataReader
        leitor = comando.ExecuteReader
        leitor.Read()
        txtCodigo.Text = leitor("cod_cli")
        txtNome.Text = leitor("nome_cli")
        mtbCep.Text = leitor("cep_cli")
        dtpDataCad.Value = leitor("datacad_cli")
        txtRua.Text = leitor("rua_cli")
        txtNum.Text = leitor("num_cli")
        txtApart.Text = leitor("apart_cli")
        txtBairro.Text = leitor("bairro_cli")
        txtCidade.Text = leitor("cidade_cli")
        cmbEstado.Text = leitor("estado_cli")
        txtEmail.Text = leitor("email_cli")
        mtbCpf.Text = leitor("cpf_cli")
        txtRg.Text = leitor("rg_cli")
        dtpDataNasc.Value = leitor("datanasc_cli")
        mtbTelCom.Text = leitor("telcom_cli")
        mtbTelRes.Text = leitor("telres_cli")
        mtbTelCel.Text = leitor("telcel_cli")

        con.Close()
    End Sub

    Private Sub voltando_campos()
        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "SELECT * FROM clientes WHERE cod_cli = " & txtCodigo.Text
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As MySqlDataReader
        leitor = comando.ExecuteReader
        leitor.Read()
        txtCodigo.Text = leitor("cod_cli")
        txtNome.Text = leitor("nome_cli")
        mtbCep.Text = leitor("cep_cli")
        dtpDataCad.Value = leitor("datacad_cli")
        txtRua.Text = leitor("rua_cli")
        txtNum.Text = leitor("num_cli")
        txtApart.Text = leitor("apart_cli")
        txtBairro.Text = leitor("bairro_cli")
        txtCidade.Text = leitor("cidade_cli")
        cmbEstado.Text = leitor("estado_cli")
        txtEmail.Text = leitor("email_cli")
        mtbCpf.Text = leitor("cpf_cli")
        txtRg.Text = leitor("rg_cli")
        dtpDataNasc.Value = leitor("datanasc_cli")
        mtbTelCom.Text = leitor("telcom_cli")
        mtbTelRes.Text = leitor("telres_cli")
        mtbTelCel.Text = leitor("telcel_cli")
        carrega_foto()
        con.Close()
    End Sub

    Private Sub carrega_campos()
        zerocadastro = True

        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

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
            txtRua.Text = leitor("rua_cli")
            txtNum.Text = leitor("num_cli")
            txtApart.Text = leitor("apart_cli")
            txtBairro.Text = leitor("bairro_cli")
            txtCidade.Text = leitor("cidade_cli")
            cmbEstado.Text = leitor("estado_cli")
            txtEmail.Text = leitor("email_cli")
            mtbCpf.Text = leitor("cpf_cli")
            txtRg.Text = leitor("rg_cli")
            dtpDataNasc.Value = leitor("datanasc_cli")
            mtbTelCom.Text = leitor("telcom_cli")
            mtbTelRes.Text = leitor("telres_cli")
            mtbTelCel.Text = leitor("telcel_cli")
            carrega_foto()
            zerocadastro = False
            Exit Do
        Loop

        If zerocadastro = True Then
            fechando_todo_conteudo()
        End If

        con.Close()
    End Sub

    Private Sub fechando_todo_conteudo()
        txtCodigo.Text = 0
        txtNome.Text = ""
        mtbCep.Text = ""
        dtpDataCad.Value = Now
        txtRua.Text = ""
        txtNum.Text = ""
        txtApart.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cmbEstado.Text = ""
        txtEmail.Text = ""
        mtbCpf.Text = ""
        txtRg.Text = ""
        dtpDataNasc.Value = Now
        mtbTelCom.Text = ""
        mtbTelRes.Text = ""
        mtbTelCel.Text = ""
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

    Private Sub preenche_campos()
        mtbCep.Text = "12345-678"
        dtpDataCad.Text = "10/12/2010"
        txtRua.Text = "Aldair Silveira"
        txtNum.Text = "2589"
        txtApart.Text = "Apart 52 lote 5"
        txtBairro.Text = "Jardim Eridano"
        txtCidade.Text = "Florianópolis"
        cmbEstado.Text = "SP"
        txtEmail.Text = "hugohugo@gmail.com"
        mtbCpf.Text = "123.456.789-12"
        txtRg.Text = "12.456.789-12"
        dtpDataNasc.Text = "12/12/2010"
        mtbTelCom.Text = "(11) 8596-9669"
        mtbTelRes.Text = "(11) 5421-5211"
        mtbTelCel.Text = "(11)9 5212-3232"
    End Sub

    Private Sub abre_campos()
        txtNome.ReadOnly = False
        mtbCep.ReadOnly = False
        dtpDataCad.Enabled = True
        txtRua.ReadOnly = False
        txtNum.ReadOnly = False
        txtApart.ReadOnly = False
        txtBairro.ReadOnly = False
        txtCidade.ReadOnly = False
        cmbEstado.Enabled = True
        txtEmail.ReadOnly = False
        mtbCpf.ReadOnly = False
        txtRg.ReadOnly = False
        dtpDataNasc.Enabled = True
        mtbTelCom.ReadOnly = False
        mtbTelRes.ReadOnly = False
        mtbTelCel.ReadOnly = False

        btnAntes.Enabled = False
        btnDepois.Enabled = False

        btnOkei.Enabled = False
        txtPesq.Enabled = False

        btnTirarFoto.Enabled = True
        btnLimpar.Enabled = True

        btnIncluir.Enabled = False
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
        btnFechar.Enabled = False

        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub fecha_campos()
        txtNome.ReadOnly = True
        mtbCep.ReadOnly = True
        dtpDataCad.Enabled = False
        txtRua.ReadOnly = True
        txtNum.ReadOnly = True
        txtApart.ReadOnly = True
        txtBairro.ReadOnly = True
        txtCidade.ReadOnly = True
        cmbEstado.Enabled = False
        txtEmail.ReadOnly = True
        mtbCpf.ReadOnly = True
        txtRg.ReadOnly = True
        dtpDataNasc.Enabled = False
        mtbTelCom.ReadOnly = True
        mtbTelRes.ReadOnly = True
        mtbTelCel.ReadOnly = True

        If zerocadastro = False Then
            txtPesq.Enabled = True
            btnOkei.Enabled = True
            btnAlterar.Enabled = True
            btnIncluir.Enabled = True
            btnExcluir.Enabled = True
            btnAntes.Enabled = True
            btnDepois.Enabled = True
        Else
            txtPesq.Enabled = False
            btnOkei.Enabled = False
            btnAlterar.Enabled = False
            btnIncluir.Enabled = True
            btnExcluir.Enabled = False
            btnAntes.Enabled = False
            btnDepois.Enabled = False
        End If

        btnTirarFoto.Enabled = False
        btnLimpar.Enabled = False

        btnFechar.Enabled = True
        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False

    End Sub

    Private Sub limpa_campos()
        txtNome.Text = ""
        mtbCep.Text = ""
        dtpDataCad.Value = Now
        txtRua.Text = ""
        txtNum.Text = ""
        txtApart.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        cmbEstado.Text = ""
        txtEmail.Text = ""
        mtbCpf.Text = ""
        txtRg.Text = ""
        dtpDataNasc.Value = Now
        mtbTelCom.Text = ""
        mtbTelRes.Text = ""
        mtbTelCel.Text = ""
    End Sub

    Private Sub convertendo_datas()
        Dim vdatacad As Date
        Dim vdatanasc As Date

        Dim vdia As Integer
        Dim vmes As Integer
        Dim vano As Integer

        vdatacad = dtpDataCad.Value
        vdia = vdatacad.Date.Day
        vmes = vdatacad.Date.Month
        vano = vdatacad.Date.Year
        adatacad = vano & "-" & vmes & "-" & vdia

        vdatanasc = dtpDataNasc.Value
        vdia = vdatanasc.Date.Day
        vmes = vdatanasc.Date.Month
        vano = vdatanasc.Date.Year
        adatanasc = vano & "-" & vmes & "-" & vdia

    End Sub

    Private Sub novo_cliente()
        convertendo_datas()
        salvando_foto()

        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "INSERT INTO clientes VALUES(" & txtCodigo.Text & ",'" & txtNome.Text & "','" & mtbCep.Text & "','" & adatacad & "','" & txtRua.Text & "','" & txtNum.Text & "','" & txtApart.Text & "','" & txtBairro.Text & "','" & txtCidade.Text & "','" & cmbEstado.Text & "','" & txtEmail.Text & "','" & mtbCpf.Text & "','" & txtRg.Text & "','" & adatanasc & "','" & mtbTelCom.Text & "','" & mtbTelRes.Text & "','" & mtbTelCel.Text & "','" & codigofoto & "')"
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As String
        leitor = comando.ExecuteNonQuery
        txtCodigo.Enabled = True

        con.Close()
    End Sub

    Private Sub proximo_cadastro()
        Dim vulticadastro As Integer
        Dim valorlinha As Integer
        Dim contador As Integer

        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        vescolha = "Z"
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
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

                'SELECT cod_cli FROM clientes WHERE cod_cli = (SELECT MAX(cod_cli) FROM clientes WHERE cod_cli = cod_cli);
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
        txtRua.Text = leitor("rua_cli")
        txtNum.Text = leitor("num_cli")
        txtApart.Text = leitor("apart_cli")
        txtBairro.Text = leitor("bairro_cli")
        txtCidade.Text = leitor("cidade_cli")
        cmbEstado.Text = leitor("estado_cli")
        txtEmail.Text = leitor("email_cli")
        mtbCpf.Text = leitor("cpf_cli")
        txtRg.Text = leitor("rg_cli")
        dtpDataNasc.Value = leitor("datanasc_cli")
        mtbTelCom.Text = leitor("telcom_cli")
        mtbTelRes.Text = leitor("telres_cli")
        mtbTelCel.Text = leitor("telcel_cli")

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
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"
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

        If txtCodigo.Text <> vulticadastro Then
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
        txtRua.Text = leitor("rua_cli")
        txtNum.Text = leitor("num_cli")
        txtApart.Text = leitor("apart_cli")
        txtBairro.Text = leitor("bairro_cli")
        txtCidade.Text = leitor("cidade_cli")
        cmbEstado.Text = leitor("estado_cli")
        txtEmail.Text = leitor("email_cli")
        mtbCpf.Text = leitor("cpf_cli")
        txtRg.Text = leitor("rg_cli")
        dtpDataNasc.Value = leitor("datanasc_cli")
        mtbTelCom.Text = leitor("telcom_cli")
        mtbTelRes.Text = leitor("telres_cli")
        mtbTelCel.Text = leitor("telcel_cli")

        con.Close()
    End Sub

    Private Sub carrega_foto()
        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

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

    Private Sub salvando_foto()

        If pbxCliente.Image IsNot Nothing Then
            codigofoto = Guid.NewGuid().ToString
            pbxCliente.Image.Save("C:\FotosCadas\" & codigofoto & ".png")
        Else
            codigofoto = ""
        End If

    End Sub

    Private Sub alteracao_cadastro()
        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        con.Open()
        Dim comando As New MySqlCommand
        comando.CommandText = "UPDATE clientes SET nome_cli = '" & txtNome.Text & "', cep_cli = '" & mtbCep.Text & "', datacad_cli = '" & adatacad & "', rua_cli = '" & txtRua.Text & "',num_cli = '" & txtNum.Text & "', apart_cli = '" & txtApart.Text & "', bairro_cli = '" & txtBairro.Text & "', cidade_cli = '" & txtCidade.Text & "', estado_cli = '" & cmbEstado.Text & "', email_cli = '" & txtEmail.Text & "',cpf_cli = '" & mtbCpf.Text & "',rg_cli = '" & txtRg.Text & "', datanasc_cli = '" & adatanasc & "', telcom_cli = '" & mtbTelCom.Text & "',telres_cli = '" & mtbTelRes.Text & "',telcel_cli = '" & mtbTelCel.Text & "',foto_cli = '" & codigofoto & "' WHERE cod_cli = " & txtCodigo.Text
        comando.CommandType = CommandType.Text
        comando.Connection = con

        Dim leitor As String
        leitor = comando.ExecuteNonQuery
        con.Close()

    End Sub

    Private Sub apagar_cadastro()
        Dim con As New MySqlConnection
        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

        If MessageBox.Show("Deseja Deletar de seu sistema o cliente selecionado?", "Deletando Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            con.Open()
            Dim comando As New MySqlCommand
            comando.CommandText = "DELETE FROM clientes WHERE cod_cli = " & txtCodigo.Text
            comando.CommandType = CommandType.Text
            comando.Connection = con

            Dim leitor As String
            leitor = comando.ExecuteNonQuery

            con.Close()
            carrega_campos()
        End If

    End Sub

    Private Sub verificando_campos()
        verificacao = True
        If txtNome.Text.Trim = "" Then
            MessageBox.Show("Coloque o Nome do Cliente que será Cadastrado no campo 'Nome do Cliente'!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            verificacao = False
            txtNome.Focus()
        End If
    End Sub

    Private Sub frm_Clientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carrega_campos()
        fecha_campos()
    End Sub

    Private Sub btnTirarFoto_Click(sender As System.Object, e As System.EventArgs) Handles btnTirarFoto.Click
        pbxCliente.Image = Nothing
        Me.Enabled = False
        frm_camera.Show()
    End Sub

    Private Sub btnLimpar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpar.Click
        Me.pbxCliente.Image = Nothing
    End Sub

    Private Sub btnIncluir_Click(sender As System.Object, e As System.EventArgs) Handles btnIncluir.Click
        vescolha = "I"
        novo_codigo()
        limpa_campos()
        abre_campos()
        pbxCliente.Image = Nothing
        btnAntes.Enabled = False
        btnDepois.Enabled = False
        txtNome.Text = ""
        txtNome.Focus()
    End Sub

    Private Sub btnConfirmar_Click(sender As System.Object, e As System.EventArgs) Handles btnConfirmar.Click
        verificando_campos()
        If verificacao = True Then
            zerocadastro = False
            If vescolha = "I" Then
                novo_cliente()
                fecha_campos()
            ElseIf vescolha = "A" Then
                convertendo_datas()
                salvando_foto()
                alteracao_cadastro()
                fecha_campos()
            End If
        End If
    End Sub

    Private Sub btnDepois_Click(sender As System.Object, e As System.EventArgs) Handles btnDepois.Click
        vescolha = "P"
        proximo_cadastro()
        carrega_foto()
        vescolha = ""
    End Sub

    Private Sub btnAntes_Click(sender As System.Object, e As System.EventArgs) Handles btnAntes.Click
        vescolha = "X"
        anterior_cadastro()
        carrega_foto()
        vescolha = ""
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        fecha_campos()

        If vescolha = "I" Then
            carrega_campos()
        ElseIf vescolha = "A" Then
            voltando_campos()
        End If

    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        vescolha = "A"
        abre_campos()
    End Sub

    Private Sub btnOkei_Click(sender As System.Object, e As System.EventArgs) Handles btnOkei.Click
        Dim con As New MySqlConnection
        Dim comando As New MySqlCommand
        Dim leitor As MySqlDataReader

        con.ConnectionString = "server = localhost; user = 'root'; password = 'abcd1234'; database ='academia'"

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
            txtRua.Text = leitor("rua_cli")
            txtNum.Text = leitor("num_cli")
            txtApart.Text = leitor("apart_cli")
            txtBairro.Text = leitor("bairro_cli")
            txtCidade.Text = leitor("cidade_cli")
            cmbEstado.Text = leitor("estado_cli")
            txtEmail.Text = leitor("email_cli")
            mtbCpf.Text = leitor("cpf_cli")
            txtRg.Text = leitor("rg_cli")
            dtpDataNasc.Value = leitor("datanasc_cli")
            mtbTelCom.Text = leitor("telcom_cli")
            mtbTelRes.Text = leitor("telres_cli")
            mtbTelCel.Text = leitor("telcel_cli")
            carrega_foto()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Cliente não encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
            txtPesq.Text = ""
        End Try

    End Sub

    Private Sub txtPesq_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesq.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As System.Object, e As System.EventArgs) Handles btnExcluir.Click
        apagar_cadastro()
    End Sub

    Private Sub btnPrincipal_Click(sender As System.Object, e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frm_Clientes_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_principal.Enabled = True
    End Sub

End Class