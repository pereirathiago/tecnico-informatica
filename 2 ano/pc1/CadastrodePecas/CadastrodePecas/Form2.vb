Public Class Form2
    Dim mPeca As New Peca
    Dim mnovo As Boolean
    Dim bd As New BdPeca
    Private Sub pecatotela()
        txtId.Text = mPeca.id
        txtDescricao.Text = mPeca.descricao
        txtMarca.Text = mPeca.marca
        txtAplicacao.Text = mPeca.aplicacao
        txtCodigoDeBarras.Text = mPeca.codigodebarras
    End Sub
    Private Sub telatopeca()
        mPeca.id = txtId.Text
        mPeca.descricao = txtDescricao.Text
        mPeca.marca = txtMarca.Text
        mPeca.aplicacao = txtAplicacao.Text
        mPeca.codigodebarras = txtCodigoDeBarras.Text
    End Sub
    Public Property peca()
        Get
            Return mPeca
        End Get
        Set(ByVal value)
            mPeca = value
            pecatotela()
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
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        telatopeca()
        If novo Then
            bd.inserir(peca)
        Else
            bd.atualizar(peca)
        End If
        Me.Dispose()
    End Sub
End Class