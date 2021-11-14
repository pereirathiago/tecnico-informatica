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
import persistencia.AlunoDAO;
import vo.Aluno;

/**
 *
 * @author Thiago
 */
@ManagedBean
@RequestScoped
public class TelaLocalizaBean implements Serializable{
    private DataModel<Aluno> listaAluno;
    private Aluno aluno = new Aluno();
    
    AlunoDAO ad = new AlunoDAO();
    
    public TelaLocalizaBean() {
    }
    
    public String atualizaListaAluno() {
        listaAluno = new ListDataModel(ad.pesquisa());
        return "aluno_tela";
    }
    public DataModel<Aluno> getListaAluno() {
        atualizaListaAluno();
        return listaAluno;
    }
    public Aluno alunoSelecionado() {
        Aluno a = listaAluno.getRowData();
        return a;
    }
    public String excluirAluno() {
        Aluno a = alunoSelecionado();
        ad.exclui(a);
        return "aluno_tela";
    }
    public String novoAluno() {
        aluno = new Aluno();
        return "cadastra_aluno";
    }
    public String editarAluno() {
        Aluno a = alunoSelecionado();
        setAluno(a);
        return "cadastra_aluno";
    }
    public String salvaAluno() {
        ad.salva(getAluno());
        return "aluno_tela";
    }
    public String cancelaAluno() {
        return "aluno_tela";
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
}
