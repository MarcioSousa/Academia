<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Funcionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Funcionario))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelaFoto = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPagamento = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpSaida = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.btnPastaFoto = New System.Windows.Forms.Button()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.btnLimpaFoto = New System.Windows.Forms.Button()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.btnIniciarFoto = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnInicial = New System.Windows.Forms.Button()
        Me.btnAjuda = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvFuncionarios = New System.Windows.Forms.DataGridView()
        Me.vCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vDataEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vDataSaida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vPagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vAtivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnCancelaFoto)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnPastaFoto)
        Me.Panel1.Controls.Add(Me.pbxFoto)
        Me.Panel1.Controls.Add(Me.btnLimpaFoto)
        Me.Panel1.Controls.Add(Me.btnTirarFoto)
        Me.Panel1.Controls.Add(Me.btnIniciarFoto)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(567, 217)
        Me.Panel1.TabIndex = 0
        '
        'btnCancelaFoto
        '
        Me.btnCancelaFoto.AutoSize = True
        Me.btnCancelaFoto.Enabled = False
        Me.btnCancelaFoto.FlatAppearance.BorderSize = 0
        Me.btnCancelaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelaFoto.Image = CType(resources.GetObject("btnCancelaFoto.Image"), System.Drawing.Image)
        Me.btnCancelaFoto.Location = New System.Drawing.Point(50, 165)
        Me.btnCancelaFoto.Name = "btnCancelaFoto"
        Me.btnCancelaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnCancelaFoto.TabIndex = 84
        Me.btnCancelaFoto.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtPagamento)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtNome)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCod)
        Me.Panel2.Controls.Add(Me.txtCargo)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dtpSaida)
        Me.Panel2.Controls.Add(Me.dtpEntrada)
        Me.Panel2.Location = New System.Drawing.Point(238, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 217)
        Me.Panel2.TabIndex = 84
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 28)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 16)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Código"
        '
        'txtPagamento
        '
        Me.txtPagamento.Location = New System.Drawing.Point(241, 104)
        Me.txtPagamento.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPagamento.MaxLength = 30
        Me.txtPagamento.Name = "txtPagamento"
        Me.txtPagamento.ReadOnly = True
        Me.txtPagamento.Size = New System.Drawing.Size(65, 20)
        Me.txtPagamento.TabIndex = 77
        Me.txtPagamento.Text = "150,00"
        Me.txtPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(90, 52)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(216, 20)
        Me.txtNome.TabIndex = 67
        Me.txtNome.Text = "Roberta Almeida"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(215, 80)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 16)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Pagamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "R$"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(15, 52)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCod.MaxLength = 40
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(71, 20)
        Me.txtCod.TabIndex = 69
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(15, 104)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCargo.MaxLength = 30
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ReadOnly = True
        Me.txtCargo.Size = New System.Drawing.Size(192, 20)
        Me.txtCargo.TabIndex = 71
        Me.txtCargo.Text = "Roberta Almeida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Entrada"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 80)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 16)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Cargo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 132)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Saída"
        '
        'dtpSaida
        '
        Me.dtpSaida.Enabled = False
        Me.dtpSaida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSaida.Location = New System.Drawing.Point(207, 156)
        Me.dtpSaida.Name = "dtpSaida"
        Me.dtpSaida.Size = New System.Drawing.Size(99, 20)
        Me.dtpSaida.TabIndex = 76
        '
        'dtpEntrada
        '
        Me.dtpEntrada.Enabled = False
        Me.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEntrada.Location = New System.Drawing.Point(15, 156)
        Me.dtpEntrada.Name = "dtpEntrada"
        Me.dtpEntrada.Size = New System.Drawing.Size(99, 20)
        Me.dtpEntrada.TabIndex = 75
        '
        'btnPastaFoto
        '
        Me.btnPastaFoto.AutoSize = True
        Me.btnPastaFoto.Enabled = False
        Me.btnPastaFoto.FlatAppearance.BorderSize = 0
        Me.btnPastaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastaFoto.Image = CType(resources.GetObject("btnPastaFoto.Image"), System.Drawing.Image)
        Me.btnPastaFoto.Location = New System.Drawing.Point(191, 165)
        Me.btnPastaFoto.Name = "btnPastaFoto"
        Me.btnPastaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnPastaFoto.TabIndex = 83
        Me.btnPastaFoto.UseVisualStyleBackColor = True
        '
        'pbxFoto
        '
        Me.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxFoto.Image = CType(resources.GetObject("pbxFoto.Image"), System.Drawing.Image)
        Me.pbxFoto.Location = New System.Drawing.Point(18, 9)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(200, 150)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 79
        Me.pbxFoto.TabStop = False
        '
        'btnLimpaFoto
        '
        Me.btnLimpaFoto.AutoSize = True
        Me.btnLimpaFoto.Enabled = False
        Me.btnLimpaFoto.FlatAppearance.BorderSize = 0
        Me.btnLimpaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpaFoto.Image = CType(resources.GetObject("btnLimpaFoto.Image"), System.Drawing.Image)
        Me.btnLimpaFoto.Location = New System.Drawing.Point(144, 165)
        Me.btnLimpaFoto.Name = "btnLimpaFoto"
        Me.btnLimpaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnLimpaFoto.TabIndex = 82
        Me.btnLimpaFoto.UseVisualStyleBackColor = True
        '
        'btnTirarFoto
        '
        Me.btnTirarFoto.AutoSize = True
        Me.btnTirarFoto.Enabled = False
        Me.btnTirarFoto.FlatAppearance.BorderSize = 0
        Me.btnTirarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTirarFoto.Image = CType(resources.GetObject("btnTirarFoto.Image"), System.Drawing.Image)
        Me.btnTirarFoto.Location = New System.Drawing.Point(97, 165)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnTirarFoto.TabIndex = 80
        Me.btnTirarFoto.UseVisualStyleBackColor = True
        '
        'btnIniciarFoto
        '
        Me.btnIniciarFoto.AutoSize = True
        Me.btnIniciarFoto.Enabled = False
        Me.btnIniciarFoto.FlatAppearance.BorderSize = 0
        Me.btnIniciarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarFoto.Image = CType(resources.GetObject("btnIniciarFoto.Image"), System.Drawing.Image)
        Me.btnIniciarFoto.Location = New System.Drawing.Point(3, 165)
        Me.btnIniciarFoto.Name = "btnIniciarFoto"
        Me.btnIniciarFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnIniciarFoto.TabIndex = 81
        Me.btnIniciarFoto.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.Enabled = False
        Me.btnCancela.FlatAppearance.BorderSize = 0
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(476, 236)
        Me.btnCancela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(47, 47)
        Me.btnCancela.TabIndex = 78
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.Enabled = False
        Me.btnLimpa.FlatAppearance.BorderSize = 0
        Me.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpa.Image = CType(resources.GetObject("btnLimpa.Image"), System.Drawing.Image)
        Me.btnLimpa.Location = New System.Drawing.Point(211, 236)
        Me.btnLimpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(47, 47)
        Me.btnLimpa.TabIndex = 77
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'btnConfirma
        '
        Me.btnConfirma.Enabled = False
        Me.btnConfirma.FlatAppearance.BorderSize = 0
        Me.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirma.Image = CType(resources.GetObject("btnConfirma.Image"), System.Drawing.Image)
        Me.btnConfirma.Location = New System.Drawing.Point(423, 236)
        Me.btnConfirma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirma.TabIndex = 76
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(317, 236)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 75
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(370, 236)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(47, 47)
        Me.btnExcluir.TabIndex = 74
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnInicial
        '
        Me.btnInicial.FlatAppearance.BorderSize = 0
        Me.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicial.Image = CType(resources.GetObject("btnInicial.Image"), System.Drawing.Image)
        Me.btnInicial.Location = New System.Drawing.Point(105, 236)
        Me.btnInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicial.Name = "btnInicial"
        Me.btnInicial.Size = New System.Drawing.Size(47, 47)
        Me.btnInicial.TabIndex = 72
        Me.btnInicial.UseVisualStyleBackColor = True
        '
        'btnAjuda
        '
        Me.btnAjuda.FlatAppearance.BorderSize = 0
        Me.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjuda.Image = CType(resources.GetObject("btnAjuda.Image"), System.Drawing.Image)
        Me.btnAjuda.Location = New System.Drawing.Point(158, 236)
        Me.btnAjuda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAjuda.Name = "btnAjuda"
        Me.btnAjuda.Size = New System.Drawing.Size(47, 47)
        Me.btnAjuda.TabIndex = 71
        Me.btnAjuda.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(264, 236)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(47, 47)
        Me.btnNovo.TabIndex = 73
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Png (*.png)|*.png|Jpeg(*.jpg)|*.jpg"
        '
        'dgvFuncionarios
        '
        Me.dgvFuncionarios.AllowUserToAddRows = False
        Me.dgvFuncionarios.AllowUserToDeleteRows = False
        Me.dgvFuncionarios.AllowUserToResizeColumns = False
        Me.dgvFuncionarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvFuncionarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFuncionarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vCodigo, Me.vNome, Me.vCargo, Me.vDataEntrada, Me.vDataSaida, Me.vPagamento, Me.vAtivo, Me.vFoto})
        Me.dgvFuncionarios.Location = New System.Drawing.Point(12, 290)
        Me.dgvFuncionarios.MultiSelect = False
        Me.dgvFuncionarios.Name = "dgvFuncionarios"
        Me.dgvFuncionarios.ReadOnly = True
        Me.dgvFuncionarios.RowHeadersVisible = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dgvFuncionarios.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFuncionarios.Size = New System.Drawing.Size(567, 207)
        Me.dgvFuncionarios.TabIndex = 1
        '
        'vCodigo
        '
        Me.vCodigo.DataPropertyName = "vCodigo"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.vCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.vCodigo.HeaderText = "Codigo"
        Me.vCodigo.Name = "vCodigo"
        Me.vCodigo.ReadOnly = True
        Me.vCodigo.Width = 70
        '
        'vNome
        '
        Me.vNome.DataPropertyName = "vNome"
        Me.vNome.HeaderText = "Nome"
        Me.vNome.Name = "vNome"
        Me.vNome.ReadOnly = True
        Me.vNome.Width = 300
        '
        'vCargo
        '
        Me.vCargo.DataPropertyName = "vCargo"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.vCargo.DefaultCellStyle = DataGridViewCellStyle3
        Me.vCargo.HeaderText = "Cargo"
        Me.vCargo.Name = "vCargo"
        Me.vCargo.ReadOnly = True
        Me.vCargo.Visible = False
        '
        'vDataEntrada
        '
        Me.vDataEntrada.DataPropertyName = "vDataEntrada"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.vDataEntrada.DefaultCellStyle = DataGridViewCellStyle4
        Me.vDataEntrada.HeaderText = "Data Entrada"
        Me.vDataEntrada.Name = "vDataEntrada"
        Me.vDataEntrada.ReadOnly = True
        '
        'vDataSaida
        '
        Me.vDataSaida.DataPropertyName = "vDataSaida"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.vDataSaida.DefaultCellStyle = DataGridViewCellStyle5
        Me.vDataSaida.HeaderText = "Data Saída"
        Me.vDataSaida.Name = "vDataSaida"
        Me.vDataSaida.ReadOnly = True
        Me.vDataSaida.Visible = False
        '
        'vPagamento
        '
        Me.vPagamento.DataPropertyName = "vPagamento"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.vPagamento.DefaultCellStyle = DataGridViewCellStyle6
        Me.vPagamento.HeaderText = "Pagamento"
        Me.vPagamento.Name = "vPagamento"
        Me.vPagamento.ReadOnly = True
        '
        'vAtivo
        '
        Me.vAtivo.DataPropertyName = "vAtivo"
        Me.vAtivo.HeaderText = "Ativo"
        Me.vAtivo.Name = "vAtivo"
        Me.vAtivo.ReadOnly = True
        Me.vAtivo.Visible = False
        '
        'vFoto
        '
        Me.vFoto.DataPropertyName = "vFoto"
        Me.vFoto.HeaderText = "Foto"
        Me.vFoto.Name = "vFoto"
        Me.vFoto.ReadOnly = True
        '
        'frm_CadFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 512)
        Me.Controls.Add(Me.dgvFuncionarios)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnInicial)
        Me.Controls.Add(Me.btnAjuda)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CadFuncionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Funcionários"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpSaida As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPagamento As System.Windows.Forms.TextBox
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnInicial As System.Windows.Forms.Button
    Friend WithEvents btnAjuda As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvFuncionarios As System.Windows.Forms.DataGridView
    Friend WithEvents vCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vCargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vDataEntrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vDataSaida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vPagamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vAtivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vFoto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelaFoto As System.Windows.Forms.Button
    Friend WithEvents btnPastaFoto As System.Windows.Forms.Button
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnLimpaFoto As System.Windows.Forms.Button
    Friend WithEvents btnTirarFoto As System.Windows.Forms.Button
    Friend WithEvents btnIniciarFoto As System.Windows.Forms.Button
End Class
