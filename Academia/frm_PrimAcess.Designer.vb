<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrimAcess
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PrimAcess))
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.txtLicença = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDemo = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtConfiSenha = New System.Windows.Forms.TextBox()
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtSenha.Location = New System.Drawing.Point(25, 96)
        Me.txtSenha.MaxLength = 10
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(184, 24)
        Me.txtSenha.TabIndex = 13
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtUsuario.Location = New System.Drawing.Point(25, 49)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(184, 24)
        Me.txtUsuario.TabIndex = 11
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.PasswordLabel.Location = New System.Drawing.Point(23, 76)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(184, 23)
        Me.PasswordLabel.TabIndex = 12
        Me.PasswordLabel.Text = "Senha"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.UsernameLabel.Location = New System.Drawing.Point(23, 29)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(184, 23)
        Me.UsernameLabel.TabIndex = 10
        Me.UsernameLabel.Text = "Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLicença
        '
        Me.txtLicença.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtLicença.Location = New System.Drawing.Point(25, 190)
        Me.txtLicença.MaxLength = 10
        Me.txtLicença.Name = "txtLicença"
        Me.txtLicença.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtLicença.Size = New System.Drawing.Size(184, 24)
        Me.txtLicença.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(23, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Licença"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(23, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Confirmação Senha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDemo
        '
        Me.btnDemo.AutoSize = True
        Me.btnDemo.Location = New System.Drawing.Point(123, 12)
        Me.btnDemo.Name = "btnDemo"
        Me.btnDemo.Size = New System.Drawing.Size(86, 23)
        Me.btnDemo.TabIndex = 18
        Me.btnDemo.Text = "Demo"
        Me.btnDemo.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.AutoSize = True
        Me.btnCadastrar.Location = New System.Drawing.Point(157, 230)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(62, 23)
        Me.btnCadastrar.TabIndex = 19
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.AutoSize = True
        Me.btnLimpar.Location = New System.Drawing.Point(88, 230)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(63, 23)
        Me.btnLimpar.TabIndex = 20
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.AutoSize = True
        Me.btnFechar.Location = New System.Drawing.Point(19, 230)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(63, 23)
        Me.btnFechar.TabIndex = 21
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtConfiSenha
        '
        Me.txtConfiSenha.Font = New System.Drawing.Font("Estrangelo Edessa", 11.25!)
        Me.txtConfiSenha.Location = New System.Drawing.Point(25, 143)
        Me.txtConfiSenha.MaxLength = 10
        Me.txtConfiSenha.Name = "txtConfiSenha"
        Me.txtConfiSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfiSenha.Size = New System.Drawing.Size(184, 24)
        Me.txtConfiSenha.TabIndex = 22
        '
        'VisualStyler1
        '
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "GUI Relax (Subtle).vssf")
        '
        'frm_PrimAcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 270)
        Me.Controls.Add(Me.txtConfiSenha)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.btnDemo)
        Me.Controls.Add(Me.txtLicença)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_PrimAcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Primeiro Acesso"
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents txtLicença As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnDemo As System.Windows.Forms.Button
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtConfiSenha As System.Windows.Forms.TextBox
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
End Class
