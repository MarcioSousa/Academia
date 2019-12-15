Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Fornec

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        '        '//-----NÃO GERAR LINHAS AUTOMÁTICAS-----
        dgvFornec.AutoGenerateColumns = False
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub abre_campos()
        txtNome.ReadOnly = False
        txtEmpresa.ReadOnly = False
        mtbTelCel.ReadOnly = False
        mtbTelCom.ReadOnly = False

        btnConfirma.Enabled = True
        btnCancela.Enabled = True
        btnLimpa.Enabled = True

        dgvFornec.Enabled = False

        btnEditar.Enabled = False
        btnExcluir.Enabled = False
        btnNovo.Enabled = False

        txtNome.Focus()
    End Sub

    Private Sub limpa_campos()
        txtNome.Text = ""
        txtEmpresa.Text = ""
        mtbTelCel.Text = ""
        mtbTelCom.Text = ""
    End Sub

    Private Sub carrega_fornecedores()
        Dim vFornecNegocio As New FornecedorNegocio
        Dim vFornecColecao As New FornecedorColecao

        vFornecColecao = vFornecNegocio.Carregar()

        dgvFornec.DataSource = Nothing
        dgvFornec.DataSource = vFornecColecao

        dgvFornec.Update()
        dgvFornec.Refresh()

        If dgvFornec.Rows.Count > 0 Then
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
        txtEmpresa.ReadOnly = True
        mtbTelCel.ReadOnly = True
        mtbTelCom.ReadOnly = True
        btnConfirma.Enabled = False
        btnCancela.Enabled = False
        btnLimpa.Enabled = False

        btnNovo.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        dgvFornec.Enabled = True
    End Sub

    Private Sub carrega_campos()
        If dgvFornec.Rows.Count > 0 Then
            txtCod.Text = dgvFornec.Rows(dgvFornec.CurrentRow.Index).Cells(0).Value
            txtNome.Text = dgvFornec.Rows(dgvFornec.CurrentRow.Index).Cells(1).Value
            txtEmpresa.Text = dgvFornec.Rows(dgvFornec.CurrentRow.Index).Cells(2).Value
            mtbTelCom.Text = dgvFornec.Rows(dgvFornec.CurrentRow.Index).Cells(3).Value
            mtbTelCel.Text = dgvFornec.Rows(dgvFornec.CurrentRow.Index).Cells(4).Value
        Else
            limpa_campos()
            txtCod.Text = ""
        End If
    End Sub

    Private Sub frm_CadFornec_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub dgvFornec_SelectionChanged(sender As Object, e As EventArgs) Handles dgvFornec.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        abre_campos()
    End Sub


    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        carrega_campos()
        encerra_cadastro()
    End Sub

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        Dim vFornecedor As New Fornecedor
        Dim vFornecedorNegocio As New FornecedorNegocio
        Dim vRetorno As String

        Try
            If txtCod.Text = "" Then
                '============== NOVO CADASTRO ================
                vFornecedor.vNome = txtNome.Text
                vFornecedor.vEmpresa = txtEmpresa.Text
                vFornecedor.vContatoUm = mtbTelCom.Text
                vFornecedor.vContatoDois = mtbTelCel.Text
                vFornecedor.vAtivo = "s"

                vRetorno = vFornecedorNegocio.Inserir(vFornecedor)

                Dim idFornec As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Fornecedor Inserido com Sucesso. Código: " & idFornec.ToString, "Fornecedor Inserido...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                '============ EDITAR CADASTRO ================
                vFornecedor.vCodigo = txtCod.Text
                vFornecedor.vNome = txtNome.Text
                vFornecedor.vEmpresa = txtEmpresa.Text
                vFornecedor.vContatoUm = mtbTelCom.Text
                vFornecedor.vContatoDois = mtbTelCel.Text
                vFornecedor.vAtivo = "s"

                vRetorno = vFornecedorNegocio.Alterar(vFornecedor)

                Dim idFornec As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Fornecedor Alterado com Sucesso. Código: " & idFornec.ToString, "Fornecedor Alterado...")
            End If
            carrega_fornecedores()
            encerra_cadastro()
        Catch ex As Exception
            MessageBox.Show("Não foi possível cadastrar o Fornecedor. Aviso: " & ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim vFornecNegocio As New FornecedorNegocio
        Dim vFornecedor As New Fornecedor
        Dim vRetorno As String

        Try
            If MessageBox.Show("Exclusão de Fornecedor: " & vbCrLf & dgvFornec.Rows(dgvFornec.CurrentRow.Index).Cells(1).Value & vbCrLf & vbCrLf & "Deseja realmente excluir o Fornecedor acima?", "Exclusão de Fornecedor...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                vFornecedor.vCodigo = txtCod.Text
                vRetorno = vFornecNegocio.Excluir(vFornecedor)

                Dim codFornec As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Fornecedor Excluido com sucesso de seu sistema!", "Exclusão Finalizada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                carrega_fornecedores()
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível fazer a exclusão do Funcionário Selecionado!", "Exclusão Cancelada...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limpa_campos()
        txtNome.Focus()
    End Sub

    Private Sub frm_CadFornec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_fornecedores()
    End Sub

    Private Sub btnInicial_Click(sender As Object, e As EventArgs) Handles btnInicial.Click
        Me.Close()
    End Sub

    Private Sub btnAjuda_Click(sender As Object, e As EventArgs) Handles btnAjuda.Click
        MessageBox.Show("Este formulário é para cadastro de seus Fornecedores." & vbCrLf & "Há campos para adicionar um novo, editar ou excluir um fornecedor." & vbCrLf & "Do lado direto fica anotado a lista de todos os fornecedores ordenados por ordem ALFABÉTICA..." & vbCrLf & vbCrLf & "Obrigado por usar o Sistema...", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        abre_campos()
        limpa_campos()
        txtCod.Text = ""
    End Sub

End Class