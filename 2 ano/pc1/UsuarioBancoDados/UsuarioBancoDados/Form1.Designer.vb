<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nome"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(84, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(129, 23)
        Me.txtUser.TabIndex = 3
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(84, 79)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(129, 23)
        Me.txtSenha.TabIndex = 4
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(84, 47)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(129, 23)
        Me.txtNome.TabIndex = 5
        '
        'btnlocalizar
        '
        Me.btnlocalizar.Location = New System.Drawing.Point(219, 9)
        Me.btnlocalizar.Name = "btnlocalizar"
        Me.btnlocalizar.Size = New System.Drawing.Size(76, 27)
        Me.btnlocalizar.TabIndex = 6
        Me.btnlocalizar.Text = "Localizar"
        Me.btnlocalizar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(31, 122)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(74, 25)
        Me.btnNovo.TabIndex = 7
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(111, 122)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(74, 25)
        Me.btnsalvar.TabIndex = 8
        Me.btnsalvar.Text = "Salva"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(191, 122)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(74, 25)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 172)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnlocalizar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnlocalizar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnsalvar As Button
End Class
