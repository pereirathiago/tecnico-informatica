Public Class Form1
    Dim bdc As New BdCliente
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgFiltro.DataSource = bdc.pesquisa("").Tables(0).DefaultView
    End Sub

    Private Sub ALterarClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlterarClienteToolStripMenuItem1.Click
        Dim codigo = -1, linha As Integer
        linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            codigo = dgFiltro.Rows(linha).Cells(0).Value
            FormCliente.aluno = bdc.localizar(codigo)
            FormCliente.novo = False
            FormCliente.Show()
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub

    Private Sub NovoClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoClienteToolStripMenuItem.Click
        FormCliente.cliente = New Cliente
        FormCliente.novo = True
        FormCliente.Show()
    End Sub

    Private Sub ExcluirClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExcluirClienteToolStripMenuItem2.Click
        Dim codigo = -1, linha As Integer
        linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            codigo = dgFiltro.Rows(linha).Cells(0).Value
            bdc.excluir(codigo)
            dgFiltro.DataSource = bdc.pesquisa(txtFiltro.Text).Tables(0).DefaultView
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub

    Private Sub btnfiltro_Click(sender As Object, e As EventArgs) Handles btnfiltro.Click
        dgFiltro.DataSource = bdc.pesquisa(txtFiltro.Text).Tables(0).DefaultView
    End Sub
End Class
