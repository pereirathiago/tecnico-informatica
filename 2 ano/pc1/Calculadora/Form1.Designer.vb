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
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnSubtrai = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiplica = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite o Primeiro valor"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(139, 18)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(135, 21)
        Me.txtValor1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Digite o segundo valor"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(139, 50)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(134, 21)
        Me.txtValor2.TabIndex = 3
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(23, 78)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(93, 27)
        Me.btnSoma.TabIndex = 4
        Me.btnSoma.Text = "Soma"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnSubtrai
        '
        Me.btnSubtrai.Location = New System.Drawing.Point(130, 78)
        Me.btnSubtrai.Name = "btnSubtrai"
        Me.btnSubtrai.Size = New System.Drawing.Size(93, 27)
        Me.btnSubtrai.TabIndex = 5
        Me.btnSubtrai.Text = "Subtração"
        Me.btnSubtrai.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(344, 78)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(93, 27)
        Me.btnDivide.TabIndex = 6
        Me.btnDivide.Text = "Divisão"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiplica
        '
        Me.btnMultiplica.Location = New System.Drawing.Point(237, 78)
        Me.btnMultiplica.Name = "btnMultiplica"
        Me.btnMultiplica.Size = New System.Drawing.Size(93, 27)
        Me.btnMultiplica.TabIndex = 7
        Me.btnMultiplica.Text = "Multiplicação"
        Me.btnMultiplica.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMultiplica)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnSubtrai)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents btnSoma As Button
    Friend WithEvents btnSubtrai As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiplica As Button
End Class
