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
public class TelaLocalizaBean implements Serializable {
    private DataModel<Produto> listaProduto;
    private ProdutoDAO pd = new ProdutoDAO();
    private Produto produto = new Produto();
    
    public TelaLocalizaBean() {}
    
    public String atualizaListaProduto() {
        listaProduto = new ListDataModel(pd.pesquisa());
        return "produto";
    }
    
    public DataModel<Produto> getListaProduto() {
        atualizaListaProduto();
        return listaProduto;
    }
    
    public Produto produtoSelecionado() {
        Produto p = listaProduto.getRowData();
        return p;
    }
    
    public String novoProduto() {
        produto = new Produto();
        return "cadastro_produto";
    }
    
    public String excluirProduto() {
        Produto p = produtoSelecionado();
        pd.exclui(p);
        return "produto";
    }
    
    public String editarProduto() {
        Produto p = produtoSelecionado();
        setProduto(p);
        return "cadastro_produto";
    }
    
    public String salvaProduto() {
        pd.salva(getProduto());
        return "produto";
    }
    
    public String cancelaProduto() {
        return "produto";
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
