/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bean;

/**
 *
 * @author Thiago
 */
import bd.BdAluno;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;
import javax.faces.model.DataModel;
import javax.faces.model.ListDataModel;
import vo.Aluno;

@ManagedBean
@SessionScoped
public class AlunoBean {

    private Aluno aluno;
    private BdAluno bda = new BdAluno();
    private DataModel<Aluno> lista;

    public AlunoBean() {
        atualizaLista();
    }

    public String salva() {
        bda.salva(aluno);
        atualizaLista();
        return "index";
    }

    public final void atualizaLista() {
        lista = new ListDataModel(bda.pesquisa(""));
    }

    public String exclui() {
        aluno = lista.getRowData();
        bda.exclui(aluno.getCodigo());
        atualizaLista();
        return "";
    }

    public String novo() {
        aluno = new Aluno();
        return "aluno";
    }

    public String edita() {
        aluno = lista.getRowData();
        return "aluno";
    }

    /**
     * @return the aluno
     */
    public Aluno getAluno() {
        return aluno;
    }

    /**
     * @param aluno the aluno to set
     */
    public void setAluno(Aluno aluno) {
        this.aluno = aluno;
    }

    /**
     * @return the bda
     */
    public BdAluno getBda() {
        return bda;
    }

    /**
     * @param bda the bda to set
     */
    public void setBda(BdAluno bda) {
        this.bda = bda;
    }

    /**
     * @return the lista
     */
    public DataModel<Aluno> getLista() {
        return lista;
    }

    /**
     * @param lista the lista to set
     */
    public void setLista(DataModel<Aluno> lista) {
        this.lista = lista;
    }
}
