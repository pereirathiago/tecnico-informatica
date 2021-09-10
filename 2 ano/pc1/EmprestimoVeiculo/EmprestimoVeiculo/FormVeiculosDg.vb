Public Class FormVeiculosDg
    Dim bd As New BdVeiculo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgFiltro.DataSource = bd.pesquisa("").Tables(0).DefaultView
    End Sub

    Private Sub btnfiltro_Click(sender As Object, e As EventArgs) Handles btnfiltro.Click
        dgFiltro.DataSource = bd.pesquisa(txtFiltro.Text).Tables(0).DefaultView
    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        Dim codigo = -1, linha As Integer
        linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            codigo = dgFiltro.Rows(linha).Cells(0).Value
            FormVeiculo.veiculo = bd.localizar(codigo)
            FormVeiculo.novo = False
            FormVeiculo.Show()
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        FormVeiculo.veiculo = New Veiculo
        FormVeiculo.novo = True
        FormVeiculo.Show()
    End Sub

    Private Sub ExcluirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        Dim codigo = -1, linha As Integer
        linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            codigo = dgFiltro.Rows(linha).Cells(0).Value
            bd.excluir(codigo)
            dgFiltro.DataSource = bd.pesquisa(txtFiltro.Text).Tables(0).DefaultView
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub

    Private Sub btnVerTodosVeiculos_Click(sender As Object, e As EventArgs) Handles btnVerTodosVeiculos.Click
        dgFiltro.DataSource = bd.pesquisa("").Tables(0).DefaultView
    End Sub

    Private Sub btnVerEmprestimo_Click(sender As Object, e As EventArgs) Handles btnVerEmprestimo.Click
        dgFiltro.DataSource = bd.emprestimos().Tables(0).DefaultView
    End Sub
End Class