<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_compras
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_compras))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvServicos = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbxCliente = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txtCodCli = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.txtpreco = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnFechar1 = New System.Windows.Forms.Button()
        Me.btnCancelar1 = New System.Windows.Forms.Button()
        Me.btnConfirmar1 = New System.Windows.Forms.Button()
        Me.btnExcluir1 = New System.Windows.Forms.Button()
        Me.btnAlterar1 = New System.Windows.Forms.Button()
        Me.mtbCPF = New System.Windows.Forms.MaskedTextBox()
        Me.cbxModalidades = New System.Windows.Forms.ComboBox()
        Me.cbxPacote = New System.Windows.Forms.ComboBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnNovo2 = New System.Windows.Forms.Button()
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.COD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODALIDADE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECOPACOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATACOMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        CType(Me.dgvServicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Nome do Cliente"
        '
        'btn3
        '
        Me.btn3.AutoSize = True
        Me.btn3.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(320, 34)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(38, 30)
        Me.btn3.TabIndex = 81
        Me.btn3.Text = "..."
        Me.btn3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Modalidade"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(46, 169)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(131, 20)
        Me.TextBox3.TabIndex = 85
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(207, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Pacote"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(575, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Preço"
        '
        'dgvServicos
        '
        Me.dgvServicos.AllowUserToAddRows = False
        Me.dgvServicos.AllowUserToDeleteRows = False
        Me.dgvServicos.AllowUserToResizeColumns = False
        Me.dgvServicos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Humnst777 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COD, Me.MODALIDADE, Me.PACOTE, Me.PRECOPACOTE, Me.DATACOMPRA})
        Me.dgvServicos.Location = New System.Drawing.Point(16, 255)
        Me.dgvServicos.MultiSelect = False
        Me.dgvServicos.Name = "dgvServicos"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServicos.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!)
        Me.dgvServicos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServicos.Size = New System.Drawing.Size(696, 147)
        Me.dgvServicos.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Humnst777 Blk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(297, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 16)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Pacotes Adquiridos ao Cliente"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Humnst777 Blk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(378, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 20)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Cliente"
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.FlatAppearance.BorderSize = 0
        Me.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.Location = New System.Drawing.Point(551, 408)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(115, 50)
        Me.btnFechar.TabIndex = 99
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(430, 408)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 50)
        Me.btnCancelar.TabIndex = 98
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.AutoSize = True
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.Location = New System.Drawing.Point(309, 408)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(115, 50)
        Me.btnConfirmar.TabIndex = 97
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.AutoSize = True
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(188, 408)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(115, 50)
        Me.btnExcluir.TabIndex = 96
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.AutoSize = True
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.Location = New System.Drawing.Point(67, 408)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(115, 50)
        Me.btnAlterar.TabIndex = 95
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(515, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(37, 130)
        Me.Panel1.TabIndex = 103
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(651, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(37, 130)
        Me.Panel2.TabIndex = 104
        '
        'pbxCliente
        '
        Me.pbxCliente.Location = New System.Drawing.Point(515, 8)
        Me.pbxCliente.Name = "pbxCliente"
        Me.pbxCliente.Size = New System.Drawing.Size(173, 130)
        Me.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCliente.TabIndex = 102
        Me.pbxCliente.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(204, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(46, 37)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(255, 20)
        Me.txtNome.TabIndex = 110
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(35, 32)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(279, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'txtCodCli
        '
        Me.txtCodCli.BackColor = System.Drawing.Color.White
        Me.txtCodCli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodCli.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCli.Location = New System.Drawing.Point(376, 37)
        Me.txtCodCli.MaxLength = 6
        Me.txtCodCli.Name = "txtCodCli"
        Me.txtCodCli.Size = New System.Drawing.Size(72, 20)
        Me.txtCodCli.TabIndex = 111
        Me.txtCodCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(366, 32)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(97, 34)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 112
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(35, 89)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(155, 34)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 113
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(35, 164)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(155, 34)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 116
        Me.PictureBox6.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(211, 170)
        Me.TextBox6.MaxLength = 40
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(288, 20)
        Me.TextBox6.TabIndex = 117
        '
        'txtpreco
        '
        Me.txtpreco.BackColor = System.Drawing.Color.White
        Me.txtpreco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpreco.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreco.Location = New System.Drawing.Point(537, 170)
        Me.txtpreco.MaxLength = 12
        Me.txtpreco.Name = "txtpreco"
        Me.txtpreco.ReadOnly = True
        Me.txtpreco.Size = New System.Drawing.Size(131, 20)
        Me.txtpreco.TabIndex = 118
        Me.txtpreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(526, 164)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(155, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 119
        Me.PictureBox2.TabStop = False
        '
        'btnFechar1
        '
        Me.btnFechar1.AutoSize = True
        Me.btnFechar1.FlatAppearance.BorderSize = 0
        Me.btnFechar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFechar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFechar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFechar1.Image = CType(resources.GetObject("btnFechar1.Image"), System.Drawing.Image)
        Me.btnFechar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar1.Location = New System.Drawing.Point(551, 408)
        Me.btnFechar1.Name = "btnFechar1"
        Me.btnFechar1.Size = New System.Drawing.Size(115, 50)
        Me.btnFechar1.TabIndex = 125
        Me.btnFechar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFechar1.UseVisualStyleBackColor = True
        '
        'btnCancelar1
        '
        Me.btnCancelar1.AutoSize = True
        Me.btnCancelar1.FlatAppearance.BorderSize = 0
        Me.btnCancelar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancelar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar1.Image = CType(resources.GetObject("btnCancelar1.Image"), System.Drawing.Image)
        Me.btnCancelar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar1.Location = New System.Drawing.Point(430, 408)
        Me.btnCancelar1.Name = "btnCancelar1"
        Me.btnCancelar1.Size = New System.Drawing.Size(115, 50)
        Me.btnCancelar1.TabIndex = 124
        Me.btnCancelar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar1.UseVisualStyleBackColor = True
        '
        'btnConfirmar1
        '
        Me.btnConfirmar1.AutoSize = True
        Me.btnConfirmar1.FlatAppearance.BorderSize = 0
        Me.btnConfirmar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConfirmar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConfirmar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar1.Image = CType(resources.GetObject("btnConfirmar1.Image"), System.Drawing.Image)
        Me.btnConfirmar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar1.Location = New System.Drawing.Point(309, 408)
        Me.btnConfirmar1.Name = "btnConfirmar1"
        Me.btnConfirmar1.Size = New System.Drawing.Size(115, 50)
        Me.btnConfirmar1.TabIndex = 123
        Me.btnConfirmar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar1.UseVisualStyleBackColor = True
        '
        'btnExcluir1
        '
        Me.btnExcluir1.AutoSize = True
        Me.btnExcluir1.FlatAppearance.BorderSize = 0
        Me.btnExcluir1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExcluir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir1.Image = CType(resources.GetObject("btnExcluir1.Image"), System.Drawing.Image)
        Me.btnExcluir1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir1.Location = New System.Drawing.Point(188, 408)
        Me.btnExcluir1.Name = "btnExcluir1"
        Me.btnExcluir1.Size = New System.Drawing.Size(115, 50)
        Me.btnExcluir1.TabIndex = 122
        Me.btnExcluir1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir1.UseVisualStyleBackColor = True
        '
        'btnAlterar1
        '
        Me.btnAlterar1.AutoSize = True
        Me.btnAlterar1.FlatAppearance.BorderSize = 0
        Me.btnAlterar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAlterar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnAlterar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar1.Image = CType(resources.GetObject("btnAlterar1.Image"), System.Drawing.Image)
        Me.btnAlterar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar1.Location = New System.Drawing.Point(67, 408)
        Me.btnAlterar1.Name = "btnAlterar1"
        Me.btnAlterar1.Size = New System.Drawing.Size(115, 50)
        Me.btnAlterar1.TabIndex = 121
        Me.btnAlterar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar1.UseVisualStyleBackColor = True
        '
        'mtbCPF
        '
        Me.mtbCPF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbCPF.Font = New System.Drawing.Font("Humnst777 BT", 12.0!)
        Me.mtbCPF.Location = New System.Drawing.Point(46, 95)
        Me.mtbCPF.Mask = "000.000.000-99"
        Me.mtbCPF.Name = "mtbCPF"
        Me.mtbCPF.Size = New System.Drawing.Size(131, 20)
        Me.mtbCPF.TabIndex = 127
        Me.mtbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbxModalidades
        '
        Me.cbxModalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxModalidades.Font = New System.Drawing.Font("Humnst777 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModalidades.FormattingEnabled = True
        Me.cbxModalidades.Location = New System.Drawing.Point(46, 166)
        Me.cbxModalidades.Name = "cbxModalidades"
        Me.cbxModalidades.Size = New System.Drawing.Size(131, 27)
        Me.cbxModalidades.TabIndex = 128
        '
        'cbxPacote
        '
        Me.cbxPacote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPacote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxPacote.Font = New System.Drawing.Font("Humnst777 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPacote.FormattingEnabled = True
        Me.cbxPacote.Location = New System.Drawing.Point(220, 167)
        Me.cbxPacote.Name = "cbxPacote"
        Me.cbxPacote.Size = New System.Drawing.Size(275, 27)
        Me.cbxPacote.TabIndex = 129
        '
        'btnNovo
        '
        Me.btnNovo.AutoSize = True
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.Location = New System.Drawing.Point(599, 201)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(115, 50)
        Me.btnNovo.TabIndex = 130
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnNovo2
        '
        Me.btnNovo2.AutoSize = True
        Me.btnNovo2.FlatAppearance.BorderSize = 0
        Me.btnNovo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNovo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNovo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo2.Image = CType(resources.GetObject("btnNovo2.Image"), System.Drawing.Image)
        Me.btnNovo2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo2.Location = New System.Drawing.Point(599, 201)
        Me.btnNovo2.Name = "btnNovo2"
        Me.btnNovo2.Size = New System.Drawing.Size(115, 50)
        Me.btnNovo2.TabIndex = 131
        Me.btnNovo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo2.UseVisualStyleBackColor = True
        '
        'VisualStyler1
        '
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "GUI Relax (Subtle).vssf")
        '
        'COD
        '
        Me.COD.HeaderText = "Cod_Compra"
        Me.COD.Name = "COD"
        Me.COD.ReadOnly = True
        Me.COD.Width = 40
        '
        'MODALIDADE
        '
        Me.MODALIDADE.HeaderText = "Modalidade"
        Me.MODALIDADE.MaxInputLength = 40
        Me.MODALIDADE.Name = "MODALIDADE"
        Me.MODALIDADE.ReadOnly = True
        Me.MODALIDADE.Width = 150
        '
        'PACOTE
        '
        Me.PACOTE.HeaderText = "Pacote"
        Me.PACOTE.MaxInputLength = 40
        Me.PACOTE.Name = "PACOTE"
        Me.PACOTE.ReadOnly = True
        Me.PACOTE.Width = 230
        '
        'PRECOPACOTE
        '
        Me.PRECOPACOTE.HeaderText = "Valor do Pacote"
        Me.PRECOPACOTE.MaxInputLength = 20
        Me.PRECOPACOTE.Name = "PRECOPACOTE"
        Me.PRECOPACOTE.ReadOnly = True
        Me.PRECOPACOTE.Width = 145
        '
        'DATACOMPRA
        '
        Me.DATACOMPRA.HeaderText = "Data Matríc."
        Me.DATACOMPRA.MaxInputLength = 30
        Me.DATACOMPRA.Name = "DATACOMPRA"
        Me.DATACOMPRA.ReadOnly = True
        Me.DATACOMPRA.Width = 145
        '
        'txtCompra
        '
        Me.txtCompra.BackColor = System.Drawing.Color.White
        Me.txtCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompra.Font = New System.Drawing.Font("Humnst777 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompra.Location = New System.Drawing.Point(545, 215)
        Me.txtCompra.MaxLength = 12
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.ReadOnly = True
        Me.txtCompra.Size = New System.Drawing.Size(48, 20)
        Me.txtCompra.TabIndex = 132
        Me.txtCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 467)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.cbxPacote)
        Me.Controls.Add(Me.cbxModalidades)
        Me.Controls.Add(Me.mtbCPF)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpreco)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.txtCodCli)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbxCliente)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvServicos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnFechar1)
        Me.Controls.Add(Me.btnCancelar1)
        Me.Controls.Add(Me.btnConfirmar1)
        Me.Controls.Add(Me.btnExcluir1)
        Me.Controls.Add(Me.btnAlterar1)
        Me.Controls.Add(Me.btnNovo2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compras"
        CType(Me.dgvServicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgvServicos As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pbxCliente As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtCodCli As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents txtpreco As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnFechar1 As System.Windows.Forms.Button
    Friend WithEvents btnCancelar1 As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar1 As System.Windows.Forms.Button
    Friend WithEvents btnExcluir1 As System.Windows.Forms.Button
    Friend WithEvents btnAlterar1 As System.Windows.Forms.Button
    Friend WithEvents mtbCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cbxModalidades As System.Windows.Forms.ComboBox
    Friend WithEvents cbxPacote As System.Windows.Forms.ComboBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnNovo2 As System.Windows.Forms.Button
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
    Friend WithEvents COD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODALIDADE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRECOPACOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DATACOMPRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCompra As System.Windows.Forms.TextBox
End Class
