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
import persistencia.ProdutoDAO;
import vo.Produto;

/**
 *
 * @author 2info2021
 */
@ManagedBean
@RequestScoped
public class TelaLocalizaBean {

    private DataModel<Produto> lista;
    ProdutoDAO pd = new ProdutoDAO();
    private Produto produto = new Produto();

    public TelaLocalizaBean() {

    }

    public String atualizaLista() {
        lista = new ListDataModel(pd.pesquisa());
        return "index";
    }

    public DataModel<Produto> getLista() {
        atualizaLista();
        return lista;
    }

    public Produto produtoSelecionado() {
        Produto p = lista.getRowData();
        return p;
    }

    public String excluir() {
        Produto p = produtoSelecionado();
        pd.exclui(p);
        return "index";
    }

    public String novo() {
        setProduto(new Produto());
        return "produto";
    }

    public String editar() {
        Produto p=produtoSelecionado();
        produto= p;
        return "produto";
    }

    public String salva() {
        pd.salva(produto);
        return "index";
    }

    public String cancela() {
        return "index";
    }

    /**
     * @return the produto
     */
    public Produto getProduto() {
        return produto;
    }

    /**
     * @param produto the produto to set
     */
    public void setProduto(Produto produto) {
        this.produto = produto;
    }

}
