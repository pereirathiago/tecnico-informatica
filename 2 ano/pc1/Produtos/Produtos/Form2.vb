Public Class Form2
    Dim mProduto As New Produto
    Dim mnovo As Boolean
    Dim bd As New BdProduto

    Private Sub produtoToTela()
        txtid.Text = mProduto.id
        txtcodbar.Text = mProduto.codbar
        txtdescricao.Text = mProduto.descricao
        txtquantidade.Text = mProduto.quantidade
        txtquantidadealtera.Text = mProduto.quantidade
        txtminimo.Text = mProduto.minimo
        txtminimoaltera.Text = mProduto.minimo
    End Sub
    Private Sub telaToProduto()
        mProduto.id = txtid.Text
        mProduto.codbar = txtcodbar.Text
        mProduto.descricao = txtdescricao.Text
        mProduto.quantidade = txtquantidade.Text
        mProduto.minimo = txtminimo.Text
    End Sub
    Public Property produto()
        Get
            Return mProduto
        End Get
        Set(ByVal value)
            mProduto = value
            produtoToTela()
        End Set
    End Property
    Public Property novo()
        Get
            Return mnovo
        End Get
        Set(ByVal value)
            mnovo = value
        End Set
    End Property

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If novo Then
            telaToProduto()
            bd.inserir(produto)
        Else
            txtquantidade.Text = txtquantidadealtera.Text
            txtminimo.Text = txtminimoaltera.Text
            telaToProduto()
            bd.atualizar(produto)
            Console.WriteLine("Chamou o atualizar")
        End If
        Me.Dispose()
    End Sub
End Class