/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import vo.Aluno;

/**
 *
 * @author Thiago
 */
public class AlunoDAO {

    EntityManager em;

    public AlunoDAO() {
        em = EntityManagerProvider.getEM();
    }

    public void salva(Aluno a) {
        em.getTransaction().begin();
        if (a.getId() == 0) {
            em.persist(a);
        } else {
            em.merge(a);
        }
        em.getTransaction().commit();
    }

    public Aluno localiza(int id) {
        Aluno a = em.find(Aluno.class, id);
        return a;
    }

    public void exclui(Aluno a) {
        em.getTransaction().begin();
        em.remove(a);
        em.getTransaction().commit();
    }

    public List<Aluno> pesquisa() {
        Query q = em.createQuery("select a from Aluno a order by a.nome");
        List<Aluno> listaAluno = q.getResultList();
        return listaAluno;
    }
}
