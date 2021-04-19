Imports MySql.Data.MySqlClient
Public Class BdCliente
    Inherits Bd
    Public Sub New()
        Me.User = "root"
        Me.Servidor = "localhost"
        Me.Senha = ""
        Me.bd = "cliente"
    End Sub
    Public Sub inserir(ByVal cliente As Cliente)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter()
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into cliente (codigo,nome,endereco,cidade,uf,telefone,renda) values(@codigo,@nome,@endereco,@cidade,@uf,@telefone,@renda)"
            cmd.Parameters.AddWithValue("@codigo", cliente.codigo)
            cmd.Parameters.AddWithValue("@nome", cliente.nome)
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco)
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade)
            cmd.Parameters.AddWithValue("@uf", cliente.uf)
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone)
            cmd.Parameters.AddWithValue("@renda", cliente.renda)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()

            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub atualizar(ByVal cliente As Cliente)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter()
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update cliente set nome=@nome,endereco=@endereco,cidade=@cidade,uf=@uf,telefone=@telefone,renda=@renda where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", cliente.codigo)
            cmd.Parameters.AddWithValue("@nome", cliente.nome)
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco)
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade)
            cmd.Parameters.AddWithValue("@uf", cliente.uf)
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone)
            cmd.Parameters.AddWithValue("@renda", cliente.renda)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir(ByVal user As String)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter()
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from cliente where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", user)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function localizar(ByVal codigo As String) As Cliente
        Dim dr As MySqlDataReader = Nothing
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim c As New Cliente
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from cliente where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            dr = cmd.ExecuteReader
            If dr.Read Then
                c.codigo = dr.GetInt32("codigo")
                c.nome = dr.GetString("nome")
                c.endereco = dr.GetString("endereco")
                c.cidade = dr.GetString("cidade")
                c.uf = dr.GetString("uf")
                c.telefone = dr.GetString("telefone")
                c.renda = dr.GetDouble("renda")
            End If
            cmd.Dispose()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return c
    End Function
End Class
