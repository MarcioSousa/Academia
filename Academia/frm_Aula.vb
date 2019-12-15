Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Aula

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        dgvAulas.AutoGenerateColumns = False
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub carrega_comboboxProfessor()
        Dim vFuncProfessor As New FuncionarioNegocio
        Dim vFuncColecao As New FuncionarioColecao

        vFuncColecao = vFuncProfessor.Carregar

        cbxProfessor.DataSource = vFuncColecao

        cbxProfessor.ValueMember = "vCodigo"
        cbxProfessor.DisplayMember = "vNome"

        cbxProfessor.SelectedIndex = -1
    End Sub

    Private Sub abre_campos()
        txtAula.ReadOnly = False
        txtCategoria.ReadOnly = False
        dtpInicio.Enabled = True
        txtPreco.ReadOnly = False

        cbxProfessor.Enabled = True

        btnIniciarFoto.Enabled = True
        btnLimpaFoto.Enabled = True
        btnPastaFoto.Enabled = True
        btnTirarFoto.Enabled = False

        btnConfirmar.Enabled = True
        btnCancela.Enabled = True
        btnLimpa.Enabled = True
        btnFuncionarioLimpa.Enabled = True
        btnFuncionarioMais.Enabled = True

        dgvAulas.Enabled = False

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        txtAula.Focus()
    End Sub

    Private Sub limpa_campos()
        txtAula.Text = ""
        txtCategoria.Text = ""
        txtPreco.Text = ""

        dtpInicio.Value = Today.Date
        pbxFoto.Image = Image.FromFile(Application.StartupPath & "\semimagem.png")
    End Sub

    Private Sub carrega_aulas()
        Dim vAulaNegocios As New AulaNegocio
        Dim vAulaColecao As New AulaColecao

        vAulaColecao = vAulaNegocios.CarregarConsulta

        dgvAulas.DataSource = Nothing
        dgvAulas.DataSource = vAulaColecao

        dgvAulas.Update()
        dgvAulas.Refresh()

        If dgvAulas.Rows.Count > 0 Then
            btnExcluir.Enabled = True
            btnEditar.Enabled = True
        Else
            btnExcluir.Enabled = False
            btnEditar.Enabled = False
            limpa_campos()
            txtCodAulas.Text = ""
        End If
    End Sub

    Private Sub encerra_campos()
        txtAula.ReadOnly = True
        txtCategoria.ReadOnly = True
        cbxProfessor.Enabled = False
        dtpInicio.Enabled = False
        txtPreco.ReadOnly = True

        btnIniciarFoto.Enabled = False
        btnLimpaFoto.Enabled = False
        btnPastaFoto.Enabled = False
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False

        btnConfirmar.Enabled = False
        btnCancela.Enabled = False
        btnLimpa.Enabled = False
        btnFuncionarioLimpa.Enabled = False
        btnFuncionarioMais.Enabled = False

        dgvAulas.Enabled = True

        btnAdicionar.Enabled = True

        If dgvAulas.Rows.Count > 0 Then
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        End If

    End Sub

    Private Sub carrega_campos()
        carrega_comboboxProfessor()

        If dgvAulas.Rows.Count > 0 Then
            txtCodAulas.Text = dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(0).Value
            txtAula.Text = dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(1).Value
            txtCategoria.Text = dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(2).Value
            dtpInicio.Value = dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(3).Value
            cbxProfessor.Text = dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(5).Value
            txtPreco.Text = String.Format("{0:F2}", dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(6).Value)
            pbxFoto.Image = CarregaFoto.carregaFoto(dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(8).Value, "fotosaulas")
        Else
            limpa_campos()
            txtCodAulas.Text = ""
        End If

    End Sub

    Private Sub frm_CadAula_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub dgvAulas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAulas.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub btnIniciarFoto_Click(sender As Object, e As EventArgs) Handles btnIniciarFoto.Click
        Camera.LigarCamera(pbxFoto)
        btnIniciarFoto.Enabled = False
        btnTirarFoto.Enabled = True
        btnCancelaFoto.Enabled = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        abre_campos()
    End Sub

    Private Sub btnTirarFoto_Click(sender As Object, e As EventArgs) Handles btnTirarFoto.Click
        Camera.CongelaImagem(pbxFoto)
        Camera.EncerrarCamera()
        btnIniciarFoto.Enabled = True
        btnTirarFoto.Enabled = False
        btnCancelaFoto.Enabled = False
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        abre_campos()
        limpa_campos()

        carrega_comboboxProfessor()

        txtCodAulas.Text = ""
    End Sub

    Private Sub btnLimpaFoto_Click(sender As Object, e As EventArgs) Handles btnLimpaFoto.Click
        btnIniciarFoto.Enabled = True
        btnTirarFoto.Enabled = False
        btnCancelaFoto.Enabled = False
        Camera.EncerrarCamera()
        pbxFoto.Image = Image.FromFile(Application.StartupPath & "\semimagem.png")
    End Sub

    Private Sub btnPastaFoto_Click(sender As Object, e As EventArgs) Handles btnPastaFoto.Click
        btnIniciarFoto.Enabled = True
        btnTirarFoto.Enabled = False
        btnCancelaFoto.Enabled = False
        Camera.EncerrarCamera()
        OpenFileDialog1.InitialDirectory() = My.Computer.FileSystem.SpecialDirectories.MyPictures
        MessageBox.Show("O ideal é a imagem ser do tamanho de 640 x 480 pixels.", "Tamanho da Imagem...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            pbxFoto.Load(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Camera.EncerrarCamera()
        cbxProfessor.DataSource = Nothing
        carrega_campos()
        encerra_campos()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim vAula As New Aula
        Dim vAulaNegocio As New AulaNegocio
        Dim vVerificaPreco As Double
        Dim vRetorno As String

        Camera.EncerrarCamera()
        Try
            vVerificaPreco = txtPreco.Text

            If txtCodAulas.Text = "" Then
                '======================= NOVO CADASTRO ===============
                vAula.vNome = txtAula.Text
                vAula.vCategoria = txtCategoria.Text

                If cbxProfessor.Text = "" Then
                    vAula.vCodigoFuncionario = 0
                Else
                    vAula.vCodigoFuncionario = cbxProfessor.SelectedValue
                End If
                vAula.vInicio = dtpInicio.Value
                vAula.vPreco = txtPreco.Text
                vAula.vFoto = Camera.SalvaFoto(pbxFoto, "fotosaulas")
                vAula.vAtivo = "s"

                vRetorno = vAulaNegocio.Inserir(vAula)
                Dim idAula As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Aula inserida com Sucesso. Código: " & idAula, "Aula Inserido...")
            Else
                '====================== EDIÇÃO CADASTRO ==============
                vAula.vCodigo = txtCodAulas.Text
                vAula.vNome = txtAula.Text
                vAula.vCategoria = txtCategoria.Text
                MessageBox.Show(cbxProfessor.Text)
                If cbxProfessor.Text = "" Then
                    vAula.vCodigoFuncionario = 0
                Else
                    vAula.vCodigoFuncionario = cbxProfessor.SelectedValue
                End If
                vAula.vInicio = dtpInicio.Value
                vAula.vPreco = txtPreco.Text
                vAula.vFoto = Camera.SalvaFoto(pbxFoto, "fotosaulas")
                vAula.vAtivo = "s"

                vRetorno = vAulaNegocio.Alterar(vAula)
                Dim idAula As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Aula alterada com Sucesso. Código: " & idAula, "Aula Alterada...")

            End If
            carrega_aulas()
            encerra_campos()
        Catch ex As Exception
            MessageBox.Show("Não foi possível cadastrar a Aula. Aviso: " & ex.Message, "Aviso...")
            txtPreco.Focus()
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim vAulaNegocio As New AulaNegocio
        Dim vAula As New Aula
        Dim vRetorno As String

        Try
            If MessageBox.Show("Exclusão de Aula:" & vbCrLf & dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(1).Value & vbCrLf & vbCrLf & "Deseja realmente excluir a aula citada acima?", "Exclusão de Aula...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                vAula.vCodigo = dgvAulas.Rows(dgvAulas.CurrentRow.Index).Cells(0).Value
                vRetorno = vAulaNegocio.Excluir(vAula)

                Dim idFuncionario As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Funcionário excluido com sucesso de seu Sistema!", "Exclusão Finalizada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_aulas()
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível fazer a Exclusão da Aula selecionada!", "Exclusão Cancelada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limpa_campos()
        txtAula.Focus()
    End Sub

    Private Sub frm_CadAula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_aulas()
        carrega_campos()
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        Me.Close()
    End Sub

    Private Sub txtPreco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPreco.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnFuncionario_Click(sender As Object, e As EventArgs) Handles btnFuncionarioMais.Click
        frm_Funcionario.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnDuvida_Click(sender As Object, e As EventArgs) Handles btnDuvida.Click
        MessageBox.Show("Este é um formulário para cadastro de Aulas que há no estabelecimento. " & vbCrLf & "Aqui você tira ou procura uma foto em seu computador para por como mostruário de Aulas" & vbCrLf & "Na aba 'Professor', Escolha um professor que estará dando a Aula cadastrada, caso não haja o Professor nessa lista, clique no botão de 'mais' logo ao lado, ou, deixe o mesmo vazio clicando no botão de 'limpar' ao lado do botão de 'mais'." & vbCrLf & "Nesse formulário você pode alterar, adicionar, excluir Aula de seu sistema, podendo assim ter mais rapidez na hora de cadastrar uma aula a um cliente!" & vbCrLf & vbCrLf & "Obrigado por usar o Sistema...", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnFuncionarioLimpa_Click(sender As Object, e As EventArgs) Handles btnFuncionarioLimpa.Click
        cbxProfessor.SelectedIndex = -1
    End Sub

    Private Sub btnCancelaFoto_Click(sender As Object, e As EventArgs) Handles btnCancelaFoto.Click
        Camera.EncerrarCamera()
        btnIniciarFoto.Enabled = True
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False
    End Sub

End Class