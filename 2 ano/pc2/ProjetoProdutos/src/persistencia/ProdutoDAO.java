/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import vo.Produto;

/**
 *
 * @author Thiago
 */
public class ProdutoDAO {
    EntityManager em;
    public ProdutoDAO() {
        em = EntityManagerProvider.getEM();
    }
    public void salva(Produto p) {
        em.getTransaction().begin();
        if(p.getId() == 0) {
            em.persist(p);
        } else {
            em.merge(p);
        }
        em.getTransaction().commit();
    }
    public Produto localiza(int id) {
        Produto p = em.find(Produto.class, id);
        return p;
    }
    public void excluir(Produto p) {
        em.getTransaction().begin();
        em.remove(p);
        em.getTransaction().commit();
    }
    public List<Produto> pesquisa() {
        Query q = em.createQuery("select  from Produto as p order by p.codbar");
        List<Produto>  lista = q.getResultList();
        return lista;
    }
    public List<Produto> pesquisa(String codbar) {
        Query q = em.createNativeQuery("select * from produto where codbar like ? order by codbar", Produto.class);
        q.setParameter(1, '%' + codbar + '%');
        List<Produto> lista = q.getResultList();
        return lista;
    }
}
