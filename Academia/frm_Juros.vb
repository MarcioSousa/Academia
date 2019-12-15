Imports Negocio
Imports dto_TransfereciaDados

Public Class frm_Juros

    Public Sub abre_campos()
        txtDiaJuros.ReadOnly = False
        txtMesJuros.ReadOnly = False
        txtAnoJuros.ReadOnly = False
        txtDiaDesconto.ReadOnly = False
        txtMesDesconto.ReadOnly = False
        txtAnoDesconto.ReadOnly = False

        btnEditar.Enabled = False
        btnNovo.Enabled = False

        btnConfirma.Enabled = True
        btnCancela.Enabled = True
        btnLimpa.Enabled = True

        txtDiaJuros.Focus()
    End Sub

    Private Sub limpa_campos()
        txtDiaJuros.Text = ""
        txtMesJuros.Text = ""
        txtAnoJuros.Text = ""
        txtDiaDesconto.Text = ""
        txtMesDesconto.Text = ""
        txtAnoDesconto.Text = ""

        txtDiaJuros.Focus()
    End Sub

    Private Sub carrega_juros()
        Dim vJurosNegocio As New JurosNegocio

        Dim vJuros As Juros = vJurosNegocio.Carregar()

        txtDiaJuros.Text = vJuros.vJurDia
        txtMesJuros.Text = vJuros.vJurMes
        txtAnoJuros.Text = vJuros.vjurAno
        txtDiaDesconto.Text = vJuros.vJurDesDia
        txtMesDesconto.Text = vJuros.vJurDesMes
        txtAnoDesconto.Text = vJuros.vjurDesAno

        If txtDiaJuros.Text = "" Then
            btnEditar.Enabled = False
        Else
            btnEditar.Enabled = True
        End If

    End Sub

    Private Sub encerra_cadastro()
        txtDiaJuros.ReadOnly = True
        txtMesJuros.ReadOnly = True
        txtAnoJuros.ReadOnly = True
        txtDiaDesconto.ReadOnly = True
        txtMesDesconto.ReadOnly = True
        txtAnoDesconto.ReadOnly = True

        btnConfirma.Enabled = False
        btnCancela.Enabled = False
        btnLimpa.Enabled = False

        btnNovo.Enabled = True

        If txtDiaJuros.Text = "" Then
            btnEditar.Enabled = False
        Else
            btnEditar.Enabled = True
        End If

    End Sub

    Private Sub verifica_campos()
        If txtDiaJuros.Text = "" Then
            txtDiaJuros.Text = 0
        End If
        If txtMesJuros.Text = "" Then
            txtMesJuros.Text = 0
        End If
        If txtAnoJuros.Text = "" Then
            txtAnoJuros.Text = 0
        End If
        If txtDiaDesconto.Text = "" Then
            txtDiaDesconto.Text = 0
        End If
        If txtMesDesconto.Text = "" Then
            txtMesDesconto.Text = 0
        End If
        If txtAnoDesconto.Text = "" Then
            txtAnoDesconto.Text = 0
        End If
    End Sub

    Private Sub frm_Juros_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub frm_Juros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carrega_juros()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        abre_campos()
    End Sub



    Private Sub btnCancela_Click(sender As Object, e As EventArgs) Handles btnCancela.Click
        encerra_cadastro()
        carrega_juros()
    End Sub

    Private Sub btnConfirma_Click(sender As Object, e As EventArgs) Handles btnConfirma.Click
        Dim vJuros As New Juros
        Dim vJurosNegocio As New JurosNegocio
        Dim vCodigoJuros As Integer
        Dim vRetorno As String

        verifica_campos()
        '=============== VERIFICAR SE TEM ALGUM ARQUIVO NO BANCO DE DADOS ====================
        vJuros = vJurosNegocio.Carregar()

        Try
            If vJuros.vCodigo.ToString = 0 Then
                vCodigoJuros = 0
            Else
                vCodigoJuros = vJuros.vCodigo
            End If
        Catch ex As Exception
            MessageBox.Show("Não foi possível ler os Juros/Desconto do Sistema.", "Aviso...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Try
            If vCodigoJuros = 0 Then
                '============== NOVO CADASTRO ================
                vJuros.vJurDia = txtDiaJuros.Text
                vJuros.vJurMes = txtMesJuros.Text
                vJuros.vjurAno = txtAnoJuros.Text
                vJuros.vJurDesDia = txtDiaDesconto.Text
                vJuros.vJurDesMes = txtMesDesconto.Text
                vJuros.vjurDesAno = txtAnoDesconto.Text
                vJuros.vAtivo = "s"

                vRetorno = vJurosNegocio.Inserir(vJuros)

                Dim idJuros As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Novas taxas de Juros/Desconto gravado com sucesso no Sistema.", "Juros/Desconto Inserido...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                '============== EDITA CADASTRO ================
                vJuros.vCodigo = vCodigoJuros
                vJuros.vJurDia = txtDiaJuros.Text
                vJuros.vJurMes = txtMesJuros.Text
                vJuros.vjurAno = txtAnoJuros.Text
                vJuros.vJurDesDia = txtDiaDesconto.Text
                vJuros.vJurDesMes = txtMesDesconto.Text
                vJuros.vjurDesAno = txtAnoDesconto.Text
                vJuros.vAtivo = "s"

                vRetorno = vJurosNegocio.Alterar(vJuros)

                Dim idJuros As Integer = Convert.ToInt32(vRetorno)
                MessageBox.Show("Taxa de Juros/Desconto alterado com Sucesso.", "Juros/Desconto Alterado...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            carrega_juros()
            encerra_cadastro()
        Catch ex As Exception
            MessageBox.Show("Não foi possível cadastrar a(s) taxa(s) de Juros/Desconto. Aviso: " & ex.Message)
        End Try

    End Sub

    Private Sub btnLimpa_Click(sender As Object, e As EventArgs) Handles btnLimpa.Click
        limpa_campos()
    End Sub

    Private Sub btnInicial_Click(sender As Object, e As EventArgs) Handles btnInicial.Click
        Me.Close()
    End Sub

    Private Sub btnAjuda_Click(sender As Object, e As EventArgs) Handles btnAjuda.Click
        MessageBox.Show("Este formulário é para cadastrar as taxas de juros e descontos que você deseja obter depois ou antes do prazo de pagamento/vencimento de uma determinada compra." & vbCrLf & vbCrLf & "Obrigado por usar o Sistema...", "Dúvidas sobre o Formulário...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub txtDiaJuros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMesJuros.KeyPress, txtMesDesconto.KeyPress, txtDiaJuros.KeyPress, txtDiaDesconto.KeyPress, txtAnoJuros.KeyPress, txtAnoDesconto.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        abre_campos()
        limpa_campos()
        txtDiaJuros.Focus()
    End Sub

End Class