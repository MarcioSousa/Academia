<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_servicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_servicos))
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.cbxModalidade = New System.Windows.Forms.ComboBox()
        Me.dgvPacotes = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACOTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VALOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPacote = New System.Windows.Forms.TextBox()
        Me.txtValorSocio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodPac = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        CType(Me.dgvPacotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.Control
        Me.btnFechar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFechar.Location = New System.Drawing.Point(307, 349)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(66, 35)
        Me.btnFechar.TabIndex = 100
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'cbxModalidade
        '
        Me.cbxModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModalidade.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxModalidade.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxModalidade.FormattingEnabled = True
        Me.cbxModalidade.Location = New System.Drawing.Point(100, 32)
        Me.cbxModalidade.Name = "cbxModalidade"
        Me.cbxModalidade.Size = New System.Drawing.Size(191, 27)
        Me.cbxModalidade.TabIndex = 82
        '
        'dgvPacotes
        '
        Me.dgvPacotes.AllowUserToAddRows = False
        Me.dgvPacotes.AllowUserToDeleteRows = False
        Me.dgvPacotes.AllowUserToResizeColumns = False
        Me.dgvPacotes.AllowUserToResizeRows = False
        Me.dgvPacotes.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvPacotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacotes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.DataGridViewTextBoxColumn2, Me.PACOTE, Me.VALOR})
        Me.dgvPacotes.Location = New System.Drawing.Point(19, 162)
        Me.dgvPacotes.MultiSelect = False
        Me.dgvPacotes.Name = "dgvPacotes"
        Me.dgvPacotes.RowHeadersVisible = False
        Me.dgvPacotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPacotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacotes.Size = New System.Drawing.Size(354, 169)
        Me.dgvPacotes.TabIndex = 98
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "Codigo"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Modalidade"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'PACOTE
        '
        Me.PACOTE.HeaderText = "Pacote"
        Me.PACOTE.Name = "PACOTE"
        Me.PACOTE.ReadOnly = True
        Me.PACOTE.Width = 140
        '
        'VALOR
        '
        Me.VALOR.HeaderText = "Valor"
        Me.VALOR.Name = "VALOR"
        Me.VALOR.ReadOnly = True
        Me.VALOR.Width = 80
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNovo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNovo.Location = New System.Drawing.Point(235, 349)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(66, 35)
        Me.btnNovo.TabIndex = 99
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnDeletar
        '
        Me.btnDeletar.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeletar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeletar.Location = New System.Drawing.Point(91, 349)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(66, 35)
        Me.btnDeletar.TabIndex = 97
        Me.btnDeletar.Text = "Deletar"
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfirmar.Location = New System.Drawing.Point(278, 116)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 35)
        Me.btnConfirmar.TabIndex = 87
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        Me.btnConfirmar.Visible = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAlterar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAlterar.Location = New System.Drawing.Point(163, 349)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(66, 35)
        Me.btnAlterar.TabIndex = 96
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelar.Location = New System.Drawing.Point(19, 349)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(66, 35)
        Me.btnCancelar.TabIndex = 95
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        Me.btnCancelar.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(43, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 18)
        Me.Label9.TabIndex = 94
        Me.Label9.Text = "Pacote"
        '
        'txtPacote
        '
        Me.txtPacote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPacote.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPacote.Location = New System.Drawing.Point(46, 87)
        Me.txtPacote.MaxLength = 40
        Me.txtPacote.Name = "txtPacote"
        Me.txtPacote.Size = New System.Drawing.Size(219, 23)
        Me.txtPacote.TabIndex = 83
        '
        'txtValorSocio
        '
        Me.txtValorSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorSocio.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorSocio.Location = New System.Drawing.Point(271, 87)
        Me.txtValorSocio.MaxLength = 40
        Me.txtValorSocio.Name = "txtValorSocio"
        Me.txtValorSocio.Size = New System.Drawing.Size(82, 23)
        Me.txtValorSocio.TabIndex = 85
        Me.txtValorSocio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.txtValorSocio, "Ex: 123,45")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(268, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Mensalidade"
        '
        'txtCodPac
        '
        Me.txtCodPac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPac.Enabled = False
        Me.txtCodPac.Font = New System.Drawing.Font("MS Reference Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPac.Location = New System.Drawing.Point(46, 32)
        Me.txtCodPac.MaxLength = 5
        Me.txtCodPac.Name = "txtCodPac"
        Me.txtCodPac.Size = New System.Drawing.Size(48, 26)
        Me.txtCodPac.TabIndex = 81
        Me.txtCodPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(97, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Modalidade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Humnst777 Lt BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(43, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 18)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Código"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdd.Location = New System.Drawing.Point(297, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(38, 27)
        Me.btnAdd.TabIndex = 101
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(99, 31)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 29)
        Me.TextBox1.TabIndex = 102
        '
        'VisualStyler1
        '
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "GUI Relax (Subtle).vssf")
        '
        'frm_servicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 403)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.cbxModalidade)
        Me.Controls.Add(Me.dgvPacotes)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPacote)
        Me.Controls.Add(Me.txtValorSocio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodPac)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_servicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviços"
        CType(Me.dgvPacotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents cbxModalidade As System.Windows.Forms.ComboBox
    Friend WithEvents dgvPacotes As System.Windows.Forms.DataGridView
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPacote As System.Windows.Forms.TextBox
    Friend WithEvents txtValorSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodPac As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CODIGO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PACOTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VALOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
End Class
