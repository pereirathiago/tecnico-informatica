<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVeiculoEmprestimo
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
        Me.btnemprestra = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidveiculo = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnemprestra
        '
        Me.btnemprestra.Location = New System.Drawing.Point(52, 110)
        Me.btnemprestra.Name = "btnemprestra"
        Me.btnemprestra.Size = New System.Drawing.Size(75, 23)
        Me.btnemprestra.TabIndex = 0
        Me.btnemprestra.Text = "Emprestar"
        Me.btnemprestra.UseVisualStyleBackColor = True
        '
        'btncancela
        '
        Me.btncancela.Location = New System.Drawing.Point(144, 110)
        Me.btncancela.Name = "btncancela"
        Me.btncancela.Size = New System.Drawing.Size(75, 23)
        Me.btncancela.TabIndex = 1
        Me.btncancela.Text = "Cancelar"
        Me.btncancela.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id Veiculo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Id Cliente"
        '
        'txtidveiculo
        '
        Me.txtidveiculo.Enabled = False
        Me.txtidveiculo.Location = New System.Drawing.Point(133, 40)
        Me.txtidveiculo.Name = "txtidveiculo"
        Me.txtidveiculo.Size = New System.Drawing.Size(100, 20)
        Me.txtidveiculo.TabIndex = 4
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(133, 69)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidcliente.TabIndex = 5
        '
        'FormVeiculoEmprestimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 173)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtidveiculo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncancela)
        Me.Controls.Add(Me.btnemprestra)
        Me.Name = "FormVeiculoEmprestimo"
        Me.Text = "Emprestimo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnemprestra As Button
    Friend WithEvents btncancela As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidveiculo As TextBox
    Friend WithEvents txtidcliente As TextBox
End Class
