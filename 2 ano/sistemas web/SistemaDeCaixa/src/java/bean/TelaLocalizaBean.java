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
    MovimentoDAO md = new MovimentoDAO();
    private Movimento movimento = new Movimento();

    public TelaLocalizaBean() {
    }

    public String atualizaLista() {
        lista = new ListDataModel(md.pesquisa());
        return "index";
    }

    public DataModel<Movimento> getLista() {
        atualizaLista();
        return lista;
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
