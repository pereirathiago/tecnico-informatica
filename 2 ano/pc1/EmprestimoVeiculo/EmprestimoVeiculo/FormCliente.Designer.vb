<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtendereco = New System.Windows.Forms.TextBox()
        Me.txtcidade = New System.Windows.Forms.TextBox()
        Me.txtuf = New System.Windows.Forms.TextBox()
        Me.txtcpf = New System.Windows.Forms.TextBox()
        Me.txtrg = New System.Windows.Forms.TextBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Endereço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Uf"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CPF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "RG"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(128, 67)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(62, 20)
        Me.txtcodigo.TabIndex = 7
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(128, 93)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(120, 20)
        Me.txtnome.TabIndex = 8
        '
        'txtendereco
        '
        Me.txtendereco.Location = New System.Drawing.Point(128, 122)
        Me.txtendereco.Name = "txtendereco"
        Me.txtendereco.Size = New System.Drawing.Size(120, 20)
        Me.txtendereco.TabIndex = 9
        '
        'txtcidade
        '
        Me.txtcidade.Location = New System.Drawing.Point(128, 151)
        Me.txtcidade.Name = "txtcidade"
        Me.txtcidade.Size = New System.Drawing.Size(100, 20)
        Me.txtcidade.TabIndex = 10
        '
        'txtuf
        '
        Me.txtuf.Location = New System.Drawing.Point(128, 180)
        Me.txtuf.Name = "txtuf"
        Me.txtuf.Size = New System.Drawing.Size(41, 20)
        Me.txtuf.TabIndex = 11
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(128, 209)
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(100, 20)
        Me.txtcpf.TabIndex = 12
        '
        'txtrg
        '
        Me.txtrg.Location = New System.Drawing.Point(128, 238)
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(100, 20)
        Me.txtrg.TabIndex = 13
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(59, 285)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnsalvar.TabIndex = 14
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(149, 285)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 15
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 374)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.txtrg)
        Me.Controls.Add(Me.txtcpf)
        Me.Controls.Add(Me.txtuf)
        Me.Controls.Add(Me.txtcidade)
        Me.Controls.Add(Me.txtendereco)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCliente"
        Me.Text = "Cliente - Altera / Cadastra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtendereco As TextBox
    Friend WithEvents txtcidade As TextBox
    Friend WithEvents txtuf As TextBox
    Friend WithEvents txtcpf As TextBox
    Friend WithEvents txtrg As TextBox
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btncancelar As Button
End Class
