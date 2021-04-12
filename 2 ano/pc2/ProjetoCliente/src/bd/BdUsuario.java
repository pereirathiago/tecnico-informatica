/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JOptionPane;
import vo.Cliente;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Thiago
 */
public class BdUsuario {

    public void insere(Cliente cliente) {
        String sql = "insert into cliente (codigo,nome,endereco,cidade,uf,telefone,renda) values(?,?,?)";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, cliente.getCodigo());
            ps.setString(2, cliente.getNome());
            ps.setString(3, cliente.getEndereco());
            ps.setString(4, cliente.getCidade());
            ps.setString(5, cliente.getUf());
            ps.setString(6, cliente.getTelefone());
            ps.setDouble(7, cliente.getRenda());
            ps.execute();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
    }

    public void atualiza(Cliente cliente) {
        String sql = "update cliente set nome=?,endereco=?,cidade=?,uf=?,telefone=?,renda=? where codigo=?";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, cliente.getCodigo());
            ps.setString(2, cliente.getNome());
            ps.setString(3, cliente.getEndereco());
            ps.setString(4, cliente.getCidade());
            ps.setString(5, cliente.getUf());
            ps.setString(6, cliente.getTelefone());
            ps.setDouble(7, cliente.getRenda());
            ps.execute();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
    }

    public Cliente localiza(String user) {
        String sql = "select * from cliente where codigo=?";

        Cliente registro = new Cliente();
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setString(1, user);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                registro.setCodigo(rs.getInt("codigo"));
                registro.setNome(rs.getString("nome"));
                registro.setEndereco(rs.getString("endereco"));
                registro.setCidade(rs.getString("cidade"));
                registro.setUf(rs.getString("uf"));
                registro.setTelefone(rs.getString("telefone"));
                registro.setRenda(rs.getDouble("renda"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
        return registro;
    }

    public void exclui(String user) {
        String sql = "delete from cliente where codigo=?";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setString(1, user);
            ps.execute();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
    }

    public List<Cliente> pesquisa(String user) {
        String sql = "select * from usuario where user like ?";
        List<Cliente> lista = new ArrayList();
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setString(1, "%" + user + "%");
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                Cliente registro = new Cliente();
                registro.setCodigo(rs.getInt("codigo"));
                registro.setNome(rs.getString("nome"));
                registro.setEndereco(rs.getString("endereco"));
                registro.setCidade(rs.getString("cidade"));
                registro.setUf(rs.getString("uf"));
                registro.setTelefone(rs.getString("telefone"));
                registro.setRenda(rs.getDouble("renda"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
        return lista;
    }
}
