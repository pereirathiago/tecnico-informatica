<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnumserie = New System.Windows.Forms.TextBox()
        Me.txtfabricante = New System.Windows.Forms.TextBox()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.txtnumpatrimonio = New System.Windows.Forms.TextBox()
        Me.txtlocalizacao = New System.Windows.Forms.TextBox()
        Me.btnsalva = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fabricante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número de série"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Número de patrimonio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Localização"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(129, 49)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'txtnumserie
        '
        Me.txtnumserie.Location = New System.Drawing.Point(129, 151)
        Me.txtnumserie.Name = "txtnumserie"
        Me.txtnumserie.Size = New System.Drawing.Size(100, 20)
        Me.txtnumserie.TabIndex = 7
        '
        'txtfabricante
        '
        Me.txtfabricante.Location = New System.Drawing.Point(129, 120)
        Me.txtfabricante.Name = "txtfabricante"
        Me.txtfabricante.Size = New System.Drawing.Size(100, 20)
        Me.txtfabricante.TabIndex = 8
        '
        'txtdescricao
        '
        Me.txtdescricao.Location = New System.Drawing.Point(129, 83)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(100, 20)
        Me.txtdescricao.TabIndex = 9
        '
        'txtnumpatrimonio
        '
        Me.txtnumpatrimonio.Location = New System.Drawing.Point(129, 185)
        Me.txtnumpatrimonio.Name = "txtnumpatrimonio"
        Me.txtnumpatrimonio.Size = New System.Drawing.Size(100, 20)
        Me.txtnumpatrimonio.TabIndex = 10
        '
        'txtlocalizacao
        '
        Me.txtlocalizacao.Location = New System.Drawing.Point(129, 219)
        Me.txtlocalizacao.Name = "txtlocalizacao"
        Me.txtlocalizacao.Size = New System.Drawing.Size(100, 20)
        Me.txtlocalizacao.TabIndex = 11
        '
        'btnsalva
        '
        Me.btnsalva.Location = New System.Drawing.Point(38, 257)
        Me.btnsalva.Name = "btnsalva"
        Me.btnsalva.Size = New System.Drawing.Size(75, 23)
        Me.btnsalva.TabIndex = 12
        Me.btnsalva.Text = "Salvar"
        Me.btnsalva.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(127, 257)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 328)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalva)
        Me.Controls.Add(Me.txtlocalizacao)
        Me.Controls.Add(Me.txtnumpatrimonio)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.txtfabricante)
        Me.Controls.Add(Me.txtnumserie)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Cadastro/Altera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnumserie As TextBox
    Friend WithEvents txtfabricante As TextBox
    Friend WithEvents txtdescricao As TextBox
    Friend WithEvents txtnumpatrimonio As TextBox
    Friend WithEvents txtlocalizacao As TextBox
    Friend WithEvents btnsalva As Button
    Friend WithEvents btncancelar As Button
End Class
