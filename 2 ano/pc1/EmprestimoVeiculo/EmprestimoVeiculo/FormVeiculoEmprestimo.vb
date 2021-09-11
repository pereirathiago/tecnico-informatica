Public Class FormVeiculoEmprestimo
    Dim mVeiculoEmp As New Veiculo
    Dim mnovo As Boolean
    Dim bd As New BdVeiculo
    Private Sub veiculototela()
        txtidveiculo.Text = mVeiculoEmp.id
        txtidcliente.Text = mVeiculoEmp.idCliente
    End Sub
    Private Sub telatoveiculo()
        mVeiculoEmp.id = txtidveiculo.Text
        mVeiculoEmp.idCliente = txtidcliente.Text
    End Sub
    Public Property veiculo()
        Get
            Return mVeiculoEmp
        End Get
        Set(ByVal value)
            mVeiculoEmp = value
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
    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.Click
        Me.Dispose()
    End Sub

    Private Sub btnEmpresta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnemprestra.Click
        telatoveiculo()
        bd.emprestaVeiculo(veiculo)
        Me.Dispose()
    End Sub
End Class