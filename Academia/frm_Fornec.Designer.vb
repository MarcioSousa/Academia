<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Fornec
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Fornec))
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.mtbTelCom = New System.Windows.Forms.MaskedTextBox()
        Me.mtbTelCel = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.dgvFornec = New System.Windows.Forms.DataGridView()
        Me.vCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vDataCadastro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vFoto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vObservacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vAtivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnInicial = New System.Windows.Forms.Button()
        Me.btnAjuda = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvFornec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 5)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 16)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "Código"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(7, 29)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCod.MaxLength = 40
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(71, 20)
        Me.txtCod.TabIndex = 59
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(82, 29)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNome.MaxLength = 30
        Me.txtNome.Name = "txtNome"
        Me.txtNome.ReadOnly = True
        Me.txtNome.Size = New System.Drawing.Size(216, 20)
        Me.txtNome.TabIndex = 54
        Me.txtNome.Text = "Roberta Almeida"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(7, 109)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 16)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Tel. Comercial"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.mtbTelCom)
        Me.Panel4.Controls.Add(Me.mtbTelCel)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.txtNome)
        Me.Panel4.Controls.Add(Me.txtCod)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txtEmpresa)
        Me.Panel4.Location = New System.Drawing.Point(11, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(310, 176)
        Me.Panel4.TabIndex = 61
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(165, 109)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 16)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "Tel. Celular"
        '
        'mtbTelCom
        '
        Me.mtbTelCom.Location = New System.Drawing.Point(7, 133)
        Me.mtbTelCom.Mask = "(99) 0000-0000"
        Me.mtbTelCom.Name = "mtbTelCom"
        Me.mtbTelCom.ReadOnly = True
        Me.mtbTelCom.Size = New System.Drawing.Size(114, 20)
        Me.mtbTelCom.TabIndex = 32
        Me.mtbTelCom.Text = "1111111111"
        '
        'mtbTelCel
        '
        Me.mtbTelCel.Location = New System.Drawing.Point(168, 133)
        Me.mtbTelCel.Mask = "(99)0 0000-0000"
        Me.mtbTelCel.Name = "mtbTelCel"
        Me.mtbTelCel.ReadOnly = True
        Me.mtbTelCel.Size = New System.Drawing.Size(130, 20)
        Me.mtbTelCel.TabIndex = 32
        Me.mtbTelCel.Text = "2222222222"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 57)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 16)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Empresa"
        '
        'txtEmpresa
        '
        Me.txtEmpresa.Location = New System.Drawing.Point(7, 81)
        Me.txtEmpresa.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtEmpresa.MaxLength = 30
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.ReadOnly = True
        Me.txtEmpresa.Size = New System.Drawing.Size(291, 20)
        Me.txtEmpresa.TabIndex = 61
        Me.txtEmpresa.Text = "Roberta Almeida"
        '
        'dgvFornec
        '
        Me.dgvFornec.AllowUserToAddRows = False
        Me.dgvFornec.AllowUserToDeleteRows = False
        Me.dgvFornec.AllowUserToResizeColumns = False
        Me.dgvFornec.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvFornec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFornec.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvFornec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFornec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vCodigo, Me.vNome, Me.vDataCadastro, Me.vFoto, Me.vObservacao, Me.vAtivo})
        Me.dgvFornec.Location = New System.Drawing.Point(331, 12)
        Me.dgvFornec.MultiSelect = False
        Me.dgvFornec.Name = "dgvFornec"
        Me.dgvFornec.ReadOnly = True
        Me.dgvFornec.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.dgvFornec.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFornec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFornec.Size = New System.Drawing.Size(453, 176)
        Me.dgvFornec.TabIndex = 62
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
        Me.vNome.HeaderText = "Nome do Fornecedor"
        Me.vNome.Name = "vNome"
        Me.vNome.ReadOnly = True
        Me.vNome.Width = 268
        '
        'vDataCadastro
        '
        Me.vDataCadastro.DataPropertyName = "vEmpresa"
        Me.vDataCadastro.HeaderText = "Empresa"
        Me.vDataCadastro.Name = "vDataCadastro"
        Me.vDataCadastro.ReadOnly = True
        Me.vDataCadastro.Visible = False
        '
        'vFoto
        '
        Me.vFoto.DataPropertyName = "vContatoUm"
        Me.vFoto.HeaderText = "Contato"
        Me.vFoto.Name = "vFoto"
        Me.vFoto.ReadOnly = True
        '
        'vObservacao
        '
        Me.vObservacao.DataPropertyName = "vContatoDois"
        Me.vObservacao.HeaderText = "Contato 2"
        Me.vObservacao.Name = "vObservacao"
        Me.vObservacao.ReadOnly = True
        Me.vObservacao.Visible = False
        '
        'vAtivo
        '
        Me.vAtivo.DataPropertyName = "vAtivo"
        Me.vAtivo.HeaderText = "Ativo"
        Me.vAtivo.Name = "vAtivo"
        Me.vAtivo.ReadOnly = True
        Me.vAtivo.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(395, 204)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 67
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(448, 204)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(47, 47)
        Me.btnExcluir.TabIndex = 66
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnInicial
        '
        Me.btnInicial.FlatAppearance.BorderSize = 0
        Me.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicial.Image = CType(resources.GetObject("btnInicial.Image"), System.Drawing.Image)
        Me.btnInicial.Location = New System.Drawing.Point(183, 204)
        Me.btnInicial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnInicial.Name = "btnInicial"
        Me.btnInicial.Size = New System.Drawing.Size(47, 47)
        Me.btnInicial.TabIndex = 64
        Me.btnInicial.UseVisualStyleBackColor = True
        '
        'btnAjuda
        '
        Me.btnAjuda.FlatAppearance.BorderSize = 0
        Me.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjuda.Image = CType(resources.GetObject("btnAjuda.Image"), System.Drawing.Image)
        Me.btnAjuda.Location = New System.Drawing.Point(236, 204)
        Me.btnAjuda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAjuda.Name = "btnAjuda"
        Me.btnAjuda.Size = New System.Drawing.Size(47, 47)
        Me.btnAjuda.TabIndex = 63
        Me.btnAjuda.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.Enabled = False
        Me.btnCancela.FlatAppearance.BorderSize = 0
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(554, 204)
        Me.btnCancela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(47, 47)
        Me.btnCancela.TabIndex = 70
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.Enabled = False
        Me.btnLimpa.FlatAppearance.BorderSize = 0
        Me.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpa.Image = CType(resources.GetObject("btnLimpa.Image"), System.Drawing.Image)
        Me.btnLimpa.Location = New System.Drawing.Point(289, 204)
        Me.btnLimpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(47, 47)
        Me.btnLimpa.TabIndex = 69
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'btnConfirma
        '
        Me.btnConfirma.Enabled = False
        Me.btnConfirma.FlatAppearance.BorderSize = 0
        Me.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirma.Image = CType(resources.GetObject("btnConfirma.Image"), System.Drawing.Image)
        Me.btnConfirma.Location = New System.Drawing.Point(501, 204)
        Me.btnConfirma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirma.TabIndex = 68
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.Location = New System.Drawing.Point(342, 204)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(47, 47)
        Me.btnNovo.TabIndex = 71
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'frm_CadFornec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 264)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnInicial)
        Me.Controls.Add(Me.btnAjuda)
        Me.Controls.Add(Me.dgvFornec)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CadFornec"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Fornecedores"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvFornec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents mtbTelCom As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbTelCel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents dgvFornec As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnInicial As System.Windows.Forms.Button
    Friend WithEvents btnAjuda As System.Windows.Forms.Button
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents vCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vDataCadastro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vFoto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vObservacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vAtivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNovo As System.Windows.Forms.Button
End Class
