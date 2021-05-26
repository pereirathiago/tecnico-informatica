/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bean;

import java.io.Serializable;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.RequestScoped;
import javax.faces.model.DataModel;
import javax.faces.model.ListDataModel;
import persistencia.VeiculoDAO;
import vo.Veiculo;

/**
 *
 * @author 2info2021
 */
@ManagedBean
@RequestScoped
public class TelaLocalizaBean implements Serializable {

    private DataModel<Veiculo> lista;
    VeiculoDAO pd = new VeiculoDAO();
    private Veiculo veiculo = new Veiculo();

    public TelaLocalizaBean() {
    }

    public String atualizaLista() {
        lista = new ListDataModel<>(pd.pesquisa());
        return "index";
    }

    public DataModel<Veiculo> getLista() {
        atualizaLista();
        return lista;
    }

    public Veiculo veiculoSelecionado() {
        Veiculo v = lista.getRowData();
        return v;
    }

    public String excluir() {
        Veiculo v = veiculoSelecionado();
        pd.exclui(v);
        return "index";
    }

    public String novo() {
        veiculo = new Veiculo();
        return "cadastraVeiculo";
    }

    public String editar() {
        Veiculo v = veiculoSelecionado();
        setVeiculo(v);
        return "cadastraVeiculo";
    }

    public String salva() {
        pd.salva(veiculo);
        return "index";
    }

    public String cancela() {
        return "index";
    }

    /**
     * @return the veiculo
     */
    public Veiculo getVeiculo() {
        return veiculo;
    }

    /**
     * @param veiculo the veiculo to set
     */
    public void setVeiculo(Veiculo veiculo) {
        this.veiculo = veiculo;
    }
}
