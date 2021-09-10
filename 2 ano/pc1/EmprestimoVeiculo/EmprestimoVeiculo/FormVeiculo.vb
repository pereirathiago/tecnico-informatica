Public Class FormVeiculo
    Dim mVeiculo As New Veiculo
    Dim mnovo As Boolean
    Dim bd As New BdVeiculo
    Private Sub veiculototela()
        txtcodigo.Text = mVeiculo.id
        txtplaca.Text = mVeiculo.placa
        txtmarca.Text = mVeiculo.marca
        txtmodelo.Text = mVeiculo.modelo
        txtano.Text = mVeiculo.ano
        txtchassi.Text = mVeiculo.chassi
    End Sub
    Private Sub telatoveiculo()
        mVeiculo.id = txtcodigo.Text
        mVeiculo.placa = txtplaca.Text
        mVeiculo.marca = txtmarca.Text
        mVeiculo.modelo = txtmodelo.Text
        mVeiculo.ano = txtano.Text
        mVeiculo.chassi = txtchassi.Text
    End Sub
    Public Property veiculo()
        Get
            Return mVeiculo
        End Get
        Set(ByVal value)
            mVeiculo = value
            veiculototela()
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
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        telatoveiculo()
        If novo Then
            bd.inserir(veiculo)
        Else
            bd.atualizar(veiculo)
        End If
        Me.Dispose()
    End Sub
End Class