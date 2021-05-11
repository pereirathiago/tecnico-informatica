Public Class Form2
    Dim mEquipamento As New Equipamento
    Dim mnovo As Boolean
    Dim bd As New BdEquipamento

    Private Sub equipamentotela()
        txtcodigo.Text = mEquipamento.codigo
        txtdescricao.Text = mEquipamento.descricao
        txtfabricante.Text = mEquipamento.fabricante
        txtnumserie.Text = mEquipamento.numserie
        txtnumpatrimonio.Text = mEquipamento.numpatrimonio
        txtlocalizacao.Text = mEquipamento.localizacao
    End Sub
    Private Sub telatoequipamento()
        mEquipamento.codigo = txtcodigo.Text
        mEquipamento.descricao = txtdescricao.Text
        mEquipamento.fabricante = txtfabricante.Text
        mEquipamento.numserie = txtnumserie.Text
        mEquipamento.numpatrimonio = txtnumpatrimonio.Text
        mEquipamento.localizacao = txtlocalizacao.Text
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnsalva_Click(sender As Object, e As EventArgs) Handles btnsalva.Click
        telatoequipamento()
        If novo Then
            bd.inserir(equipamento)
        Else
            bd.atualizar(equipamento)
        End If
    End Sub

    Public Property equipamento()
        Get
            Return mEquipamento
        End Get
        Set(ByVal value)
            mEquipamento = value
            equipamentotela()
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

End Class