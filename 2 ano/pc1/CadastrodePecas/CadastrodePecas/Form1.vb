Public Class Form1
    Dim bd As New BdPeca

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgFiltro.DataSource = bd.pesquisa("").Tables(0).DefaultView
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub AlteraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlteraToolStripMenuItem.Click
        Dim id = -1, linha As Integer
        linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            id = dgFiltro.Rows(linha).Cells(0).Value
            Form2.peca = bd.localizar(id)
            Form2.novo = False
            Form2.Show()
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim id = -1, linha As Integer
        linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            id = dgFiltro.Rows(linha).Cells(0).Value
            bd.excluir(id)
            dgFiltro.DataSource = bd.pesquisa(txtfiltro.Text).Tables(0).DefaultView
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub

    Private Sub btnfiltro_Click(sender As Object, e As EventArgs) Handles btnfiltro.Click
        dgFiltro.DataSource = bd.pesquisa(txtfiltro.Text).Tables(0).DefaultView
    End Sub
End Class
