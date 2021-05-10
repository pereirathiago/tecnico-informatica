Imports MySql.Data.MySqlClient
Public Class BdEquipamento
    Inherits Bd
    Public Sub New()
        Me.User = "root"
        Me.Servidor = "localhost"
        Me.Senha = "vertrigo"
        Me.bd = "equipamentos"
    End Sub
    Public Sub inserir(ByVal equipamento As Equipamento)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into equipamento (codigo,descricao,fabricante,numserie,numpatrimonio,localizacao) values (@codigo,@descricao,@fabricante,@numserie,@numpatrimonio,@localizacao)"
            cmd.Parameters.AddWithValue("@codigo", equipamento.codigo)
            cmd.Parameters.AddWithValue("@descricao", equipamento.descricao)
            cmd.Parameters.AddWithValue("@fabricante", equipamento.fabricante)
            cmd.Parameters.AddWithValue("@numserie", equipamento.numserie)
            cmd.Parameters.AddWithValue("@numpatrimonio", equipamento.numpatrimonio)
            cmd.Parameters.AddWithValue("@localizacao", equipamento.localizacao)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub atualizar(ByVal equipamento As Equipamento)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update equipamento set descricao=@descricao, fabricante=@fabricante, numserie=@numserie, numpatrimonio=@numpatrimonio, localizacao = @localizacao where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", equipamento.codigo)
            cmd.Parameters.AddWithValue("@descricao", equipamento.descricao)
            cmd.Parameters.AddWithValue("@fabricante", equipamento.fabricante)
            cmd.Parameters.AddWithValue("@numserie", equipamento.numserie)
            cmd.Parameters.AddWithValue("@numpatrimonio", equipamento.numpatrimonio)
            cmd.Parameters.AddWithValue("@localizacao", equipamento.localizacao)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir(ByVal codigo As Integer)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from equipamento where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function localizar(ByVal codigo As Integer) As Equipamento
        Dim dr As MySqlDataAdapter = Nothing
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim equipamento As New Equipamento
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandType = "select * from equipamento where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            dr = cmd.ExecuteReader
            If dr.read Then
                equipamento.codigo = dr.getint32("codigo")
                equipamento.descricao = dr.getstring("descricao")
                equipamento.fabricante = dr.getString("fabricante")
                equipamento.numserie = dr.getString("numserie")
                equipamento.numpatrimonio = dr.getInt32("numpatrimonio")
                equipamento.localizacao = dr.getstring("localizacao")
            End If
        Catch ex As Exception


        End Try
    End Function
End Class
