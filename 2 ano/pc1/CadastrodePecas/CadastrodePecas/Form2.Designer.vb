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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtAplicacao = New System.Windows.Forms.TextBox()
        Me.txtCodigoDeBarras = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Aplicação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código de Barras"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(157, 64)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 5
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(157, 103)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(100, 20)
        Me.txtDescricao.TabIndex = 6
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(157, 140)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 7
        '
        'txtAplicacao
        '
        Me.txtAplicacao.Location = New System.Drawing.Point(157, 179)
        Me.txtAplicacao.Name = "txtAplicacao"
        Me.txtAplicacao.Size = New System.Drawing.Size(100, 20)
        Me.txtAplicacao.TabIndex = 8
        '
        'txtCodigoDeBarras
        '
        Me.txtCodigoDeBarras.Location = New System.Drawing.Point(157, 214)
        Me.txtCodigoDeBarras.Name = "txtCodigoDeBarras"
        Me.txtCodigoDeBarras.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoDeBarras.TabIndex = 9
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(38, 274)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(139, 274)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 366)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.txtCodigoDeBarras)
        Me.Controls.Add(Me.txtAplicacao)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtAplicacao As TextBox
    Friend WithEvents txtCodigoDeBarras As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnCancelar As Button
End Class
