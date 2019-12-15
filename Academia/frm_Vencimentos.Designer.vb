<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Vencimentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Vencimentos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtNomeProd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtdeAtual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQtdeMinima = New System.Windows.Forms.TextBox()
        Me.btnPastaFoto = New System.Windows.Forms.Button()
        Me.btnLimpaFoto = New System.Windows.Forms.Button()
        Me.btnIniciarFoto = New System.Windows.Forms.Button()
        Me.btnTirarFoto = New System.Windows.Forms.Button()
        Me.pbxFoto = New System.Windows.Forms.PictureBox()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnCasa = New System.Windows.Forms.Button()
        Me.btnDuvida = New System.Windows.Forms.Button()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.dgvProduto = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btnPastaFoto)
        Me.Panel2.Controls.Add(Me.btnLimpaFoto)
        Me.Panel2.Controls.Add(Me.btnIniciarFoto)
        Me.Panel2.Controls.Add(Me.btnTirarFoto)
        Me.Panel2.Controls.Add(Me.pbxFoto)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 175)
        Me.Panel2.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.dtpCadastro)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtNomeProd)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtQtdeAtual)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtQtdeMinima)
        Me.Panel1.Location = New System.Drawing.Point(264, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 175)
        Me.Panel1.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(277, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Entrada"
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Enabled = False
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCadastro.Location = New System.Drawing.Point(280, 55)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(107, 23)
        Me.dtpCadastro.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Produto"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(280, 100)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 23)
        Me.DateTimePicker1.TabIndex = 48
        '
        'txtNomeProd
        '
        Me.txtNomeProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeProd.Enabled = False
        Me.txtNomeProd.Location = New System.Drawing.Point(14, 55)
        Me.txtNomeProd.Name = "txtNomeProd"
        Me.txtNomeProd.Size = New System.Drawing.Size(260, 23)
        Me.txtNomeProd.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(277, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Vencimento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Qtde Atual"
        '
        'txtQtdeAtual
        '
        Me.txtQtdeAtual.Enabled = False
        Me.txtQtdeAtual.Location = New System.Drawing.Point(14, 100)
        Me.txtQtdeAtual.MaxLength = 8
        Me.txtQtdeAtual.Name = "txtQtdeAtual"
        Me.txtQtdeAtual.Size = New System.Drawing.Size(86, 23)
        Me.txtQtdeAtual.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Qtde Mínima"
        '
        'txtQtdeMinima
        '
        Me.txtQtdeMinima.Enabled = False
        Me.txtQtdeMinima.Location = New System.Drawing.Point(145, 100)
        Me.txtQtdeMinima.MaxLength = 8
        Me.txtQtdeMinima.Name = "txtQtdeMinima"
        Me.txtQtdeMinima.Size = New System.Drawing.Size(86, 23)
        Me.txtQtdeMinima.TabIndex = 7
        '
        'btnPastaFoto
        '
        Me.btnPastaFoto.AutoSize = True
        Me.btnPastaFoto.Enabled = False
        Me.btnPastaFoto.FlatAppearance.BorderSize = 0
        Me.btnPastaFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPastaFoto.Image = CType(resources.GetObject("btnPastaFoto.Image"), System.Drawing.Image)
        Me.btnPastaFoto.Location = New System.Drawing.Point(217, 131)
        Me.btnPastaFoto.Name = "btnPastaFoto"
        Me.btnPastaFoto.Size = New System.Drawing.Size(41, 35)
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
        Me.btnLimpaFoto.Location = New System.Drawing.Point(217, 89)
        Me.btnLimpaFoto.Name = "btnLimpaFoto"
        Me.btnLimpaFoto.Size = New System.Drawing.Size(41, 36)
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
        Me.btnIniciarFoto.Location = New System.Drawing.Point(217, 5)
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
        Me.btnTirarFoto.Location = New System.Drawing.Point(217, 50)
        Me.btnTirarFoto.Name = "btnTirarFoto"
        Me.btnTirarFoto.Size = New System.Drawing.Size(41, 33)
        Me.btnTirarFoto.TabIndex = 51
        Me.btnTirarFoto.UseVisualStyleBackColor = True
        '
        'pbxFoto
        '
        Me.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbxFoto.Image = CType(resources.GetObject("pbxFoto.Image"), System.Drawing.Image)
        Me.pbxFoto.Location = New System.Drawing.Point(11, 11)
        Me.pbxFoto.Name = "pbxFoto"
        Me.pbxFoto.Size = New System.Drawing.Size(200, 150)
        Me.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFoto.TabIndex = 50
        Me.pbxFoto.TabStop = False
        '
        'btnCancela
        '
        Me.btnCancela.Enabled = False
        Me.btnCancela.FlatAppearance.BorderSize = 0
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(506, 194)
        Me.btnCancela.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(47, 47)
        Me.btnCancela.TabIndex = 37
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(347, 194)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 42
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(400, 194)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(47, 47)
        Me.btnExcluir.TabIndex = 43
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.FlatAppearance.BorderSize = 0
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(294, 194)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(47, 47)
        Me.btnAdicionar.TabIndex = 41
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnLimpa
        '
        Me.btnLimpa.Enabled = False
        Me.btnLimpa.FlatAppearance.BorderSize = 0
        Me.btnLimpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpa.Image = CType(resources.GetObject("btnLimpa.Image"), System.Drawing.Image)
        Me.btnLimpa.Location = New System.Drawing.Point(241, 194)
        Me.btnLimpa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLimpa.Name = "btnLimpa"
        Me.btnLimpa.Size = New System.Drawing.Size(47, 47)
        Me.btnLimpa.TabIndex = 38
        Me.btnLimpa.UseVisualStyleBackColor = True
        '
        'btnCasa
        '
        Me.btnCasa.FlatAppearance.BorderSize = 0
        Me.btnCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCasa.Image = CType(resources.GetObject("btnCasa.Image"), System.Drawing.Image)
        Me.btnCasa.Location = New System.Drawing.Point(135, 194)
        Me.btnCasa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCasa.Name = "btnCasa"
        Me.btnCasa.Size = New System.Drawing.Size(47, 47)
        Me.btnCasa.TabIndex = 40
        Me.btnCasa.UseVisualStyleBackColor = True
        '
        'btnDuvida
        '
        Me.btnDuvida.FlatAppearance.BorderSize = 0
        Me.btnDuvida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDuvida.Image = CType(resources.GetObject("btnDuvida.Image"), System.Drawing.Image)
        Me.btnDuvida.Location = New System.Drawing.Point(188, 194)
        Me.btnDuvida.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDuvida.Name = "btnDuvida"
        Me.btnDuvida.Size = New System.Drawing.Size(47, 47)
        Me.btnDuvida.TabIndex = 39
        Me.btnDuvida.UseVisualStyleBackColor = True
        '
        'btnConfirma
        '
        Me.btnConfirma.Enabled = False
        Me.btnConfirma.FlatAppearance.BorderSize = 0
        Me.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirma.Image = CType(resources.GetObject("btnConfirma.Image"), System.Drawing.Image)
        Me.btnConfirma.Location = New System.Drawing.Point(453, 194)
        Me.btnConfirma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnConfirma.Name = "btnConfirma"
        Me.btnConfirma.Size = New System.Drawing.Size(47, 47)
        Me.btnConfirma.TabIndex = 36
        Me.btnConfirma.UseVisualStyleBackColor = True
        '
        'dgvProduto
        '
        Me.dgvProduto.AllowUserToAddRows = False
        Me.dgvProduto.AllowUserToDeleteRows = False
        Me.dgvProduto.AllowUserToResizeColumns = False
        Me.dgvProduto.AllowUserToResizeRows = False
        Me.dgvProduto.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(12, 248)
        Me.dgvProduto.MultiSelect = False
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.RowHeadersVisible = False
        Me.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduto.Size = New System.Drawing.Size(670, 219)
        Me.dgvProduto.TabIndex = 44
        '
        'frm_CadVencimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 479)
        Me.Controls.Add(Me.dgvProduto)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnCasa)
        Me.Controls.Add(Me.btnDuvida)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CadVencimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Vencimentos de Produtos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbxFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNomeProd As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeAtual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeMinima As System.Windows.Forms.TextBox
    Friend WithEvents btnPastaFoto As System.Windows.Forms.Button
    Friend WithEvents btnLimpaFoto As System.Windows.Forms.Button
    Friend WithEvents btnIniciarFoto As System.Windows.Forms.Button
    Friend WithEvents btnTirarFoto As System.Windows.Forms.Button
    Friend WithEvents pbxFoto As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents btnCasa As System.Windows.Forms.Button
    Friend WithEvents btnDuvida As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
End Class
