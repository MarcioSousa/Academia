Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Funcionario

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        dgvFuncionarios.AutoGenerateColumns = False
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub abre_campos()
        txtNome.ReadOnly = False
        txtCargo.ReadOnly = False
        txtPagamento.ReadOnly = False
        dtpEntrada.Enabled = True
        dtpSaida.Enabled = True

        btnIniciarFoto.Enabled = True
        btnLimpaFoto.Enabled = True
        btnPastaFoto.Enabled = True
        btnTirarFoto.Enabled = True

        btnConfirma.Enabled = True
        btnCancela.Enabled = True
        btnLimpa.Enabled = True

        btnNovo.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        dgvFuncionarios.Enabled = False

        txtNome.Focus()
    End Sub

    Private Sub limpa_campos()
        txtNome.Text = ""
        txtCargo.Text = ""
        txtPagamento.Text = ""

        dtpEntrada.Value = Today.Date
        dtpSaida.Value = Today.Date

        pbxFoto.Image = Image.FromFile(Application.StartupPath & "\semimagem.png")
    End Sub

    Private Sub carrega_funcionarios()
        Dim vFuncionarioNegocios As New FuncionarioNegocio
        Dim vFuncionarioColecao As New FuncionarioColecao

        vFuncionarioColecao = vFuncionarioNegocios.Carregar()

        dgvFuncionarios.DataSource = Nothing
        dgvFuncionarios.DataSource = vFuncionarioColecao

        dgvFuncionarios.Update()
        dgvFuncionarios.Refresh()

        If dgvFuncionarios.Rows.Count > 0 Then
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
        txtCargo.ReadOnly = True
        txtPagamento.ReadOnly = True
        dtpEntrada.Enabled = False
        dtpSaida.Enabled = False

        btnIniciarFoto.Enabled = False
        btnLimpaFoto.Enabled = False
        btnPastaFoto.Enabled = False
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False

        btnConfirma.Enabled = False
        btnCancela.Enabled = False
        btnLimpa.Enabled = False

        dgvFuncionarios.Enabled = True

        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
    End Sub

    Private Sub carrega_campos()
        If dgvFuncionarios.Rows.Count > 0 Then
            txtCod.Text = dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(0).Value
            txtNome.Text = dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(1).Value
            txtCargo.Text = dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(2).Value
            dtpEntrada.Value = dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(3).Value
            dtpSaida.Text = dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(4).Value
            txtPagamento.Text = String.Format("{0:F2}", dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(5).Value)
            pbxFoto.Image = CarregaFoto.carregaFoto(dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(7).Value, "fotosfuncionarios")

        Else
            limpa_campos()
            txtCod.Text = ""
        End If
    End Sub

    Private Sub frm_CadFuncionario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If frm_Aula.Enabled = False Then
            frm_Aula.Enabled = True
            frm_Aula.carrega_comboboxProfessor()
        Else
            frm_Principal.Enabled = True
            Camera.EncerrarCamera()
        End If
    End Sub

    Private Sub dgvFuncionarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFuncionarios.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        abre_campos()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        abre_campos()
        limpa_campos()
        txtCod.Text = ""
    End Sub

    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        Camera.EncerrarCamera()
        carrega_campos()
        encerra_cadastro()
    End Sub

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        Dim vFuncionario As New Funcionario
        Dim vFuncionarioNegocio As New FuncionarioNegocio
        Dim vRetorno As String

        Camera.EncerrarCamera()
        Try
            If txtCod.Text = "" Then
                '======================= NOVO CADASTRO ===============
                vFuncionario.vNome = txtNome.Text
                vFuncionario.vCargo = txtCargo.Text
                vFuncionario.vPagamento = txtPagamento.Text.Replace(",", ".")
                vFuncionario.vDataEntrada = dtpEntrada.Value
                vFuncionario.vDataSaida = dtpSaida.Value
                vFuncionario.vFoto = Camera.SalvaFoto(pbxFoto, "fotosfuncionarios")

                vRetorno = vFuncionarioNegocio.Inserir(vFuncionario)

                Dim idFuncionario As Integer = Convert.ToInt32(vRetorno)

                MessageBox.Show("Funcionário(a) inserido com Sucesso. Código: " & idFuncionario, "Funcionário Inserido...")
            Else
                '====================== EDIÇÃO CADASTRO ==============
                vFuncionario.vCodigo = txtCod.Text
                vFuncionario.vNome = txtNome.Text
                vFuncionario.vCargo = txtCargo.Text
                vFuncionario.vPagamento = txtPagamento.Text
                vFuncionario.vDataEntrada = dtpEntrada.Value
                vFuncionario.vDataSaida = dtpSaida.Value
                vFuncionario.vFoto = Camera.SalvaFoto(pbxFoto, "fotosfuncionarios")

                vRetorno = vFuncionarioNegocio.Alterar(vFuncionario)

                Dim idFuncionario As Integer = Convert.ToInt32(vRetorno)

                MessageBox.Show("Funcionário(a) alterado com Sucesso. Código: " & idFuncionario, "Funcionário Alterado...")
            End If
            carrega_funcionarios()
            encerra_cadastro()
        Catch ex As Exception
            MessageBox.Show("Não foi possível cadastrar o Funcionário. Aviso: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim vFuncionarioNegocio As New FuncionarioNegocio
        Dim vFuncionario As New Funcionario
        Dim vRetorno As String

        Try
            If MessageBox.Show("Exclusão do Funcionário:" & vbCrLf & dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(1).Value & vbCrLf & vbCrLf & "Deseja realmente excluir o funcionário citado acima?", "Exclusão de Funcionário...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                vFuncionario.vCodigo = dgvFuncionarios.Rows(dgvFuncionarios.CurrentRow.Index).Cells(0).Value
                vRetorno = vFuncionarioNegocio.Excluir(vFuncionario)

                Dim idFuncionario As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Funcionário excluido com sucesso de seu Sistema!", "Exclusão Finalizada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_funcionarios()
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível fazer a Exclusão do Funcionário selecionado!", "Exclusão Cancelada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limpa_campos()
        txtNome.Focus()
    End Sub

    Private Sub frm_CadFuncionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_funcionarios()
    End Sub

    Private Sub btnInicial_Click(sender As Object, e As EventArgs) Handles btnInicial.Click
        Me.Close()
    End Sub

    Private Sub btnAjuda_Click(sender As Object, e As EventArgs) Handles btnAjuda.Click
        MessageBox.Show("Este é um formulário para cadastro, edição ou exclusão de algum Funcionário de seu estabelecimento.", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtPagamento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagamento.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancelaFoto_Click(sender As Object, e As EventArgs) Handles btnCancelaFoto.Click
        Camera.EncerrarCamera()
        btnIniciarFoto.Enabled = True
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False
    End Sub

    Private Sub btnIniciarFoto_Click(sender As Object, e As EventArgs) Handles btnIniciarFoto.Click
        Camera.LigarCamera(pbxFoto)
        btnIniciarFoto.Enabled = False
        btnTirarFoto.Enabled = True
        btnCancelaFoto.Enabled = True
    End Sub

    Private Sub btnTirarFoto_Click(sender As Object, e As EventArgs) Handles btnTirarFoto.Click
        Camera.CongelaImagem(pbxFoto)
        Camera.EncerrarCamera()
        btnIniciarFoto.Enabled = True
        btnTirarFoto.Enabled = False
        btnCancelaFoto.Enabled = False
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

End Class