Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Produto

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        dgvProdutos.AutoGenerateColumns = False
        dgvVencimento.AutoGenerateColumns = False
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub carrega_comboboxFornecedor()
        Dim vFornecProduto As New FornecedorNegocio
        Dim vFornecColecao As New FornecedorColecao

        vFornecColecao = vFornecProduto.Carregar

        cbxFornecedor.DataSource = vFornecColecao

        cbxFornecedor.ValueMember = "vCodigo"
        cbxFornecedor.DisplayMember = "vNome"
        cbxFornecedor.SelectedIndex = -1
    End Sub

    Public Sub carrega_vencimentos()
        Dim vVencimentoNegocio As New VencimentoNegocio
        Dim vVencimentoColecao As New VencimentoColecao

        vVencimentoColecao = vVencimentoNegocio.CarregarConsulta(dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(0).Value)

        dgvVencimento.DataSource = Nothing
        dgvVencimento.DataSource = vVencimentoColecao

        dgvVencimento.Update()
        dgvVencimento.Refresh()
    End Sub

    Private Sub abre_campos()
        txtNomeProd.ReadOnly = False
        txtMarcaProd.ReadOnly = False
        txtValorCusto.ReadOnly = False
        txtValorVenda.ReadOnly = False
        txtQtdeAtual.ReadOnly = False
        txtQtdeMinima.ReadOnly = False

        cbxFornecedor.Enabled = True

        btnIniciarFoto.Enabled = True
        btnLimpaFoto.Enabled = True
        btnCancelaFoto.Enabled = False
        btnPastaFoto.Enabled = True
        btnTirarFoto.Enabled = False

        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
        btnLimpar.Enabled = True
        btnLimpar.Enabled = True

        dgvProdutos.Enabled = False

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        txtNomeProd.Focus()
    End Sub

    Private Sub limpa_campos()
        txtNomeProd.Text = ""
        txtMarcaProd.Text = ""
        txtValorCusto.Text = ""
        txtValorVenda.Text = ""
        txtQtdeAtual.Text = ""
        txtQtdeMinima.Text = ""
        pbxFoto.Image = Image.FromFile(Application.StartupPath & "\semimagem.png")
    End Sub

    Private Sub carrega_produtos()
        Dim vProdutoNegocios As New ProdutoNegocio
        Dim vProdutoColecao As New ProdutoColecao

        vProdutoColecao = vProdutoNegocios.CarregarConsulta

        dgvProdutos.DataSource = Nothing
        dgvProdutos.DataSource = vProdutoColecao

        dgvProdutos.Update()
        dgvProdutos.Refresh()

        If dgvProdutos.Rows.Count > 0 Then
            btnExcluir.Enabled = True
            btnEditar.Enabled = True
        Else
            btnExcluir.Enabled = False
            btnEditar.Enabled = False
            limpa_campos()
            txtCodProd.Text = ""
        End If
    End Sub

    Private Sub encerra_campos()
        txtNomeProd.ReadOnly = True
        txtMarcaProd.ReadOnly = True
        cbxFornecedor.Enabled = False
        txtValorCusto.ReadOnly = True
        txtValorVenda.ReadOnly = True
        txtQtdeAtual.ReadOnly = True
        txtQtdeMinima.ReadOnly = True

        btnIniciarFoto.Enabled = False
        btnLimpaFoto.Enabled = False
        btnPastaFoto.Enabled = False
        btnCancelaFoto.Enabled = False
        btnTirarFoto.Enabled = False

        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False
        btnLimpar.Enabled = False
        btnFornecedorLimpa.Enabled = False
        btnFornecedorMais.Enabled = False

        dgvProdutos.Enabled = True

        btnAdicionar.Enabled = True

        If dgvProdutos.Rows.Count > 0 Then
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        End If

    End Sub

    Private Sub carrega_campos()
        carrega_comboboxFornecedor()

        If dgvProdutos.Rows.Count > 0 Then
            txtCodProd.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(0).Value
            txtNomeProd.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(1).Value
            txtMarcaProd.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(2).Value
            txtValorCusto.Text = String.Format("{0:F2}", dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(3).Value)
            txtValorVenda.Text = String.Format("{0:F2}", dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(4).Value)
            txtQtdeMinima.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(5).Value
            cbxFornecedor.Text = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(7).Value
            pbxFoto.Image = CarregaFoto.carregaFoto(dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(9).Value, "fotosprodutos")
        Else
            limpa_campos()
            txtCodProd.Text = ""
        End If

    End Sub

    Private Sub frm_CadProduto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub dgvProdutos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProdutos.SelectionChanged
        carrega_campos()
        carrega_vencimentos()
        txtQtdeAtual.Text = 0
        For t = 0 To dgvVencimento.Rows.Count - 1
            txtQtdeAtual.Text = CInt(txtQtdeAtual.Text) + dgvVencimento.Rows(t).Cells(3).Value
        Next
        If CInt(txtQtdeAtual.Text) = CInt(txtQtdeMinima.Text) Then
            txtQtdeAtual.BackColor = Color.Yellow
        ElseIf CInt(txtQtdeAtual.Text) < CInt(txtQtdeMinima.Text) Then
            txtQtdeAtual.BackColor = Color.Red
        Else
            txtQtdeAtual.BackColor = Color.DarkSeaGreen
        End If
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

        carrega_comboboxFornecedor()

        txtCodProd.Text = ""
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Camera.EncerrarCamera()
        cbxFornecedor.DataSource = Nothing
        carrega_campos()
        encerra_campos()
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim vProduto As New Produto
        Dim vProdutoNegocio As New ProdutoNegocio
        Dim vVerificaPreco As Double
        Dim vRetorno As String

        Try
            Camera.EncerrarCamera()
            vVerificaPreco = txtValorCusto.Text
            vVerificaPreco = txtValorVenda.Text
            If txtCodProd.Text = "" Then
                '======================= NOVO CADASTRO PRODUTO ===============
                vProduto.vNome = txtNomeProd.Text
                vProduto.vMarca = txtMarcaProd.Text

                If cbxFornecedor.Text = "" Then
                    vProduto.vCodigoFornecedor = 0
                Else
                    vProduto.vCodigoFornecedor = cbxFornecedor.SelectedValue
                End If

                vProduto.vValorCompra = txtValorCusto.Text
                vProduto.vValorVenda = txtValorVenda.Text
                vProduto.vQtdeMinima = txtQtdeMinima.Text
                vProduto.vFoto = Camera.SalvaFoto(pbxFoto, "fotosprodutos")
                vProduto.vAtivo = "s"

                vRetorno = vProdutoNegocio.Inserir(vProduto)
                Dim idProduto As Integer = Convert.ToInt32(vRetorno)

                MessageBox.Show("Produto inserido com Sucesso. Código: " & idProduto, "Produto Inserido...")
            Else
                '====================== EDIÇÃO CADASTRO ==============
                vProduto.vCodigo = txtCodProd.Text
                vProduto.vNome = txtNomeProd.Text
                vProduto.vMarca = txtMarcaProd.Text

                If cbxFornecedor.Text = "" Then
                    vProduto.vCodigoFornecedor = 0
                Else
                    vProduto.vCodigoFornecedor = cbxFornecedor.SelectedValue
                End If

                vProduto.vValorCompra = txtValorCusto.Text
                vProduto.vValorVenda = txtValorVenda.Text
                vProduto.vQtdeMinima = txtQtdeMinima.Text
                vProduto.vFoto = Camera.SalvaFoto(pbxFoto, "fotosprodutos")
                vProduto.vAtivo = "s"

                vRetorno = vProdutoNegocio.Alterar(vProduto)
                Dim idProduto As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Produto alterado com Sucesso. Código: " & idProduto, "Produto Alterado...")
            End If
            carrega_produtos()
            encerra_campos()
        Catch ex As Exception
            MessageBox.Show("Não foi possível cadastrar o Produto. Aviso: " & ex.Message, "Aviso...")
            txtValorCusto.Focus()
            txtValorVenda.Focus()
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim vProdutoNegocio As New ProdutoNegocio
        Dim vProduto As New Produto
        Dim vRetorno As String

        Try
            If MessageBox.Show("Exclusão do Produto:" & vbCrLf & dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(1).Value & vbCrLf & vbCrLf & "Deseja realmente excluir o produto citada acima?", "Exclusão de Produto...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                vProduto.vCodigo = dgvProdutos.Rows(dgvProdutos.CurrentRow.Index).Cells(0).Value
                vRetorno = vProdutoNegocio.Excluir(vProduto)

                Dim idProduto As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Produto excluido com sucesso de seu Sistema!", "Exclusão Finalizada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_produtos()
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível fazer a Exclusão do Produto selecionada!", "Exclusão Cancelada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limpa_campos()
        txtNomeProd.Focus()
    End Sub

    Private Sub frm_CadProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_produtos()
        carrega_campos()
    End Sub

    Private Sub btnCasa_Click(sender As Object, e As EventArgs) Handles btnCasa.Click
        Me.Close()
    End Sub

    Private Sub txtValorCusto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorCusto.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValorVenda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorVenda.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtdeAtual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdeAtual.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtQtdeMinima_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQtdeMinima.KeyPress
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

    Private Sub btnFornecedorMais_Click(sender As Object, e As EventArgs) Handles btnFornecedorMais.Click
        frm_Fornec.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnFornecedorLimpa_Click(sender As Object, e As EventArgs) Handles btnFornecedorLimpa.Click
        cbxFornecedor.SelectedIndex = -1
    End Sub

    Private Sub btnDuvida_Click(sender As Object, e As EventArgs) Handles btnDuvida.Click
        MessageBox.Show("Este é um formulário para cadastro de Produtos e Vencimentos. " & vbCrLf & "Neste formulário você cadastra o Produto, tais como a data que adiquiriu o produto e a data de vencimento, controlando assim a entrada e saída de seus produtos..." & vbCrLf & vbCrLf & "Obrigado por usar o Sistema...", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnVencimentoAdicionar_Click(sender As Object, e As EventArgs)
        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

End Class