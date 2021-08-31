<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoVeiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoEmprestimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarProdutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarEmprestimoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirVeículoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirEmprestimoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgFiltro = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(601, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoClienteToolStripMenuItem, Me.NovoVeiculoToolStripMenuItem, Me.NovoEmprestimoToolStripMenuItem})
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'NovoClienteToolStripMenuItem
        '
        Me.NovoClienteToolStripMenuItem.Name = "NovoClienteToolStripMenuItem"
        Me.NovoClienteToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NovoClienteToolStripMenuItem.Text = "Cliente"
        '
        'NovoVeiculoToolStripMenuItem
        '
        Me.NovoVeiculoToolStripMenuItem.Name = "NovoVeiculoToolStripMenuItem"
        Me.NovoVeiculoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NovoVeiculoToolStripMenuItem.Text = "Veiculo"
        '
        'NovoEmprestimoToolStripMenuItem
        '
        Me.NovoEmprestimoToolStripMenuItem.Name = "NovoEmprestimoToolStripMenuItem"
        Me.NovoEmprestimoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.NovoEmprestimoToolStripMenuItem.Text = "Emprestimo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlterarClienteToolStripMenuItem1, Me.AlterarProdutoToolStripMenuItem, Me.AlterarEmprestimoToolStripMenuItem1})
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'AlterarClienteToolStripMenuItem1
        '
        Me.AlterarClienteToolStripMenuItem1.Name = "AlterarClienteToolStripMenuItem1"
        Me.AlterarClienteToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AlterarClienteToolStripMenuItem1.Text = "Cliente"
        '
        'AlterarProdutoToolStripMenuItem
        '
        Me.AlterarProdutoToolStripMenuItem.Name = "AlterarProdutoToolStripMenuItem"
        Me.AlterarProdutoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlterarProdutoToolStripMenuItem.Text = "Veiculo"
        '
        'AlterarEmprestimoToolStripMenuItem1
        '
        Me.AlterarEmprestimoToolStripMenuItem1.Name = "AlterarEmprestimoToolStripMenuItem1"
        Me.AlterarEmprestimoToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AlterarEmprestimoToolStripMenuItem1.Text = "Emprestimo"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcluirClienteToolStripMenuItem2, Me.ExcluirVeículoToolStripMenuItem, Me.ExcluirEmprestimoToolStripMenuItem2})
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'ExcluirClienteToolStripMenuItem2
        '
        Me.ExcluirClienteToolStripMenuItem2.Name = "ExcluirClienteToolStripMenuItem2"
        Me.ExcluirClienteToolStripMenuItem2.Size = New System.Drawing.Size(138, 22)
        Me.ExcluirClienteToolStripMenuItem2.Text = "Cliente"
        '
        'ExcluirVeículoToolStripMenuItem
        '
        Me.ExcluirVeículoToolStripMenuItem.Name = "ExcluirVeículoToolStripMenuItem"
        Me.ExcluirVeículoToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExcluirVeículoToolStripMenuItem.Text = "Veículo"
        '
        'ExcluirEmprestimoToolStripMenuItem2
        '
        Me.ExcluirEmprestimoToolStripMenuItem2.Name = "ExcluirEmprestimoToolStripMenuItem2"
        Me.ExcluirEmprestimoToolStripMenuItem2.Size = New System.Drawing.Size(138, 22)
        Me.ExcluirEmprestimoToolStripMenuItem2.Text = "Emprestimo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtro"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(47, 33)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(109, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'btnfiltro
        '
        Me.btnfiltro.Location = New System.Drawing.Point(172, 31)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(48, 23)
        Me.btnfiltro.TabIndex = 3
        Me.btnfiltro.Text = "Ok"
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(303, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ver Clientes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 30)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Veer Veiculo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(477, 30)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ver Emprestimos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgFiltro
        '
        Me.dgFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiltro.Location = New System.Drawing.Point(15, 75)
        Me.dgFiltro.Name = "dgFiltro"
        Me.dgFiltro.Size = New System.Drawing.Size(563, 284)
        Me.dgFiltro.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 385)
        Me.Controls.Add(Me.dgFiltro)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Locadora"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoVeiculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoEmprestimoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnfiltro As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents dgFiltro As DataGridView
    Friend WithEvents AlterarClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlterarProdutoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarEmprestimoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExcluirClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ExcluirVeículoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirEmprestimoToolStripMenuItem2 As ToolStripMenuItem
End Class
