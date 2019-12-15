<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Aula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Aula))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnDuvida = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.dgvAulas = New System.Windows.Forms.DataGridView()
        Me.CodAula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aulaNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODPROF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFuncionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaAtivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AulaFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelaFoto = New System.Windows.Forms.Button()
        Me.pnlCadastro = New System.Windows.Forms.Panel()
        Me.btnFuncionarioLimpa = New System.Windows.Forms.Button()
        Me.btnFuncionarioMais = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAula = New System.Windows.Forms.TextBox()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodAulas = New System.Windows.Forms.TextBox()
        Me.cbxProfessor = New System.Windows.Forms.ComboBox()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPastaFoto = New System.Windows.Forms.Button()
        Me.btnLimpaFoto = New System.Windows.Forms.Button()
        Me.btnIniciarFoto = New System.Windows.Forms.Button()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgvAulas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlCadastro.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancela
        '
        Me.btnCancela.Enabled = False
        Me.btnCancela.FlatAppearance.BorderSize = 0
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(483, 236)
        Me.btnCancela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(47, 47)
        Me.btnCancela.TabIndex = 39
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(324, 236)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 44
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(377, 236)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(47, 47)
        Me.btnExcluir.TabIndex = 45
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(271, 236)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(47, 47)
        Me.btnAdicionar.TabIndex = 43
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.Enabled = False
        Me.btnLimpa.FlatAppearance.BorderSize = 0
        Me.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpa.Image = CType(resources.GetObject("btnLimpa.Image"), System.Drawing.Image)
        Me.btnLimpa.Location = New System.Drawing.Point(218, 236)
        Me.btnLimpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(47, 47)
        Me.btnLimpa.TabIndex = 40
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderSize = 0
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Image = CType(resources.GetObject("btnInicio.Image"), System.Drawing.Image)
        Me.btnInicio.Location = New System.Drawing.Point(112, 236)
        Me.btnInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(47, 47)
        Me.btnInicio.TabIndex = 42
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnDuvida
        '
        Me.btnDuvida.FlatAppearance.BorderSize = 0
        Me.btnDuvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuvida.Image = CType(resources.GetObject("btnDuvida.Image"), System.Drawing.Image)
        Me.btnDuvida.Location = New System.Drawing.Point(165, 236)
        Me.btnDuvida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDuvida.Name = "btnDuvida"
        Me.btnDuvida.Size = New System.Drawing.Size(47, 47)
        Me.btnDuvida.TabIndex = 41
        Me.btnDuvida.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(430, 236)
        Me.btnConfirmar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirmar.TabIndex = 38
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'dgvAulas
        '
        Me.dgvAulas.AllowUserToAddRows = False
        Me.dgvAulas.AllowUserToDeleteRows = False
        Me.dgvAulas.AllowUserToResizeColumns = False
        Me.dgvAulas.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvAulas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvAulas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvAulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAulas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodAula, Me.aulaNome, Me.AulaCategoria, Me.AulaInicio, Me.CODPROF, Me.NomeFuncionario, Me.AulaValor, Me.AulaAtivo, Me.AulaFoto})
        Me.dgvAulas.Location = New System.Drawing.Point(49, 290)
        Me.dgvAulas.MultiSelect = False
        Me.dgvAulas.Name = "dgvAulas"
        Me.dgvAulas.RowHeadersVisible = False
        Me.dgvAulas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAulas.Size = New System.Drawing.Size(560, 217)
        Me.dgvAulas.TabIndex = 46
        '
        'CodAula
        '
        Me.CodAula.DataPropertyName = "vCodigo"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Red
        Me.CodAula.DefaultCellStyle = DataGridViewCellStyle14
        Me.CodAula.HeaderText = "Codigo"
        Me.CodAula.Name = "CodAula"
        Me.CodAula.ReadOnly = True
        Me.CodAula.Width = 60
        '
        'aulaNome
        '
        Me.aulaNome.DataPropertyName = "vNome"
        Me.aulaNome.HeaderText = "Aula"
        Me.aulaNome.Name = "aulaNome"
        Me.aulaNome.ReadOnly = True
        Me.aulaNome.Width = 200
        '
        'AulaCategoria
        '
        Me.AulaCategoria.DataPropertyName = "vCategoria"
        Me.AulaCategoria.HeaderText = "Categoria"
        Me.AulaCategoria.Name = "AulaCategoria"
        Me.AulaCategoria.ReadOnly = True
        Me.AulaCategoria.Visible = False
        '
        'AulaInicio
        '
        Me.AulaInicio.DataPropertyName = "vInicio"
        Me.AulaInicio.HeaderText = "Inicio"
        Me.AulaInicio.Name = "AulaInicio"
        Me.AulaInicio.ReadOnly = True
        Me.AulaInicio.Visible = False
        '
        'CODPROF
        '
        Me.CODPROF.DataPropertyName = "vCodigoFuncionario"
        Me.CODPROF.HeaderText = "Cod."
        Me.CODPROF.Name = "CODPROF"
        Me.CODPROF.ReadOnly = True
        Me.CODPROF.Visible = False
        Me.CODPROF.Width = 60
        '
        'NomeFuncionario
        '
        Me.NomeFuncionario.DataPropertyName = "vNomeFuncionario"
        Me.NomeFuncionario.HeaderText = "Professor"
        Me.NomeFuncionario.Name = "NomeFuncionario"
        Me.NomeFuncionario.ReadOnly = True
        Me.NomeFuncionario.Width = 200
        '
        'AulaValor
        '
        Me.AulaValor.DataPropertyName = "vPreco"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.AulaValor.DefaultCellStyle = DataGridViewCellStyle15
        Me.AulaValor.HeaderText = "Valor"
        Me.AulaValor.Name = "AulaValor"
        Me.AulaValor.ReadOnly = True
        Me.AulaValor.Width = 80
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnCancelaFoto)
        Me.Panel2.Controls.Add(Me.pnlCadastro)
        Me.Panel2.Controls.Add(Me.btnPastaFoto)
        Me.Panel2.Controls.Add(Me.btnLimpaFoto)
        Me.Panel2.Controls.Add(Me.btnIniciarFoto)
        Me.Panel2.Controls.Add(Me.btnTirarFoto)
        Me.Panel2.Controls.Add(Me.pbxFoto)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 217)
        Me.Panel2.TabIndex = 37
        '
        'btnCancelaFoto
        '
        Me.btnCancelaFoto.AutoSize = True
        Me.btnCancelaFoto.Enabled = False
        Me.btnCancelaFoto.FlatAppearance.BorderSize = 0
        Me.btnCancelaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelaFoto.Image = CType(resources.GetObject("btnCancelaFoto.Image"), System.Drawing.Image)
        Me.btnCancelaFoto.Location = New System.Drawing.Point(50, 166)
        Me.btnCancelaFoto.Name = "btnCancelaFoto"
        Me.btnCancelaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnCancelaFoto.TabIndex = 49
        Me.btnCancelaFoto.UseVisualStyleBackColor = True
        '
        'pnlCadastro
        '
        Me.pnlCadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCadastro.Controls.Add(Me.btnFuncionarioLimpa)
        Me.pnlCadastro.Controls.Add(Me.btnFuncionarioMais)
        Me.pnlCadastro.Controls.Add(Me.Label7)
        Me.pnlCadastro.Controls.Add(Me.Label10)
        Me.pnlCadastro.Controls.Add(Me.Label9)
        Me.pnlCadastro.Controls.Add(Me.txtAula)
        Me.pnlCadastro.Controls.Add(Me.dtpInicio)
        Me.pnlCadastro.Controls.Add(Me.Label8)
        Me.pnlCadastro.Controls.Add(Me.Label2)
        Me.pnlCadastro.Controls.Add(Me.txtCodAulas)
        Me.pnlCadastro.Controls.Add(Me.cbxProfessor)
        Me.pnlCadastro.Controls.Add(Me.txtPreco)
        Me.pnlCadastro.Controls.Add(Me.txtCategoria)
        Me.pnlCadastro.Controls.Add(Me.Label18)
        Me.pnlCadastro.Controls.Add(Me.Label1)
        Me.pnlCadastro.Location = New System.Drawing.Point(238, -2)
        Me.pnlCadastro.Name = "pnlCadastro"
        Me.pnlCadastro.Size = New System.Drawing.Size(406, 217)
        Me.pnlCadastro.TabIndex = 48
        '
        'btnFuncionarioLimpa
        '
        Me.btnFuncionarioLimpa.Enabled = False
        Me.btnFuncionarioLimpa.FlatAppearance.BorderSize = 0
        Me.btnFuncionarioLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarioLimpa.Image = CType(resources.GetObject("btnFuncionarioLimpa.Image"), System.Drawing.Image)
        Me.btnFuncionarioLimpa.Location = New System.Drawing.Point(244, 144)
        Me.btnFuncionarioLimpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFuncionarioLimpa.Name = "btnFuncionarioLimpa"
        Me.btnFuncionarioLimpa.Size = New System.Drawing.Size(25, 24)
        Me.btnFuncionarioLimpa.TabIndex = 47
        Me.btnFuncionarioLimpa.UseVisualStyleBackColor = True
        '
        'btnFuncionarioMais
        '
        Me.btnFuncionarioMais.Enabled = False
        Me.btnFuncionarioMais.FlatAppearance.BorderSize = 0
        Me.btnFuncionarioMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarioMais.Image = CType(resources.GetObject("btnFuncionarioMais.Image"), System.Drawing.Image)
        Me.btnFuncionarioMais.Location = New System.Drawing.Point(213, 143)
        Me.btnFuncionarioMais.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFuncionarioMais.Name = "btnFuncionarioMais"
        Me.btnFuncionarioMais.Size = New System.Drawing.Size(25, 25)
        Me.btnFuncionarioMais.TabIndex = 47
        Me.btnFuncionarioMais.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Código"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(105, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Aula"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(276, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Início"
        '
        'txtAula
        '
        Me.txtAula.Location = New System.Drawing.Point(104, 50)
        Me.txtAula.MaxLength = 30
        Me.txtAula.Name = "txtAula"
        Me.txtAula.ReadOnly = True
        Me.txtAula.Size = New System.Drawing.Size(281, 23)
        Me.txtAula.TabIndex = 1
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(278, 95)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(107, 23)
        Me.dtpInicio.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Professor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "R$"
        '
        'txtCodAulas
        '
        Me.txtCodAulas.Location = New System.Drawing.Point(19, 50)
        Me.txtCodAulas.Name = "txtCodAulas"
        Me.txtCodAulas.ReadOnly = True
        Me.txtCodAulas.Size = New System.Drawing.Size(79, 23)
        Me.txtCodAulas.TabIndex = 0
        '
        'cbxProfessor
        '
        Me.cbxProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfessor.Enabled = False
        Me.cbxProfessor.FormattingEnabled = True
        Me.cbxProfessor.Items.AddRange(New Object() {"Selecione"})
        Me.cbxProfessor.Location = New System.Drawing.Point(19, 144)
        Me.cbxProfessor.Name = "cbxProfessor"
        Me.cbxProfessor.Size = New System.Drawing.Size(188, 24)
        Me.cbxProfessor.TabIndex = 41
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(306, 144)
        Me.txtPreco.MaxLength = 7
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.ReadOnly = True
        Me.txtPreco.Size = New System.Drawing.Size(79, 23)
        Me.txtPreco.TabIndex = 4
        Me.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(19, 95)
        Me.txtCategoria.MaxLength = 30
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.ReadOnly = True
        Me.txtCategoria.Size = New System.Drawing.Size(253, 23)
        Me.txtCategoria.TabIndex = 39
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(276, 126)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 16)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Preço"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Categoria"
        '
        'btnPastaFoto
        '
        Me.btnPastaFoto.AutoSize = True
        Me.btnPastaFoto.Enabled = False
        Me.btnPastaFoto.FlatAppearance.BorderSize = 0
        Me.btnPastaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastaFoto.Image = CType(resources.GetObject("btnPastaFoto.Image"), System.Drawing.Image)
        Me.btnPastaFoto.Location = New System.Drawing.Point(191, 166)
        Me.btnPastaFoto.Name = "btnPastaFoto"
        Me.btnPastaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnPastaFoto.TabIndex = 47
        Me.btnPastaFoto.UseVisualStyleBackColor = True
        '
        'btnLimpaFoto
        '
        Me.btnLimpaFoto.AutoSize = True
        Me.btnLimpaFoto.Enabled = False
        Me.btnLimpaFoto.FlatAppearance.BorderSize = 0
        Me.btnLimpaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpaFoto.Image = CType(resources.GetObject("btnLimpaFoto.Image"), System.Drawing.Image)
        Me.btnLimpaFoto.Location = New System.Drawing.Point(144, 166)
        Me.btnLimpaFoto.Name = "btnLimpaFoto"
        Me.btnLimpaFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnLimpaFoto.TabIndex = 46
        Me.btnLimpaFoto.UseVisualStyleBackColor = True
        '
        'btnIniciarFoto
        '
        Me.btnIniciarFoto.AutoSize = True
        Me.btnIniciarFoto.Enabled = False
        Me.btnIniciarFoto.FlatAppearance.BorderSize = 0
        Me.btnIniciarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciarFoto.Image = CType(resources.GetObject("btnIniciarFoto.Image"), System.Drawing.Image)
        Me.btnIniciarFoto.Location = New System.Drawing.Point(3, 166)
        Me.btnIniciarFoto.Name = "btnIniciarFoto"
        Me.btnIniciarFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnIniciarFoto.TabIndex = 45
        Me.btnIniciarFoto.UseVisualStyleBackColor = True
        '
        'btnTirarFoto
        '
        Me.btnTirarFoto.AutoSize = True
        Me.btnTirarFoto.Enabled = False
        Me.btnTirarFoto.FlatAppearance.BorderSize = 0
        Me.btnTirarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTirarFoto.Image = CType(resources.GetObject("btnTirarFoto.Image"), System.Drawing.Image)
        Me.btnTirarFoto.Location = New System.Drawing.Point(97, 166)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(41, 41)
        Me.btnTirarFoto.TabIndex = 44
        Me.btnTirarFoto.UseVisualStyleBackColor = True
        '
        'pbxFoto
        '
        Me.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxFoto.Image = CType(resources.GetObject("pbxFoto.Image"), System.Drawing.Image)
        Me.pbxFoto.Location = New System.Drawing.Point(19, 10)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(200, 150)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 43
        Me.pbxFoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Png (*.png)|*.png|Jpeg(*.jpg)|*.jpg"
        '
        'frm_CadAula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 520)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.btnDuvida)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvAulas)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CadAula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Aulas"
        CType(Me.dgvAulas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlCadastro.ResumeLayout(False)
        Me.pnlCadastro.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnDuvida As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents dgvAulas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPreco As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAulas As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAula As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxProfessor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents pnlCadastro As System.Windows.Forms.Panel
    Friend WithEvents btnPastaFoto As System.Windows.Forms.Button
    Friend WithEvents btnLimpaFoto As System.Windows.Forms.Button
    Friend WithEvents btnIniciarFoto As System.Windows.Forms.Button
    Friend WithEvents btnTirarFoto As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnFuncionarioMais As System.Windows.Forms.Button
    Friend WithEvents btnFuncionarioLimpa As System.Windows.Forms.Button
    Friend WithEvents CodAula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents aulaNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODPROF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeFuncionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaValor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaAtivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AulaFoto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelaFoto As System.Windows.Forms.Button
End Class
