Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Principal

    Private Sub btnAluno_Click(sender As Object, e As EventArgs) Handles btnAluno.Click
        frm_Aluno.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnFornecedor_Click(sender As Object, e As EventArgs) Handles btnFornecedor.Click
        frm_Fornec.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnFuncionario_Click(sender As Object, e As EventArgs) Handles btnFuncionario.Click
        frm_Funcionario.Show()
        Me.Enabled = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Juros.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnAula_Click(sender As Object, e As EventArgs) Handles btnAula.Click
        frm_Aula.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnProduto_Click(sender As Object, e As EventArgs) Handles btnProduto.Click
        frm_Produto.Show()
        Me.Enabled = False
    End Sub
    Private Sub btnVencimento_Click(sender As Object, e As EventArgs) Handles btnVencimento.Click
        frm_Vencimentos.Show()
        Me.Enabled = False

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCaixa_Click(sender As Object, e As EventArgs) Handles btnCaixa.Click
        frm_CaixaProduto.Show()
        Me.Enabled = False
    End Sub

End Class