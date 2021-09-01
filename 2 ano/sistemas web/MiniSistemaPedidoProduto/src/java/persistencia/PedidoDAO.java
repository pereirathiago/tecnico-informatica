/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import vo.Pedido;

/**
 *
 * @author Thiago
 */
public class PedidoDAO {
    EntityManager em;
    public PedidoDAO() {
        em = EntityManagerProvider.getEM();
    }
    
    public void salva(Pedido p) {
        em.getTransaction().begin();
        if (p.getIdPedido() == 0) {
            em.persist(p);
        } else {
            em.merge(p);
        }
        em.getTransaction().commit();
    }
    
    public void exclui(Pedido p) {
        em.getTransaction().begin();
        em.remove(p);
        em.getTransaction().commit();
    }
    
    public List<Pedido> pesquisa() {
        Query q = em.createQuery("select p from Pedido p");
        List<Pedido> listaPedido = q.getResultList();
        return listaPedido;
    }
}
