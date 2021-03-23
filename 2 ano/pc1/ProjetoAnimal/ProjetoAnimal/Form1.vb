Public Class Form1
    Dim animal As New Animal
    Private Sub limpaTela()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtProrietario.Text = ""
        txtIdade.Text = ""
        txtEspecie.Text = ""
        txtRaca.Text = ""
    End Sub

    Private Sub telaToCliente()
        animal.codigo = txtCodigo.Text
        animal.nome = txtNome.Text
        animal.propietario = txtProrietario.Text
        animal.idade = txtIdade.Text
        animal.especie = txtEspecie.Text
        animal.raca = txtRaca.Text
    End Sub

    Private Sub clienteToTela()
        txtCodigo.Text = animal.codigo
        txtNome.Text = animal.nome
        txtProrietario.Text = animal.propietario
        txtIdade.Text = animal.idade
        txtEspecie.Text = animal.especie
        txtRaca.Text = animal.raca
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        limpaTela()
    End Sub

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        telaToCliente()
    End Sub

    Private Sub btnLe_Click(sender As Object, e As EventArgs) Handles btnLe.Click
        clienteToTela()
    End Sub
End Class
