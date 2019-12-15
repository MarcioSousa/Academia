<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Juros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Juros))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiaJuros = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAnoJuros = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMesJuros = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAnoDesconto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMesDesconto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDiaDesconto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.btnLimpa = New System.Windows.Forms.Button()
        Me.btnConfirma = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnInicial = New System.Windows.Forms.Button()
        Me.btnAjuda = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dia:"
        '
        'txtDiaJuros
        '
        Me.txtDiaJuros.Location = New System.Drawing.Point(41, 19)
        Me.txtDiaJuros.MaxLength = 5
        Me.txtDiaJuros.Name = "txtDiaJuros"
        Me.txtDiaJuros.ReadOnly = True
        Me.txtDiaJuros.Size = New System.Drawing.Size(68, 20)
        Me.txtDiaJuros.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAnoJuros)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMesJuros)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDiaJuros)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Juros"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "% de Juros"
        '
        'txtAnoJuros
        '
        Me.txtAnoJuros.Location = New System.Drawing.Point(41, 71)
        Me.txtAnoJuros.MaxLength = 5
        Me.txtAnoJuros.Name = "txtAnoJuros"
        Me.txtAnoJuros.ReadOnly = True
        Me.txtAnoJuros.Size = New System.Drawing.Size(68, 20)
        Me.txtAnoJuros.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ano:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "% de Juros"
        '
        'txtMesJuros
        '
        Me.txtMesJuros.Location = New System.Drawing.Point(41, 45)
        Me.txtMesJuros.MaxLength = 5
        Me.txtMesJuros.Name = "txtMesJuros"
        Me.txtMesJuros.ReadOnly = True
        Me.txtMesJuros.Size = New System.Drawing.Size(68, 20)
        Me.txtMesJuros.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mês:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "% de Juros"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtAnoDesconto)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtMesDesconto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtDiaDesconto)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 100)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Desconto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(115, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "% de Desconto"
        '
        'txtAnoDesconto
        '
        Me.txtAnoDesconto.Location = New System.Drawing.Point(41, 71)
        Me.txtAnoDesconto.MaxLength = 5
        Me.txtAnoDesconto.Name = "txtAnoDesconto"
        Me.txtAnoDesconto.ReadOnly = True
        Me.txtAnoDesconto.Size = New System.Drawing.Size(68, 20)
        Me.txtAnoDesconto.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Ano:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(115, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "% de Desconto"
        '
        'txtMesDesconto
        '
        Me.txtMesDesconto.Location = New System.Drawing.Point(41, 45)
        Me.txtMesDesconto.MaxLength = 5
        Me.txtMesDesconto.Name = "txtMesDesconto"
        Me.txtMesDesconto.ReadOnly = True
        Me.txtMesDesconto.Size = New System.Drawing.Size(68, 20)
        Me.txtMesDesconto.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Mês:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(115, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "% de Desconto"
        '
        'txtDiaDesconto
        '
        Me.txtDiaDesconto.Location = New System.Drawing.Point(41, 19)
        Me.txtDiaDesconto.MaxLength = 5
        Me.txtDiaDesconto.Name = "txtDiaDesconto"
        Me.txtDiaDesconto.ReadOnly = True
        Me.txtDiaDesconto.Size = New System.Drawing.Size(68, 20)
        Me.txtDiaDesconto.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Dia:"
        '
        'btnCancela
        '
        Me.btnCancela.Enabled = False
        Me.btnCancela.FlatAppearance.BorderSize = 0
        Me.btnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancela.Image = CType(resources.GetObject("btnCancela.Image"), System.Drawing.Image)
        Me.btnCancela.Location = New System.Drawing.Point(386, 119)
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
        Me.btnLimpa.Location = New System.Drawing.Point(121, 119)
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
        Me.btnConfirma.Location = New System.Drawing.Point(333, 119)
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
        Me.btnEditar.Location = New System.Drawing.Point(227, 119)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(47, 47)
        Me.btnEditar.TabIndex = 75
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnInicial
        '
        Me.btnInicial.FlatAppearance.BorderSize = 0
        Me.btnInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicial.Image = CType(resources.GetObject("btnInicial.Image"), System.Drawing.Image)
        Me.btnInicial.Location = New System.Drawing.Point(15, 119)
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
        Me.btnAjuda.Location = New System.Drawing.Point(68, 119)
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
        Me.btnNovo.Location = New System.Drawing.Point(174, 119)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(47, 47)
        Me.btnNovo.TabIndex = 79
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'frm_Juros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 180)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnLimpa)
        Me.Controls.Add(Me.btnConfirma)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnInicial)
        Me.Controls.Add(Me.btnAjuda)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Juros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário para Cadastro de Juros e Descontos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDiaJuros As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAnoJuros As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMesJuros As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAnoDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMesDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDiaDesconto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCancela As System.Windows.Forms.Button
    Friend WithEvents btnLimpa As System.Windows.Forms.Button
    Friend WithEvents btnConfirma As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnInicial As System.Windows.Forms.Button
    Friend WithEvents btnAjuda As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
End Class
