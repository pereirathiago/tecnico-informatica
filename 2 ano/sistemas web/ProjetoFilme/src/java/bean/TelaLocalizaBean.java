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
import persistencia.FilmeDAO;
import javax.faces.model.ListDataModel;
import vo.Filme;

/**
 *
 * @author 2info2021
 */
@ManagedBean
@RequestScoped
public class TelaLocalizaBean implements Serializable {

    private DataModel<Filme> lista;
    private FilmeDAO pd = new FilmeDAO();
    private Filme filme = new Filme();

    public TelaLocalizaBean() {
    }

    public String atualizaLista() {
        lista = new ListDataModel<>(pd.pesquisa());
        return "index";
    }

    public DataModel<Filme> getLista() {
        atualizaLista();
        return lista;
    }

    public Filme filmeSelecionado() {
        Filme f = lista.getRowData();
        return f;
    }

    public String excluir() {
        Filme f = filmeSelecionado();
        pd.exclui(f);
        return "index";
    }

    public String novo() {
        filme = new Filme();
        return "filme";
    }

    public String editar() {
        Filme f = filmeSelecionado();
        setFilme(f);
        return "filme";
    }

    public String salva() {
        pd.salva(filme);
        return "index";
    }

    public String cancela() {
        return "index";
    }

    /**
     * @param lista the lista to set
     */
    public void setLista(DataModel<Filme> lista) {
        this.lista = lista;
    }

    /**
     * @return the pd
     */
    public FilmeDAO getPd() {
        return pd;
    }

    /**
     * @param pd the pd to set
     */
    public void setPd(FilmeDAO pd) {
        this.pd = pd;
    }

    /**
     * @return the filme
     */
    public Filme getFilme() {
        return filme;
    }

    /**
     * @param filme the filme to set
     */
    public void setFilme(Filme filme) {
        this.filme = filme;
    }
}
