<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVeiculosDg
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
        Me.dgFiltro = New System.Windows.Forms.DataGridView()
        Me.btnVerEmprestimo = New System.Windows.Forms.Button()
        Me.btnVerTodosVeiculos = New System.Windows.Forms.Button()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmprestarVeiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverVeiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFiltro
        '
        Me.dgFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiltro.Location = New System.Drawing.Point(22, 72)
        Me.dgFiltro.Name = "dgFiltro"
        Me.dgFiltro.Size = New System.Drawing.Size(740, 284)
        Me.dgFiltro.TabIndex = 14
        '
        'btnVerEmprestimo
        '
        Me.btnVerEmprestimo.Location = New System.Drawing.Point(415, 28)
        Me.btnVerEmprestimo.Name = "btnVerEmprestimo"
        Me.btnVerEmprestimo.Size = New System.Drawing.Size(101, 23)
        Me.btnVerEmprestimo.TabIndex = 13
        Me.btnVerEmprestimo.Text = "Ver Emprestimos"
        Me.btnVerEmprestimo.UseVisualStyleBackColor = True
        '
        'btnVerTodosVeiculos
        '
        Me.btnVerTodosVeiculos.Location = New System.Drawing.Point(295, 28)
        Me.btnVerTodosVeiculos.Name = "btnVerTodosVeiculos"
        Me.btnVerTodosVeiculos.Size = New System.Drawing.Size(114, 23)
        Me.btnVerTodosVeiculos.TabIndex = 12
        Me.btnVerTodosVeiculos.Text = "Todos os Veículos"
        Me.btnVerTodosVeiculos.UseVisualStyleBackColor = True
        '
        'btnfiltro
        '
        Me.btnfiltro.Location = New System.Drawing.Point(176, 28)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(48, 23)
        Me.btnfiltro.TabIndex = 11
        Me.btnfiltro.Text = "Ok"
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(51, 30)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(109, 20)
        Me.txtFiltro.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Filtro"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(778, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.EmprestarVeiculoToolStripMenuItem, Me.DevolverVeiculoToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'EmprestarVeiculoToolStripMenuItem
        '
        Me.EmprestarVeiculoToolStripMenuItem.Name = "EmprestarVeiculoToolStripMenuItem"
        Me.EmprestarVeiculoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmprestarVeiculoToolStripMenuItem.Text = "Emprestar veiculo"
        '
        'DevolverVeiculoToolStripMenuItem
        '
        Me.DevolverVeiculoToolStripMenuItem.Name = "DevolverVeiculoToolStripMenuItem"
        Me.DevolverVeiculoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DevolverVeiculoToolStripMenuItem.Text = "Devolver veiculo"
        '
        'FormVeiculosDg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 378)
        Me.Controls.Add(Me.dgFiltro)
        Me.Controls.Add(Me.btnVerEmprestimo)
        Me.Controls.Add(Me.btnVerTodosVeiculos)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormVeiculosDg"
        Me.Text = "Veiculos"
        CType(Me.dgFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgFiltro As DataGridView
    Friend WithEvents btnVerEmprestimo As Button
    Friend WithEvents btnVerTodosVeiculos As Button
    Friend WithEvents btnfiltro As Button
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmprestarVeiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverVeiculoToolStripMenuItem As ToolStripMenuItem
End Class
