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
import persistencia.ClienteDAO;
import persistencia.PedidoDAO;
import persistencia.ProdutoDAO;
import vo.Cliente;
import vo.Pedido;
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

    private DataModel<Cliente> listaCliente;
    private ClienteDAO cd = new ClienteDAO();
    private Cliente cliente = new Cliente();

    private DataModel<Pedido> listaPedido;
    private PedidoDAO ped = new PedidoDAO();
    private Pedido pedido = new Pedido();

    public TelaLocalizaBean() {
    }

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

    public String atualizaListaCliente() {
        listaCliente = new ListDataModel(cd.pesquisa());
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

    public String novoCliente() {
        setCliente(new Cliente());
        return "cadastro_cliente";
    }

    public String excluirCliente() {
        Cliente c = clienteSelecionado();
        cd.exclui(c);
        return "cliente";
    }

    public String editarCliente() {
        Cliente c = clienteSelecionado();
        setCliente(c);
        return "cadastro_cliente";
    }

    public String salvaCliente() {
        cd.salva(getCliente());
        return "cliente";
    }

    public String cancelaCliente() {
        return "cliente";
    }

    public String atualizaListaPedido() {
        listaPedido = new ListDataModel(ped.pesquisa());
        return "pedido";
    }

    public DataModel<Pedido> getListaPedido() {
        atualizaListaPedido();
        return listaPedido;
    }

    public Pedido pedidoSelecionado() {
        Pedido p = getListaPedido().getRowData();
        return p;
    }

    public String excluirPedido() {
        Pedido p = pedidoSelecionado();
        ped.exclui(p);
        return "pedido";
    }

    public String novoPedido() {
        setPedido(new Pedido());
        return "cadastro_pedido";
    }

    public String editarPedido() {
        Pedido p = pedidoSelecionado();
        setPedido(p);
        return "cadastro_pedido";
    }
    
    public String salvaPedido() {
        if(pd.localiza(pedido.getIdProduto()) != null) {
            if(cd.localiza(pedido.getIdCliente()) != null) {
                ped.salva(pedido);
                return "pedido";
            }
        }
        return "";
    }
    
    public String cancelaPedido() {
        return "pedido";
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
     * @return the pedido
     */
    public Pedido getPedido() {
        return pedido;
    }

    /**
     * @param pedido the pedido to set
     */
    public void setPedido(Pedido pedido) {
        this.pedido = pedido;
    }
}
