<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Produto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Produto))
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.btnDuvida = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelaFoto = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFornecedorLimpa = New System.Windows.Forms.Button()
        Me.btnFornecedorMais = New System.Windows.Forms.Button()
        Me.cbxFornecedor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQtdeAtual = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMarcaProd = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.txtCodProd = New System.Windows.Forms.TextBox()
        Me.txtValorCusto = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorVenda = New System.Windows.Forms.TextBox()
        Me.txtQtdeMinima = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPastaFoto = New System.Windows.Forms.Button()
        Me.btnLimpaFoto = New System.Windows.Forms.Button()
        Me.btnIniciarFoto = New System.Windows.Forms.Button()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvVencimento = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CodAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORCOMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALORVENDA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTDEMINIMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODFORNEC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFuncionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaAtivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVencimento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(545, 245)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(47, 47)
        Me.btnCancelar.TabIndex = 29
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(386, 245)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 34
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(439, 245)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(47, 47)
        Me.btnExcluir.TabIndex = 35
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(333, 245)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(47, 47)
        Me.btnAdicionar.TabIndex = 33
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Enabled = False
        Me.btnLimpar.FlatAppearance.BorderSize = 0
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.Location = New System.Drawing.Point(280, 245)
        Me.btnLimpar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(47, 47)
        Me.btnLimpar.TabIndex = 30
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnCasa
        '
        Me.btnCasa.FlatAppearance.BorderSize = 0
        Me.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCasa.Image = CType(resources.GetObject("btnCasa.Image"), System.Drawing.Image)
        Me.btnCasa.Location = New System.Drawing.Point(174, 245)
        Me.btnCasa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(47, 47)
        Me.btnCasa.TabIndex = 32
        Me.btnCasa.UseVisualStyleBackColor = True
        '
        'btnDuvida
        '
        Me.btnDuvida.FlatAppearance.BorderSize = 0
        Me.btnDuvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuvida.Image = CType(resources.GetObject("btnDuvida.Image"), System.Drawing.Image)
        Me.btnDuvida.Location = New System.Drawing.Point(227, 245)
        Me.btnDuvida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDuvida.Name = "btnDuvida"
        Me.btnDuvida.Size = New System.Drawing.Size(47, 47)
        Me.btnDuvida.TabIndex = 31
        Me.btnDuvida.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(492, 245)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirmar.TabIndex = 28
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnCancelaFoto)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnPastaFoto)
        Me.Panel2.Controls.Add(Me.btnLimpaFoto)
        Me.Panel2.Controls.Add(Me.btnIniciarFoto)
        Me.Panel2.Controls.Add(Me.btnTirarFoto)
        Me.Panel2.Controls.Add(Me.pbxFoto)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 228)
        Me.Panel2.TabIndex = 27
        '
        'btnCancelaFoto
        '
        Me.btnCancelaFoto.AutoSize = True
        Me.btnCancelaFoto.Enabled = False
        Me.btnCancelaFoto.FlatAppearance.BorderSize = 0
        Me.btnCancelaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelaFoto.Image = CType(resources.GetObject("btnCancelaFoto.Image"), System.Drawing.Image)
        Me.btnCancelaFoto.Location = New System.Drawing.Point(56, 177)
        Me.btnCancelaFoto.Name = "btnCancelaFoto"
        Me.btnCancelaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnCancelaFoto.TabIndex = 56
        Me.btnCancelaFoto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnFornecedorLimpa)
        Me.Panel1.Controls.Add(Me.btnFornecedorMais)
        Me.Panel1.Controls.Add(Me.cbxFornecedor)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtQtdeAtual)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMarcaProd)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtNomeProd)
        Me.Panel1.Controls.Add(Me.txtCodProd)
        Me.Panel1.Controls.Add(Me.txtValorCusto)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtValorVenda)
        Me.Panel1.Controls.Add(Me.txtQtdeMinima)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(246, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 228)
        Me.Panel1.TabIndex = 55
        '
        'btnFornecedorLimpa
        '
        Me.btnFornecedorLimpa.Enabled = False
        Me.btnFornecedorLimpa.FlatAppearance.BorderSize = 0
        Me.btnFornecedorLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFornecedorLimpa.Image = CType(resources.GetObject("btnFornecedorLimpa.Image"), System.Drawing.Image)
        Me.btnFornecedorLimpa.Location = New System.Drawing.Point(505, 127)
        Me.btnFornecedorLimpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFornecedorLimpa.Name = "btnFornecedorLimpa"
        Me.btnFornecedorLimpa.Size = New System.Drawing.Size(25, 24)
        Me.btnFornecedorLimpa.TabIndex = 54
        Me.btnFornecedorLimpa.UseVisualStyleBackColor = True
        '
        'btnFornecedorMais
        '
        Me.btnFornecedorMais.Enabled = False
        Me.btnFornecedorMais.FlatAppearance.BorderSize = 0
        Me.btnFornecedorMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFornecedorMais.Image = CType(resources.GetObject("btnFornecedorMais.Image"), System.Drawing.Image)
        Me.btnFornecedorMais.Location = New System.Drawing.Point(474, 126)
        Me.btnFornecedorMais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFornecedorMais.Name = "btnFornecedorMais"
        Me.btnFornecedorMais.Size = New System.Drawing.Size(25, 25)
        Me.btnFornecedorMais.TabIndex = 55
        Me.btnFornecedorMais.UseVisualStyleBackColor = True
        '
        'cbxFornecedor
        '
        Me.cbxFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFornecedor.Enabled = False
        Me.cbxFornecedor.FormattingEnabled = True
        Me.cbxFornecedor.Location = New System.Drawing.Point(14, 127)
        Me.cbxFornecedor.Name = "cbxFornecedor"
        Me.cbxFornecedor.Size = New System.Drawing.Size(454, 24)
        Me.cbxFornecedor.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Fornecedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Código"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Marca"
        '
        'txtQtdeAtual
        '
        Me.txtQtdeAtual.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.txtQtdeAtual.ForeColor = System.Drawing.SystemColors.Window
        Me.txtQtdeAtual.Location = New System.Drawing.Point(415, 173)
        Me.txtQtdeAtual.MaxLength = 8
        Me.txtQtdeAtual.Name = "txtQtdeAtual"
        Me.txtQtdeAtual.ReadOnly = True
        Me.txtQtdeAtual.Size = New System.Drawing.Size(115, 23)
        Me.txtQtdeAtual.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Qtde Atual"
        '
        'txtMarcaProd
        '
        Me.txtMarcaProd.Location = New System.Drawing.Point(14, 82)
        Me.txtMarcaProd.Name = "txtMarcaProd"
        Me.txtMarcaProd.ReadOnly = True
        Me.txtMarcaProd.Size = New System.Drawing.Size(516, 23)
        Me.txtMarcaProd.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(85, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nome do Produto"
        '
        'txtNomeProd
        '
        Me.txtNomeProd.Location = New System.Drawing.Point(88, 37)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.ReadOnly = True
        Me.txtNomeProd.Size = New System.Drawing.Size(442, 23)
        Me.txtNomeProd.TabIndex = 3
        '
        'txtCodProd
        '
        Me.txtCodProd.Enabled = False
        Me.txtCodProd.Location = New System.Drawing.Point(14, 37)
        Me.txtCodProd.Name = "txtCodProd"
        Me.txtCodProd.ReadOnly = True
        Me.txtCodProd.Size = New System.Drawing.Size(68, 23)
        Me.txtCodProd.TabIndex = 0
        '
        'txtValorCusto
        '
        Me.txtValorCusto.Location = New System.Drawing.Point(14, 173)
        Me.txtValorCusto.Name = "txtValorCusto"
        Me.txtValorCusto.ReadOnly = True
        Me.txtValorCusto.Size = New System.Drawing.Size(132, 23)
        Me.txtValorCusto.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(14, 154)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 16)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Valor (custo)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Qtde Mínima"
        '
        'txtValorVenda
        '
        Me.txtValorVenda.Location = New System.Drawing.Point(151, 173)
        Me.txtValorVenda.Name = "txtValorVenda"
        Me.txtValorVenda.ReadOnly = True
        Me.txtValorVenda.Size = New System.Drawing.Size(137, 23)
        Me.txtValorVenda.TabIndex = 5
        '
        'txtQtdeMinima
        '
        Me.txtQtdeMinima.BackColor = System.Drawing.Color.Yellow
        Me.txtQtdeMinima.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtQtdeMinima.Location = New System.Drawing.Point(294, 173)
        Me.txtQtdeMinima.MaxLength = 8
        Me.txtQtdeMinima.Name = "txtQtdeMinima"
        Me.txtQtdeMinima.ReadOnly = True
        Me.txtQtdeMinima.Size = New System.Drawing.Size(115, 23)
        Me.txtQtdeMinima.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Valor (venda)"
        '
        'btnPastaFoto
        '
        Me.btnPastaFoto.AutoSize = True
        Me.btnPastaFoto.Enabled = False
        Me.btnPastaFoto.FlatAppearance.BorderSize = 0
        Me.btnPastaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastaFoto.Image = CType(resources.GetObject("btnPastaFoto.Image"), System.Drawing.Image)
        Me.btnPastaFoto.Location = New System.Drawing.Point(197, 177)
        Me.btnPastaFoto.Name = "btnPastaFoto"
        Me.btnPastaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnPastaFoto.TabIndex = 54
        Me.btnPastaFoto.UseVisualStyleBackColor = True
        '
        'btnLimpaFoto
        '
        Me.btnLimpaFoto.AutoSize = True
        Me.btnLimpaFoto.Enabled = False
        Me.btnLimpaFoto.FlatAppearance.BorderSize = 0
        Me.btnLimpaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpaFoto.Image = CType(resources.GetObject("btnLimpaFoto.Image"), System.Drawing.Image)
        Me.btnLimpaFoto.Location = New System.Drawing.Point(150, 177)
        Me.btnLimpaFoto.Name = "btnLimpaFoto"
        Me.btnLimpaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnLimpaFoto.TabIndex = 53
        Me.btnLimpaFoto.UseVisualStyleBackColor = True
        '
        'btnIniciarFoto
        '
        Me.btnIniciarFoto.AutoSize = True
        Me.btnIniciarFoto.Enabled = False
        Me.btnIniciarFoto.FlatAppearance.BorderSize = 0
        Me.btnIniciarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarFoto.Image = CType(resources.GetObject("btnIniciarFoto.Image"), System.Drawing.Image)
        Me.btnIniciarFoto.Location = New System.Drawing.Point(9, 177)
        Me.btnIniciarFoto.Name = "btnIniciarFoto"
        Me.btnIniciarFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnIniciarFoto.TabIndex = 52
        Me.btnIniciarFoto.UseVisualStyleBackColor = True
        '
        'btnTirarFoto
        '
        Me.btnTirarFoto.AutoSize = True
        Me.btnTirarFoto.Enabled = False
        Me.btnTirarFoto.FlatAppearance.BorderSize = 0
        Me.btnTirarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTirarFoto.Image = CType(resources.GetObject("btnTirarFoto.Image"), System.Drawing.Image)
        Me.btnTirarFoto.Location = New System.Drawing.Point(103, 177)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnTirarFoto.TabIndex = 51
        Me.btnTirarFoto.UseVisualStyleBackColor = True
        '
        'pbxFoto
        '
        Me.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxFoto.Image = CType(resources.GetObject("pbxFoto.Image"), System.Drawing.Image)
        Me.pbxFoto.Location = New System.Drawing.Point(23, 21)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(200, 150)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 50
        Me.pbxFoto.TabStop = False
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.AllowUserToResizeColumns = False
        Me.dgvProdutos.AllowUserToResizeRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvProdutos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodAula, Me.NomeProduto, Me.MarcaProduto, Me.VALORCOMPRA, Me.VALORVENDA, Me.QTDEMINIMA, Me.CODFORNEC, Me.NomeFuncionario, Me.AulaAtivo, Me.AulaFoto})
        Me.dgvProdutos.Location = New System.Drawing.Point(6, 19)
        Me.dgvProdutos.MultiSelect = False
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.RowHeadersVisible = False
        Me.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProdutos.Size = New System.Drawing.Size(441, 248)
        Me.dgvProdutos.TabIndex = 47
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Png (*.png)|*.png|Jpeg(*.jpg)|*.jpg"
        '
        'dgvVencimento
        '
        Me.dgvVencimento.AllowUserToAddRows = False
        Me.dgvVencimento.AllowUserToDeleteRows = False
        Me.dgvVencimento.AllowUserToResizeColumns = False
        Me.dgvVencimento.AllowUserToResizeRows = False
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvVencimento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
        Me.dgvVencimento.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvVencimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVencimento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dgvVencimento.Location = New System.Drawing.Point(6, 17)
        Me.dgvVencimento.MultiSelect = False
        Me.dgvVencimento.Name = "dgvVencimento"
        Me.dgvVencimento.RowHeadersVisible = False
        Me.dgvVencimento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVencimento.Size = New System.Drawing.Size(323, 250)
        Me.dgvVencimento.TabIndex = 48
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvVencimento)
        Me.GroupBox1.Location = New System.Drawing.Point(471, 299)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 273)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vencimentos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvProdutos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(453, 273)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos"
        '
        'CodAula
        '
        Me.CodAula.DataPropertyName = "vCodigo"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.Red
        Me.CodAula.DefaultCellStyle = DataGridViewCellStyle30
        Me.CodAula.HeaderText = "Codigo"
        Me.CodAula.Name = "CodAula"
        Me.CodAula.ReadOnly = True
        Me.CodAula.Width = 60
        '
        'NomeProduto
        '
        Me.NomeProduto.DataPropertyName = "vNome"
        Me.NomeProduto.HeaderText = "Produto"
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.ReadOnly = True
        Me.NomeProduto.Width = 180
        '
        'MarcaProduto
        '
        Me.MarcaProduto.DataPropertyName = "vMarca"
        Me.MarcaProduto.HeaderText = "Marca"
        Me.MarcaProduto.Name = "MarcaProduto"
        Me.MarcaProduto.ReadOnly = True
        Me.MarcaProduto.Visible = False
        Me.MarcaProduto.Width = 130
        '
        'VALORCOMPRA
        '
        Me.VALORCOMPRA.DataPropertyName = "vValorCompra"
        DataGridViewCellStyle31.Format = "N2"
        DataGridViewCellStyle31.NullValue = Nothing
        Me.VALORCOMPRA.DefaultCellStyle = DataGridViewCellStyle31
        Me.VALORCOMPRA.HeaderText = "Compra"
        Me.VALORCOMPRA.Name = "VALORCOMPRA"
        Me.VALORCOMPRA.ReadOnly = True
        Me.VALORCOMPRA.Width = 90
        '
        'VALORVENDA
        '
        Me.VALORVENDA.DataPropertyName = "vValorVenda"
        DataGridViewCellStyle32.Format = "N2"
        DataGridViewCellStyle32.NullValue = Nothing
        Me.VALORVENDA.DefaultCellStyle = DataGridViewCellStyle32
        Me.VALORVENDA.HeaderText = "Preço"
        Me.VALORVENDA.Name = "VALORVENDA"
        Me.VALORVENDA.ReadOnly = True
        Me.VALORVENDA.Width = 90
        '
        'QTDEMINIMA
        '
        Me.QTDEMINIMA.DataPropertyName = "vQtdeMinima"
        Me.QTDEMINIMA.HeaderText = "Mínimo"
        Me.QTDEMINIMA.Name = "QTDEMINIMA"
        Me.QTDEMINIMA.ReadOnly = True
        Me.QTDEMINIMA.Visible = False
        '
        'CODFORNEC
        '
        Me.CODFORNEC.DataPropertyName = "vCodigo"
        Me.CODFORNEC.HeaderText = "CodFor"
        Me.CODFORNEC.Name = "CODFORNEC"
        Me.CODFORNEC.ReadOnly = True
        Me.CODFORNEC.Visible = False
        '
        'NomeFuncionario
        '
        Me.NomeFuncionario.DataPropertyName = "vNomeFornecedor"
        Me.NomeFuncionario.HeaderText = "Fornecedor"
        Me.NomeFuncionario.Name = "NomeFuncionario"
        Me.NomeFuncionario.ReadOnly = True
        Me.NomeFuncionario.Visible = False
        Me.NomeFuncionario.Width = 200
        '
        'AulaAtivo
        '
        Me.AulaAtivo.DataPropertyName = "vAtivo"
        Me.AulaAtivo.HeaderText = "Ativo"
        Me.AulaAtivo.Name = "AulaAtivo"
        Me.AulaAtivo.ReadOnly = True
        Me.AulaAtivo.Visible = False
        '
        'AulaFoto
        '
        Me.AulaFoto.DataPropertyName = "vFoto"
        Me.AulaFoto.HeaderText = "Foto"
        Me.AulaFoto.Name = "AulaFoto"
        Me.AulaFoto.ReadOnly = True
        Me.AulaFoto.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "vCodigo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CodVenc"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "vDataVencimento"
        DataGridViewCellStyle34.Format = "d"
        DataGridViewCellStyle34.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle34
        Me.DataGridViewTextBoxColumn8.HeaderText = "DataVenc"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "vDataEntrada"
        DataGridViewCellStyle35.Format = "d"
        DataGridViewCellStyle35.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle35
        Me.DataGridViewTextBoxColumn9.HeaderText = "DataEntrada"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "vQtdeEstoque"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Estoque"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "vCodigoProduto"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CodProd"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "vAtivo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "VencAtivo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'frm_Produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 581)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCasa)
        Me.Controls.Add(Me.btnDuvida)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Produto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Produtos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVencimento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnCasa As System.Windows.Forms.Button
    Friend WithEvents btnDuvida As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeAtual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeMinima As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValorVenda As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtValorCusto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProd As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProd As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMarcaProd As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPastaFoto As System.Windows.Forms.Button
    Friend WithEvents btnLimpaFoto As System.Windows.Forms.Button
    Friend WithEvents btnIniciarFoto As System.Windows.Forms.Button
    Friend WithEvents btnTirarFoto As System.Windows.Forms.Button
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelaFoto As System.Windows.Forms.Button
    Friend WithEvents btnFornecedorLimpa As System.Windows.Forms.Button
    Friend WithEvents btnFornecedorMais As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvVencimento As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CodAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaProduto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALORCOMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALORVENDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTDEMINIMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODFORNEC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeFuncionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaAtivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaFoto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
