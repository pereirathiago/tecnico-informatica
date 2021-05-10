/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;

import java.sql.*;
import java.util.HashSet;
import java.util.Set;
import javax.swing.JOptionPane;
import vo.Equipamento;

/**
 *
 * @author 2info2021
 */
public class BdEquipamento {

    public void insere(Equipamento equipamento) {
        String sql = "insert into equipamento(descricao, fabricante, numserie, numpatrimonio, localizacao) value(?,?,?,?,?)";
        try {
            PreparedStatement ps = Bd.getCon().prepareStatement(sql);
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

    public void saida(Equipamento equipamento) {
        if (equipamento.getCodigo() == 0) {
            insere(equipamento);
        } else {
            String sql = "update equipamento set = Bd.getCon().prepareStatement(sql)";
            try {
                PreparedStatement ps = Bd.getCon().prepareStatement(sql);
                ps.setInt(6, equipamento.getCodigo());
                ps.setString(1, equipamento.getDescricao());
                ps.setString(2, equipamento.getFabricante());
                ps.setString(3, equipamento.getNumserie());
                ps.setInt(4, equipamento.getNumpatrimonio());
                ps.setString(5, equipamento.getLocalizacao());

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
                registro.setCodigo(rs.getInt("codigo"));
                registro.setCodigo(rs.getInt("codigo"));
                registro.setCodigo(rs.getInt("codigo"));
                registro.setCodigo(rs.getInt("codigo"));
                registro.setCodigo(rs.getInt("codigo"));
            }
        } catch (Exception e) {
        }
    }
}
