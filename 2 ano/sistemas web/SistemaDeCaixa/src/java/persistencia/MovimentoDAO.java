/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import vo.Movimento;

/**
 *
 * @author 2info2021
 */
public class MovimentoDAO {

    EntityManager em;

    public MovimentoDAO() {
        em = EntityManagerProvider.getEM();
    }

    public void salva(Movimento m) {
        em.getTransaction().begin();
        if (m.getId() == 0) {
            em.persist(m);
        } else {
            em.merge(m);
        }
        em.getTransaction().commit();
    }

    public Movimento localiza(int id) {
        Movimento m = em.find(Movimento.class, id);
        return m;
    }

    public List<Movimento> pesquisa() {
        Query q = em.createQuery("select m from Movimento m order by b.nome");
        List<Movimento> listaMovimento = q.getResultList();
        return listaMovimento;
    }

    public List<Movimento> pesquisa(String descricao) {
        Query q = em.createNativeQuery("select * from professor where descricao like :descricao order by descricao", Movimento.class);
        q.setParameter("descricao", '%' + descricao + '%');
        List<Movimento> listaMovimento = q.getResultList();
        return listaMovimento;
    }
}
