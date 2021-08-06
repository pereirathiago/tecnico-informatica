Public Class Form2
    Dim mProduto As New Produto
    Dim mnovo As Boolean
    Dim bd As New BdProduto

    Private Sub produtoToTela()
        txtid.Text = mProduto.id
        txtcodbar.Text = mProduto.codbar
        txtdescricao.Text = mProduto.descricao
        txtquantidade.Text = mProduto.quantidade
        txtquantidadealtera.Value = mProduto.quantidade
        txtminimo.Text = mProduto.minimo
        txtminimoaltera.Value = mProduto.minimo
    End Sub
    Private Sub telaToProduto()
        mProduto.id = txtid.Text
        mProduto.codbar = txtcodbar.Text
        mProduto.descricao = txtdescricao.Text
        adicRetiQuantidade()
        mProduto.minimo = txtminimo.Text
    End Sub
    Private Sub adicRetiQuantidade()
        If txtadiciona.Value <> 0 And txtretira.Value <> 0 Then
            If txtquantidade.Text + txtadiciona.Value > txtretira.Value Then
                mProduto.quantidade = txtquantidade.Text - txtretira.Value + txtadiciona.Value
            Else
                MsgBox("Não pode retirar mais que a quantidade")
            End If
        ElseIf txtadiciona.Value <> 0 Then
            mProduto.quantidade = txtquantidade.Text + txtadiciona.Value
        ElseIf txtretira.Value <> 0 Then
            If txtquantidade.Text > txtretira.Value Then
                mProduto.quantidade = txtquantidade.Text - txtretira.Value
            Else
                MsgBox("Não pode retirar mais que quantidade atual")
            End If
        Else
            mProduto.quantidade = txtquantidade.Text
        End If
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