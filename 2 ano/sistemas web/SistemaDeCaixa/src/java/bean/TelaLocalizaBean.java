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
import persistencia.MovimentoDAO;
import vo.Movimento;

/**
 *
 * @author 2info2021
 */
@ManagedBean
@RequestScoped
public class TelaLocalizaBean implements Serializable {

    private DataModel<Movimento> lista;    
    private DataModel<Movimento> listaSaida;
    private DataModel<Movimento> listaEntrada;
    MovimentoDAO md = new MovimentoDAO();
    private Movimento movimento = new Movimento();

    public TelaLocalizaBean() {
    }

    public Double saldo(){
        return md.calcularSaldo();
    }
    public Double saldoEntradas(){
        return md.calcularSaldoEntradas();
    }
    public Double saldoSaidas(){
        return md.calcularSaldoSaidas();
    }
    
    public String atualizaLista() {
        lista = new ListDataModel(md.pesquisa());
        return "index";
    }
    public String atualizaListaSaidas() {
        listaSaida = new ListDataModel(md.pesquisaSaidas());
        return "saidas";
    }
    public String atualizaListaEntradas() {
        listaEntrada = new ListDataModel(md.pesquisaEntradas());
        return "entradas";
    }

    public DataModel<Movimento> getLista() {
        atualizaLista();
        return lista;
    }
    public DataModel<Movimento> getListaSaida() {
        atualizaListaSaidas();
        return listaSaida;
    }
    public DataModel<Movimento> getListaEntrada() {
        atualizaListaEntradas();
        return listaEntrada;
    }

    public String novo() {
        setMovimento(new Movimento());
        System.out.println("deu boa");
        return "cadastro_movimento";
    }

    public String salva() {
        md.salva(getMovimento());
        return "index";
    }

    public String cancela() {
        return "index";
    }
    
    /**
     * @return the movimento
     */
    public Movimento getMovimento() {
        return movimento;
    }

    /**
     * @param movimento the movimento to set
     */
    public void setMovimento(Movimento movimento) {
        this.movimento = movimento;
    }
}
