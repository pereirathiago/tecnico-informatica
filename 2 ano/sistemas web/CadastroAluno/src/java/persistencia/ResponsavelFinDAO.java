/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import vo.ResponsavelFin;

/**
 *
 * @author Thiago
 */
public class ResponsavelFinDAO {

    EntityManager em;

    public ResponsavelFinDAO() {
        em = EntityManagerProvider.getEM();
    }

    public void salva(ResponsavelFin r) {
        em.getTransaction().begin();
        if (r.getId() == 0) {
            em.persist(r);
        } else {
            em.merge(r);
        }
        em.getTransaction().commit();
    }

    public ResponsavelFin localiza(int id) {
        ResponsavelFin r = em.find(ResponsavelFin.class, id);
        return r;
    }

    public void exclui(ResponsavelFin r) {
        em.getTransaction().begin();
        em.remove(r);
        em.getTransaction().commit();
    }

    public List<ResponsavelFin> pesquisa() {
        Query q = em.createQuery("select r from ResponsavelFin r order by r.nome");
        List<ResponsavelFin> listaResponsavel = q.getResultList();
        return listaResponsavel;
    }
}
