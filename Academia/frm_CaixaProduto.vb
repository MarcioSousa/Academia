Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_CaixaProduto

    Private Sub carregaCampos()
        Dim vProdutoNegocios As New ProdutoNegocio
        Dim vProdutoColecao As New ProdutoColecao

        txtNome.DataBindings.Clear()
        txtPreco.DataBindings.Clear()
        txtFoto.DataBindings.Clear()
        pbxProduto.Image = Nothing

        If txtCodigo.Text <> "" Then
            vProdutoColecao = vProdutoNegocios.CarregarConsultaCodigo(txtCodigo.Text)
            txtNome.DataBindings.Add("Text", vProdutoColecao, "vNome")
            txtPreco.DataBindings.Add("Text", vProdutoColecao, "vValorVenda")
            txtFoto.DataBindings.Add("Text", vProdutoColecao, "vFoto")
            pbxProduto.Image = CarregaFoto.carregaFoto(txtFoto.Text, "\fotosprodutos\")
        Else
            txtNome.Text = ""
            txtPreco.Text = ""
        End If

    End Sub

    Private Sub frm_Caixa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        carregaCampos()
    End Sub

    Private Sub txtQtde_TextChanged(sender As Object, e As EventArgs) Handles txtQtde.TextChanged
        If txtQtde.Text <> "" Then
            txtValorTotal.Text = CDec(txtPreco.Text) * CInt(txtQtde.Text)
        Else
            txtValorTotal.Text = ""
        End If
    End Sub


End Class