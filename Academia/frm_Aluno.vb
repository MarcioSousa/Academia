Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Aluno

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        '//-----NÃO GERAR LINHAS AUTOMÁTICAS-----
        dgvAlunos.AutoGenerateColumns = False
        'cbxUf.Text = "SP"

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub abre_campos()
        txtNome.ReadOnly = False
        txtRg.ReadOnly = False
        mtbCpf.ReadOnly = False
        txtEndereco.ReadOnly = False
        txtNumero.ReadOnly = False
        txtComplem.ReadOnly = False
        txtApart.ReadOnly = False
        txtBairro.ReadOnly = False
        txtCidade.ReadOnly = False
        mtbCep.ReadOnly = False
        txtEmail.ReadOnly = False
        mtbTelCom.ReadOnly = False
        mtbTelCel.ReadOnly = False
        txtObserv.ReadOnly = False

        dtpNascim.Enabled = True
        cbxUf.Enabled = True

        btnIniciarFoto.Enabled = True
        btnLimpaFoto.Enabled = True
        btnPastaFoto.Enabled = True
        btnPesquisarCep.Enabled = True

        pnlCompleto.Enabled = False

        btnConfirma.Enabled = True
        btnCancela.Enabled = True
        btnLimpa.Enabled = True

        txtNome.Focus()
    End Sub

    Private Sub limpa_campos()
        txtNome.Text = ""
        txtRg.Text = ""
        mtbCpf.Text = ""
        txtEndereco.Text = ""
        txtNumero.Text = ""
        txtComplem.Text = ""
        txtApart.Text = ""
        txtBairro.Text = ""
        txtCidade.Text = ""
        mtbCep.Text = ""
        txtEmail.Text = ""
        mtbTelCom.Text = ""
        mtbTelCel.Text = ""
        txtObserv.Text = ""

        dtpNascim.Value = Today.Date
        cbxUf.Text = "SP"
        pbxFoto.Image = Image.FromFile(Application.StartupPath & "\semimagem.png")
    End Sub

    Private Sub carrega_alunos()
        Dim vAlunoPesquisa As New AlunoNegocios
        Dim vAlunoColecao As New AlunoColecao

        vAlunoColecao = vAlunoPesquisa.CarregarConsulta(txtAlunoPesquisar.Text)

        dgvAlunos.DataSource = Nothing
        dgvAlunos.DataSource = vAlunoColecao

        dgvAlunos.Update()
        dgvAlunos.Refresh()

        If dgvAlunos.Rows.Count > 0 Then
            btnExcluir.Enabled = True
            btnEditar.Enabled = True
        Else
            btnExcluir.Enabled = False
            btnEditar.Enabled = False
            limpa_campos()
            txtCod.Text = ""
        End If
    End Sub

    Private Sub encerra_cadastro()
        txtNome.ReadOnly = True
        txtRg.ReadOnly = True
        mtbCpf.ReadOnly = True
        txtEndereco.ReadOnly = True
        txtNumero.ReadOnly = True
        txtComplem.ReadOnly = True
        txtApart.ReadOnly = True
        txtBairro.ReadOnly = True
        txtCidade.ReadOnly = True
        mtbCep.ReadOnly = True
        txtEmail.ReadOnly = True
        mtbTelCom.ReadOnly = True
        mtbTelCel.ReadOnly = True
        txtObserv.ReadOnly = True

        dtpNascim.Enabled = False
        cbxUf.Enabled = False

        btnIniciarFoto.Enabled = False
        btnLimpaFoto.Enabled = False
        btnPastaFoto.Enabled = False
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False

        btnPesquisarCep.Enabled = False

        pnlCompleto.Enabled = True

        btnConfirma.Enabled = False
        btnCancela.Enabled = False
        btnLimpa.Enabled = False
    End Sub

    Private Sub carrega_campos()

        If dgvAlunos.Rows.Count > 0 Then
            txtCod.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(0).Value
            txtNome.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(1).Value
            dtpCadastro.Value = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(2).Value
            pbxFoto.Image = CarregaFoto.carregaFoto(dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(3).Value, "fotosalunos")
            txtObserv.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(4).Value
            txtRg.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(8).Value
            mtbCpf.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(9).Value
            dtpNascim.Value = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(10).Value
            '--------------------------------ATIVO--------------------------------------
            '------------------------------ENDERECO-------------------------------------
            txtEndereco.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(11).Value
            txtNumero.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(12).Value
            txtComplem.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(13).Value
            txtApart.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(14).Value
            txtBairro.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(15).Value
            txtCidade.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(16).Value
            cbxUf.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(17).Value
            mtbCep.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(18).Value
            '----------------------------CONTATO---------------------------------------
            mtbTelCom.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(6).Value
            mtbTelCel.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(7).Value
            txtEmail.Text = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(19).Value
        Else
            limpa_campos()
            txtCod.Text = ""
        End If

    End Sub

    Private Sub frm_CadCliente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
        Camera.EncerrarCamera()
    End Sub

    Private Sub btnPesquisaAluno_Click(sender As Object, e As EventArgs) Handles btnPesquisaAluno.Click
        carrega_alunos()
    End Sub

    Private Sub dgvAlunos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAlunos.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciarFoto.Click
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

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        abre_campos()
        limpa_campos()
        txtCod.Text = ""
    End Sub

    Private Sub btnPesquisarCep_Click(sender As Object, e As EventArgs) Handles btnPesquisarCep.Click
        Dim verifCep As New CodEndPostal

        Try

            If verifCep.ProcuraCep(mtbCep.Text) = True Then
                txtEndereco.Text = verifCep.vEndereco
                txtBairro.Text = verifCep.vBairro
                txtCidade.Text = verifCep.vCidade
                cbxUf.Text = verifCep.vUf
                txtNumero.Focus()
            Else
                txtEndereco.Text = ""
                txtBairro.Text = ""
                txtCidade.Text = ""
                cbxUf.Text = "SP"
                mtbCep.Text = ""
                mtbCep.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Verifique o Sistema: " & ex.Message)
        End Try

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
        carrega_campos()
        encerra_cadastro()
    End Sub

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        Dim vAluno As New Aluno
        Dim vAlunoNegocio As New AlunoNegocios
        Dim vRetorno As String

        Camera.EncerrarCamera()

        Try
            If txtCod.Text = "" Then
                '======================= NOVO CADASTRO ===============
                vAluno.vNome = txtNome.Text
                vAluno.vCpf = mtbCpf.Text
                vAluno.vRg = txtRg.Text
                vAluno.vDataNascimento = dtpNascim.Value
                vAluno.vFoto = Camera.SalvaFoto(pbxFoto, "fotosalunos")
                vAluno.vRua = txtEndereco.Text
                vAluno.vNumero = txtNumero.Text
                vAluno.vComplemento = txtComplem.Text
                vAluno.vApartamento = txtApart.Text
                vAluno.vBairro = txtBairro.Text
                vAluno.vCidade = txtCidade.Text
                vAluno.vUf = cbxUf.Text
                vAluno.vCep = mtbCep.Text
                vAluno.vEmail = txtEmail.Text
                vAluno.vTelCom = mtbTelCom.Text
                vAluno.vTelCel = mtbTelCel.Text
                vAluno.vObservacao = txtObserv.Text

                vRetorno = vAlunoNegocio.Inserir(vAluno)

                Dim idAluno As Integer = Convert.ToInt32(vRetorno)

                MessageBox.Show("Aluno inserido com Sucesso. Código: " & idAluno.ToString, "Aluno Inserido...")
            Else
                '====================== EDIÇÃO CADASTRO ==============
                vAluno.vCodigo = txtCod.Text
                vAluno.vNome = txtNome.Text
                vAluno.vCpf = mtbCpf.Text
                vAluno.vRg = txtRg.Text
                vAluno.vDataNascimento = dtpNascim.Value
                vAluno.vFoto = Camera.SalvaFoto(pbxFoto, "fotosalunos")
                vAluno.vRua = txtEndereco.Text
                vAluno.vNumero = txtNumero.Text
                vAluno.vComplemento = txtComplem.Text
                vAluno.vApartamento = txtApart.Text
                vAluno.vBairro = txtBairro.Text
                vAluno.vCidade = txtCidade.Text
                vAluno.vUf = cbxUf.Text
                vAluno.vCep = mtbCep.Text
                vAluno.vEmail = txtEmail.Text
                vAluno.vTelCom = mtbTelCom.Text
                vAluno.vTelCel = mtbTelCel.Text
                vAluno.vObservacao = txtObserv.Text

                vRetorno = vAlunoNegocio.Alterar(vAluno)

                Dim idAluno As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Aluno alterado com Sucesso. Código: " & idAluno.ToString, "Aluno Alterado...")
            End If
            carrega_alunos()
            encerra_cadastro()
        Catch ex As Exception
            MessageBox.Show("Não foi possível cadastrar o Cliente. Aviso: " & ex.Message)
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim vAlunoNegocio As New AlunoNegocios
        Dim vAluno As New Aluno
        Dim vRetorno As String

        Try
            If MessageBox.Show("Exclusão do Aluno:" & vbCrLf & dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(1).Value & vbCrLf & vbCrLf & "Deseja realmente excluir o aluno citado acima?", "Exclusão de Aluno...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                vAluno.vCodigo = dgvAlunos.Rows(dgvAlunos.CurrentRow.Index).Cells(0).Value
                vRetorno = vAlunoNegocio.Excluir(vAluno)

                Dim idAluno As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Aluno excluido com sucesso de seu Sistema!", "Exclusão Finalizada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_alunos()
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível fazer a Exclusão do Aluno selecionado!", "Exclusão Cancelada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limpa_campos()
        txtNome.Focus()
    End Sub

    Private Sub frm_CadAluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_alunos()
    End Sub

    Private Sub btnInicial_Click(sender As Object, e As EventArgs) Handles btnInicial.Click
        Me.Close()
    End Sub

    Private Sub btnAjuda_Click(sender As Object, e As EventArgs) Handles btnAjuda.Click
        MessageBox.Show("Este é um formulário para cadastro, edição, exclusão ou pesquisa de algum Aluno de seu Sistema." & vbCrLf & "No campo logo acima da lista de Alunos, digite o código ou nome do aluno na qual quer fazer a pesquisa e clique no botão logo a frente do campo." & vbCrLf & vbCrLf & "Há também alguns botões: " & vbCrLf & "-Início - Volta ao formulário principal do Sistema." & vbCrLf & "-Dúvidas - Abre essa Janela com dicas de como usar o Sistema." & vbCrLf & "-Cadastrar - Nesse botão inicia-se um novo cadastro de um Aluno, dando acesso aos campos do lado direito do formulário." & vbCrLf & "-Editar - Faz a edição de um determinado Aluno selecionado no campo acima." & vbCrLf & "-Excluir - Faz a exclusão do cliente selecionado no campo acima." & vbCrLf & vbCrLf & "Obrigado por usar o Sistema...", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAjudadois_Click(sender As Object, e As EventArgs) Handles btnAjudadois.Click
        MessageBox.Show("Este é um formulário para cadastro, edição, exclusão ou pesquisa de algum Aluno de seu Sistema." & vbCrLf & "Nos campos acima é mostrado todo cadastro de um determinado Aluno selecionado do lado esquerdo do formulário." & vbCrLf & vbCrLf & "Ao cadastrar um Aluno, você tem a opção de tirar, salvar, pesquisar, apagar ou não uma foto do mesmo clicando nos botões do lado direito do campo de foto podendo ou não salvar em seu computador." & vbCrLf & "Logo abaixo terá os campos de endereço, na qual pode-se optar em digitar manualmente todos os campos, ou simplesmente preenchendo o campo 'CEP' e clicando no botão ao lado do campo, fazendo com que preencha automaticamente alguns campos com o endereço correto do Aluno." & vbCrLf & vbCrLf & "Há também alguns botões: " & vbCrLf & "-Dúvidas - Abre essa Janela com dicas de como usar o Sistema." & vbCrLf & "-Limpar - Limpa todos os campos acima." & vbCrLf & "-Confirmar - Confirma o cadastro ou a edição de um Aluno." & vbCrLf & "-Cancelar - Cancela o cadastro ou a edição de um Aluno." & vbCrLf & vbCrLf & "Obrigado por usar o Sistema...", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancelaFoto_Click(sender As Object, e As EventArgs) Handles btnCancelaFoto.Click
        Camera.EncerrarCamera()
        btnIniciarFoto.Enabled = True
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False
    End Sub

End Class