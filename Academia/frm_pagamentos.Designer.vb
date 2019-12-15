<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_pagamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_pagamentos))
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.btnOkei = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtPesq = New System.Windows.Forms.TextBox()
        Me.dtpDataCad = New System.Windows.Forms.DateTimePicker()
        Me.mtbCep = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnDepois = New System.Windows.Forms.Button()
        Me.btnAntes = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbxCliente = New System.Windows.Forms.PictureBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.dgvMensalid = New System.Windows.Forms.DataGridView()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEfetPagam = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.CODPAG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MODALIDADES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JUROS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCONTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMensalid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualStyler1
        '
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "GUI Relax (Subtle).vssf")
        '
        'btnOkei
        '
        Me.btnOkei.AutoSize = True
        Me.btnOkei.Location = New System.Drawing.Point(395, 9)
        Me.btnOkei.Name = "btnOkei"
        Me.btnOkei.Size = New System.Drawing.Size(31, 25)
        Me.btnOkei.TabIndex = 105
        Me.btnOkei.Text = "Ok"
        Me.btnOkei.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtCodigo.Location = New System.Drawing.Point(182, 12)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(50, 24)
        Me.txtCodigo.TabIndex = 89
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Estrangelo Edessa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(292, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 17)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "Cód:"
        '
        'txtPesq
        '
        Me.txtPesq.BackColor = System.Drawing.SystemColors.Window
        Me.txtPesq.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtPesq.Location = New System.Drawing.Point(331, 11)
        Me.txtPesq.MaxLength = 5
        Me.txtPesq.Name = "txtPesq"
        Me.txtPesq.Size = New System.Drawing.Size(57, 24)
        Me.txtPesq.TabIndex = 103
        Me.txtPesq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpDataCad
        '
        Me.dtpDataCad.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.dtpDataCad.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataCad.Location = New System.Drawing.Point(138, 113)
        Me.dtpDataCad.Name = "dtpDataCad"
        Me.dtpDataCad.Size = New System.Drawing.Size(103, 24)
        Me.dtpDataCad.TabIndex = 93
        '
        'mtbCep
        '
        Me.mtbCep.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbCep.Location = New System.Drawing.Point(138, 80)
        Me.mtbCep.Mask = "00000-999"
        Me.mtbCep.Name = "mtbCep"
        Me.mtbCep.Size = New System.Drawing.Size(82, 24)
        Me.mtbCep.TabIndex = 92
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.Label16.Location = New System.Drawing.Point(13, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 16)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Data Cadastro:"
        '
        'btnDepois
        '
        Me.btnDepois.Location = New System.Drawing.Point(247, 10)
        Me.btnDepois.Name = "btnDepois"
        Me.btnDepois.Size = New System.Drawing.Size(29, 24)
        Me.btnDepois.TabIndex = 90
        Me.btnDepois.Text = ">"
        Me.btnDepois.UseVisualStyleBackColor = True
        '
        'btnAntes
        '
        Me.btnAntes.Location = New System.Drawing.Point(138, 10)
        Me.btnAntes.Name = "btnAntes"
        Me.btnAntes.Size = New System.Drawing.Size(29, 24)
        Me.btnAntes.TabIndex = 87
        Me.btnAntes.Text = "<"
        Me.btnAntes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Estrangelo Edessa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "CEP.:"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.SystemColors.Window
        Me.txtNome.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtNome.Location = New System.Drawing.Point(138, 45)
        Me.txtNome.MaxLength = 34
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(288, 24)
        Me.txtNome.TabIndex = 91
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Estrangelo Edessa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 17)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Nome do Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Estrangelo Edessa", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Código:"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(417, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(37, 130)
        Me.Panel1.TabIndex = 99
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(553, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(37, 130)
        Me.Panel2.TabIndex = 100
        '
        'pbxCliente
        '
        Me.pbxCliente.Location = New System.Drawing.Point(417, 6)
        Me.pbxCliente.Name = "pbxCliente"
        Me.pbxCliente.Size = New System.Drawing.Size(173, 130)
        Me.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCliente.TabIndex = 96
        Me.pbxCliente.TabStop = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.TextBox6.Location = New System.Drawing.Point(138, 79)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(83, 24)
        Me.TextBox6.TabIndex = 101
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.TextBox8.Location = New System.Drawing.Point(138, 112)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(104, 24)
        Me.TextBox8.TabIndex = 102
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(450, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'TextBox10
        '
        Me.TextBox10.Enabled = False
        Me.TextBox10.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.TextBox10.Location = New System.Drawing.Point(182, 11)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(51, 24)
        Me.TextBox10.TabIndex = 108
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox9
        '
        Me.TextBox9.Enabled = False
        Me.TextBox9.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.TextBox9.Location = New System.Drawing.Point(331, 10)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(58, 24)
        Me.TextBox9.TabIndex = 107
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox11
        '
        Me.TextBox11.Enabled = False
        Me.TextBox11.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.TextBox11.Location = New System.Drawing.Point(138, 44)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(289, 24)
        Me.TextBox11.TabIndex = 109
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgvMensalid
        '
        Me.dgvMensalid.AllowUserToAddRows = False
        Me.dgvMensalid.AllowUserToDeleteRows = False
        Me.dgvMensalid.AllowUserToResizeColumns = False
        Me.dgvMensalid.AllowUserToResizeRows = False
        Me.dgvMensalid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMensalid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODPAG, Me.MODALIDADES, Me.VALOR, Me.JUROS, Me.DESCONTO, Me.VENC, Me.PG})
        Me.dgvMensalid.Location = New System.Drawing.Point(16, 151)
        Me.dgvMensalid.MultiSelect = False
        Me.dgvMensalid.Name = "dgvMensalid"
        Me.dgvMensalid.RowHeadersVisible = False
        Me.dgvMensalid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMensalid.Size = New System.Drawing.Size(574, 176)
        Me.dgvMensalid.TabIndex = 110
        '
        'btnFechar
        '
        Me.btnFechar.Image = CType(resources.GetObject("btnFechar.Image"), System.Drawing.Image)
        Me.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.Location = New System.Drawing.Point(413, 376)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(81, 38)
        Me.btnFechar.TabIndex = 116
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.Location = New System.Drawing.Point(304, 376)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 38)
        Me.btnCancelar.TabIndex = 115
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.Location = New System.Drawing.Point(208, 376)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 38)
        Me.btnConfirmar.TabIndex = 114
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.Location = New System.Drawing.Point(112, 376)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(81, 38)
        Me.btnExcluir.TabIndex = 113
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEfetPagam
        '
        Me.btnEfetPagam.AutoSize = True
        Me.btnEfetPagam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEfetPagam.Location = New System.Drawing.Point(16, 333)
        Me.btnEfetPagam.Name = "btnEfetPagam"
        Me.btnEfetPagam.Size = New System.Drawing.Size(108, 29)
        Me.btnEfetPagam.TabIndex = 111
        Me.btnEfetPagam.Text = "Efetuar Pagamento"
        Me.btnEfetPagam.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.Location = New System.Drawing.Point(16, 376)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(81, 38)
        Me.btnAlterar.TabIndex = 112
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'CODPAG
        '
        Me.CODPAG.HeaderText = "CodPag"
        Me.CODPAG.Name = "CODPAG"
        Me.CODPAG.ReadOnly = True
        Me.CODPAG.Visible = False
        '
        'MODALIDADES
        '
        Me.MODALIDADES.HeaderText = "Modalidades"
        Me.MODALIDADES.Name = "MODALIDADES"
        Me.MODALIDADES.ReadOnly = True
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "Valor"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        '
        'JUROS
        '
        Me.JUROS.HeaderText = "Juros"
        Me.JUROS.Name = "JUROS"
        Me.JUROS.ReadOnly = True
        '
        'DESCONTO
        '
        Me.DESCONTO.HeaderText = "Desc."
        Me.DESCONTO.Name = "DESCONTO"
        Me.DESCONTO.ReadOnly = True
        '
        'VENC
        '
        Me.VENC.HeaderText = "Vencimento"
        Me.VENC.Name = "VENC"
        Me.VENC.ReadOnly = True
        '
        'PG
        '
        Me.PG.HeaderText = "Pg"
        Me.PG.Name = "PG"
        Me.PG.ReadOnly = True
        Me.PG.Width = 50
        '
        'frm_pagamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 424)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEfetPagam)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.dgvMensalid)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.btnOkei)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtPesq)
        Me.Controls.Add(Me.dtpDataCad)
        Me.Controls.Add(Me.mtbCep)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnDepois)
        Me.Controls.Add(Me.btnAntes)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pbxCliente)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_pagamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamentos"
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMensalid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
    Friend WithEvents btnOkei As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPesq As System.Windows.Forms.TextBox
    Friend WithEvents dtpDataCad As System.Windows.Forms.DateTimePicker
    Friend WithEvents mtbCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnDepois As System.Windows.Forms.Button
    Friend WithEvents btnAntes As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pbxCliente As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents dgvMensalid As System.Windows.Forms.DataGridView
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnEfetPagam As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents CODPAG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MODALIDADES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JUROS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCONTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VENC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PG As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
