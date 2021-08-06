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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtcodbar = New System.Windows.Forms.TextBox()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.txtquantidade = New System.Windows.Forms.TextBox()
        Me.boxQuantidade = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtminimoaltera = New System.Windows.Forms.NumericUpDown()
        Me.txtadiciona = New System.Windows.Forms.NumericUpDown()
        Me.txtretira = New System.Windows.Forms.NumericUpDown()
        Me.txtquantidadealtera = New System.Windows.Forms.NumericUpDown()
        Me.txtminimo = New System.Windows.Forms.TextBox()
        Me.boxQuantidade.SuspendLayout()
        CType(Me.txtminimoaltera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtadiciona, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtretira, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtquantidadealtera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(150, 292)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(49, 292)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código de barras"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Mínimo"
        '
        'txtid
        '
        Me.txtid.Enabled = False
        Me.txtid.Location = New System.Drawing.Point(131, 38)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(94, 20)
        Me.txtid.TabIndex = 7
        '
        'txtcodbar
        '
        Me.txtcodbar.Location = New System.Drawing.Point(131, 73)
        Me.txtcodbar.Name = "txtcodbar"
        Me.txtcodbar.Size = New System.Drawing.Size(138, 20)
        Me.txtcodbar.TabIndex = 8
        '
        'txtdescricao
        '
        Me.txtdescricao.Location = New System.Drawing.Point(131, 108)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(138, 20)
        Me.txtdescricao.TabIndex = 9
        '
        'txtquantidade
        '
        Me.txtquantidade.Location = New System.Drawing.Point(131, 154)
        Me.txtquantidade.Name = "txtquantidade"
        Me.txtquantidade.Size = New System.Drawing.Size(94, 20)
        Me.txtquantidade.TabIndex = 10
        '
        'boxQuantidade
        '
        Me.boxQuantidade.Controls.Add(Me.txtquantidadealtera)
        Me.boxQuantidade.Controls.Add(Me.txtretira)
        Me.boxQuantidade.Controls.Add(Me.txtadiciona)
        Me.boxQuantidade.Controls.Add(Me.txtminimoaltera)
        Me.boxQuantidade.Controls.Add(Me.Label7)
        Me.boxQuantidade.Controls.Add(Me.Label6)
        Me.boxQuantidade.Controls.Add(Me.Label8)
        Me.boxQuantidade.Controls.Add(Me.Label9)
        Me.boxQuantidade.Location = New System.Drawing.Point(30, 139)
        Me.boxQuantidade.Name = "boxQuantidade"
        Me.boxQuantidade.Size = New System.Drawing.Size(244, 141)
        Me.boxQuantidade.TabIndex = 25
        Me.boxQuantidade.TabStop = False
        Me.boxQuantidade.Text = "Quantidade"
        Me.boxQuantidade.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Retirar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Adicionar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Mínimo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Atual"
        '
        'txtminimoaltera
        '
        Me.txtminimoaltera.Location = New System.Drawing.Point(101, 106)
        Me.txtminimoaltera.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.txtminimoaltera.Name = "txtminimoaltera"
        Me.txtminimoaltera.Size = New System.Drawing.Size(100, 20)
        Me.txtminimoaltera.TabIndex = 26
        '
        'txtadiciona
        '
        Me.txtadiciona.Location = New System.Drawing.Point(101, 51)
        Me.txtadiciona.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.txtadiciona.Name = "txtadiciona"
        Me.txtadiciona.Size = New System.Drawing.Size(100, 20)
        Me.txtadiciona.TabIndex = 27
        '
        'txtretira
        '
        Me.txtretira.Location = New System.Drawing.Point(101, 80)
        Me.txtretira.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.txtretira.Name = "txtretira"
        Me.txtretira.Size = New System.Drawing.Size(100, 20)
        Me.txtretira.TabIndex = 28
        '
        'txtquantidadealtera
        '
        Me.txtquantidadealtera.Location = New System.Drawing.Point(101, 21)
        Me.txtquantidadealtera.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.txtquantidadealtera.Name = "txtquantidadealtera"
        Me.txtquantidadealtera.Size = New System.Drawing.Size(100, 20)
        Me.txtquantidadealtera.TabIndex = 29
        '
        'txtminimo
        '
        Me.txtminimo.Location = New System.Drawing.Point(131, 189)
        Me.txtminimo.Name = "txtminimo"
        Me.txtminimo.Size = New System.Drawing.Size(94, 20)
        Me.txtminimo.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 353)
        Me.Controls.Add(Me.boxQuantidade)
        Me.Controls.Add(Me.txtminimo)
        Me.Controls.Add(Me.txtquantidade)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.txtcodbar)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "Form2"
        Me.Text = "Cadastrar / Alterar"
        Me.boxQuantidade.ResumeLayout(False)
        Me.boxQuantidade.PerformLayout()
        CType(Me.txtminimoaltera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtadiciona, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtretira, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtquantidadealtera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtcodbar As TextBox
    Friend WithEvents txtdescricao As TextBox
    Friend WithEvents txtquantidade As TextBox
    Friend WithEvents boxQuantidade As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtquantidadealtera As NumericUpDown
    Friend WithEvents txtretira As NumericUpDown
    Friend WithEvents txtadiciona As NumericUpDown
    Friend WithEvents txtminimoaltera As NumericUpDown
    Friend WithEvents txtminimo As TextBox
End Class
