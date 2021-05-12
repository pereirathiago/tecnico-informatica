/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;

import java.sql.*;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import javax.swing.JOptionPane;
import vo.Equipamento;

/**
 *
 * @author 2info2021
 */
public class BdEquipamento {

    public void insere(Equipamento equipamento) {
        String sql = "insert into equipamento(id,descricao,fabricante,numserie,numpatrimonio,localizacao) values(?,?,?,?,?,?)";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, equipamento.getCodigo());
            ps.setString(2, equipamento.getDescricao());
            ps.setString(3, equipamento.getFabricante());
            ps.setString(4, equipamento.getNumserie());
            ps.setInt(5, equipamento.getNumpatrimonio());
            ps.setString(6, equipamento.getLocalizacao());
            ps.execute();

        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
    }


    public void salva(Equipamento equipamento) {
        if (equipamento.getCodigo() == 0) {
            insere(equipamento);
        } else {
            String sql = "update equipamento set descricao=?,fabricante=?, numserie=?, numpatrimonio=?, localizacao=? where codigo=?";
            try {
                PreparedStatement ps = Bd.getCon().prepareStatement(sql);
                ps.setInt(6, equipamento.getCodigo());
                ps.setString(1, equipamento.getDescricao());
                ps.setString(2, equipamento.getFabricante());
                ps.setString(3, equipamento.getNumserie());
                ps.setInt(4, equipamento.getNumpatrimonio());
                ps.setString(5, equipamento.getLocalizacao());
                ps.execute();
            } catch (SQLException e) {
                JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
            }
        }
    }

    public Equipamento localiza(int codigo) {
        String sql = "select * from equipamento where codigo=?";
        Equipamento registro = new Equipamento();
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, codigo);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
                registro.setCodigo(rs.getInt("codigo"));
                registro.setDescricao(rs.getString("descricao"));
                registro.setFabricante(rs.getString("fabricante"));
                registro.setNumserie(rs.getString("numserie"));
                registro.setNumpatrimonio(rs.getInt("numpatrimonio"));
                registro.setLocalizacao(rs.getString("localizacao"));
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
        return registro;
    }

    public List pesquisa(String busca) {
        String sql = "select * from equipamento where descricao like ?";
        List lista = new ArrayList();
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setString(1, "%" + busca + "%");
            ResultSet rs = ps.executeQuery();
            while (rs.next()) {
                Equipamento registro = new Equipamento();
                registro.setCodigo(rs.getInt("codigo"));
                registro.setDescricao(rs.getString("descricao"));
                registro.setFabricante(rs.getString("fabricante"));
                registro.setNumserie(rs.getString("numserie"));
                registro.setNumpatrimonio(rs.getInt("numpatrimonio"));
                registro.setLocalizacao(rs.getString("localizacao"));
                lista.add(registro);
            }
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
        return lista;
    }


    public void exclui(int codigo) {
        String sql = "delete from equipamento where codigo=?";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
            ps.setInt(1, codigo);
            ps.execute();
        } catch (SQLException e) {
            JOptionPane.showMessageDialog(null, "Erro SQL: " + e.getMessage());
        }
    }
}
