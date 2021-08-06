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
import persistencia.EmprestimoDAO;
import vo.Cliente;
import vo.Emprestimo;
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
    private ClienteDAO cp = new ClienteDAO();
    private Cliente cliente = new Cliente();
    
    private DataModel<Emprestimo> listaEmprestimo;
    private EmprestimoDAO ed = new EmprestimoDAO();
    private Emprestimo emprestimo = new Emprestimo();

    public TelaLocalizaBean() {
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
        listaCliente = new ListDataModel<>(cp.pesquisa());
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
        getCp().exclui(c);
        return "cliente";
    }

    public String novoCliente() {
        setCliente(new Cliente());
        return "cadastro_cliente";
    }

    public String editarCliente() {
        Cliente c = clienteSelecionado();
        setCliente(c);
        return "cadastro_cliente";
    }

    public String salvaCliente() {
        getCp().salva(cliente);
        return "cliente";
    }

    public String cancelaCliente() {
        return "cliente";
    }
    
    public String atualizaListaEmprestimo() {
        listaEmprestimo = new ListDataModel(ed.pesquisa());
        return "emprestimo";
    }

    public DataModel<Emprestimo> getListaEmprestimo(){
        atualizaListaEmprestimo();
        return listaEmprestimo;
    }

    public Emprestimo emprestimoSelecionado() {
        Emprestimo e = listaEmprestimo.getRowData();
        return e;
    }

    public String excluirEmprestimo() {
        Emprestimo e = emprestimoSelecionado();
        ed.exclui(e);
        return "emprestimo";
    }

    public String novoEmprestimo() {
        setEmprestimo(new Emprestimo());
        return "cadastro_emprestimo";
    }

    public String editarEmprestimo() {
        Emprestimo e = emprestimoSelecionado();
        setEmprestimo(e);
        return "cadastro_emprestimo";
    }

    public String salvaEmprestimo() {
        ed.salva(getEmprestimo());
        return "emprestimo";
    }

    public String cancelaEmprestimo() {
        return "emprestimo";
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

    /**
     * @return the cliente
     */
    public Cliente getCliente() {
        return cliente;
    }

    /**
     * @param cliente the cliente to set
     */
    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    /**
     * @return the cp
     */
    public ClienteDAO getCp() {
        return cp;
    }

    /**
     * @param cp the cp to set
     */
    public void setCp(ClienteDAO cp) {
        this.cp = cp;
    }

    /**
     * @return the emprestimo
     */
    public Emprestimo getEmprestimo() {
        return emprestimo;
    }

    /**
     * @param emprestimo the emprestimo to set
     */
    public void setEmprestimo(Emprestimo emprestimo) {
        this.emprestimo = emprestimo;
    }

    
}
