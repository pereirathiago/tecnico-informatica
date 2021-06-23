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
import persistencia.ClienteDAO;
import javax.faces.model.ListDataModel;
import vo.Cliente;
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
    
    private DataModel<Cliente> listaCliente;
    private ClienteDAO pdCliente = new ClienteDAO();
    private Cliente cliente = new Cliente();

    public TelaLocalizaBean() {
    }

    public String verFilmes()
    {
        return "filme";
    }
    
    public String verClientes()
    {
        return "cliente";
    }
    
    public String atualizaListaFilme() {
        lista = new ListDataModel<>(pd.pesquisa());
        return "filme";
    }

    public DataModel<Filme> getLista() {
        atualizaListaFilme();
        return lista;
    }

    public Filme filmeSelecionado() {
        Filme f = lista.getRowData();
        return f;
    }

    public String excluirFilme() {
        Filme f = filmeSelecionado();
        pd.exclui(f);
        return "filme";
    }

    public String novoFilme() {
        filme = new Filme();
        return "cadastro_filme";
    }

    public String editarFilme() {
        Filme f = filmeSelecionado();
        setFilme(f);
        return "cadastro_filme";
    }

    public String salvaFilme() {
        pd.salva(filme);
        return "filme";
    }

    public String cancelaFilme() {
        return "filme";
    }
    
    public String atualizaListaCliente() {
        lista = new ListDataModel<>(pd.pesquisa());
        return "cliente";
    }

    public DataModel<Cliente> getListaCliente() {
        atualizaListaCliente();
        return listaCliente;
    }

    public Cliente clienteSelecionado() {
        Cliente c = listaCliente.getRowData();
        return c;
    }

    public String excluirCliente() {
        Cliente c = clienteSelecionado();
        pdCliente.exclui(c);
        return "cliente";
    }

    public String novoCliente() {
        cliente = new Cliente();
        return "cadastro_cliente";
    }

    public String editarCliente {
        Cliente c = clienteSelecionado();
        setCliente(c);
        return "cadastro_cliente";
    }

    public String salvaCliente() {
        pd.salva(filme);
        return "filme";
    }

    public String cancelaFilme() {
        return "filme";
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
