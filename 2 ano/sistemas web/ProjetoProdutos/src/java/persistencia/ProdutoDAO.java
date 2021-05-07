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
 * @author 2info2021
 */
public class ProdutoDAO {
    EntityManager em;
    public ProdutoDAO() {
        em = EntityManagerProvider.getEM();
    }
    public void salva(Produto p) {
        em.getTransaction().begin();
        if (p.getCodigo() == 0) {
            em.persist(p);
        } else {
            em.merge(p);
        }
        em.getTransaction().commit();
    }
    public Produto localiza(int codigo) {
        Produto p = em.find(Produto.class, codigo);
        return p;
    }
    public void exclui(Produto p) {
        em.getTransaction().begin();
        em.remove(p);
        em.getTransaction().commit();
    }
    public List<Produto> presquisa() {
        Query q = em.createQuery("select p from Produto p order by p.fabricante");
        List<Produto> lista = q.getResultList();
        return lista;
    }
    public List<Produto> pesquisa(String fabricante) {
        Query q = em.createNamedQuery("select * from produto where fabricante like :fabricante order by codigo", Produto.class);
        q.setParameter("fabricante", '%' + fabricante + '%');
        List<Produto> lista = q.getResultList();
        return lista;
    }
}
