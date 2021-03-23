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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtProrietario = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtEspecie = New System.Windows.Forms.TextBox()
        Me.txtRaca = New System.Windows.Forms.TextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.btnLe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Proprietario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Idade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Especie"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Raça"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(80, 18)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(75, 23)
        Me.txtCodigo.TabIndex = 6
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(80, 48)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(119, 23)
        Me.txtNome.TabIndex = 7
        '
        'txtProrietario
        '
        Me.txtProrietario.Location = New System.Drawing.Point(80, 78)
        Me.txtProrietario.Name = "txtProrietario"
        Me.txtProrietario.Size = New System.Drawing.Size(119, 23)
        Me.txtProrietario.TabIndex = 8
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(80, 108)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(75, 23)
        Me.txtIdade.TabIndex = 9
        '
        'txtEspecie
        '
        Me.txtEspecie.Location = New System.Drawing.Point(80, 138)
        Me.txtEspecie.Name = "txtEspecie"
        Me.txtEspecie.Size = New System.Drawing.Size(119, 23)
        Me.txtEspecie.TabIndex = 10
        '
        'txtRaca
        '
        Me.txtRaca.Location = New System.Drawing.Point(80, 168)
        Me.txtRaca.Name = "txtRaca"
        Me.txtRaca.Size = New System.Drawing.Size(119, 23)
        Me.txtRaca.TabIndex = 11
        '
        'btnNovo
        '
        Me.btnNovo.Location = New System.Drawing.Point(21, 213)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(72, 31)
        Me.btnNovo.TabIndex = 12
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnSalva
        '
        Me.btnSalva.Location = New System.Drawing.Point(108, 213)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(72, 31)
        Me.btnSalva.TabIndex = 13
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'btnLe
        '
        Me.btnLe.Location = New System.Drawing.Point(195, 213)
        Me.btnLe.Name = "btnLe"
        Me.btnLe.Size = New System.Drawing.Size(72, 31)
        Me.btnLe.TabIndex = 14
        Me.btnLe.Text = "Lê"
        Me.btnLe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 256)
        Me.Controls.Add(Me.btnLe)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtRaca)
        Me.Controls.Add(Me.txtEspecie)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtProrietario)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Animal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtProrietario As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtEspecie As TextBox
    Friend WithEvents txtRaca As TextBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnSalva As Button
    Friend WithEvents btnLe As Button
End Class
