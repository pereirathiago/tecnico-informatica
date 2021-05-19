/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import java.util.List;
import javax.persistence.EntityManager;
import javax.persistence.Query;
import vo.Veiculo;

/**
 *
 * @author 2info2021
 */
public class VeiculoDAO {

    EntityManager em;

    public VeiculoDAO() {
        em = EntityManagerProvider.getEM();
    }

    public void salva(Veiculo v) {
        em.getTransaction().begin();
        if (v.getRenavam() == "") {
            em.persist(v);
        } else {
            em.merge(v);
        }
        em.getTransaction().commit();
    }

    public Veiculo localiza(String renavam) {
        Veiculo v = em.find(Veiculo.class, renavam);
        return v;
    }

    public void exclui(Veiculo v) {
        em.getTransaction().begin();
        em.remove(v);
        em.getTransaction().commit();
    }

    public List<Veiculo> pesquisa() {
        Query q = em.createQuery("select v from Veiculo v order by v.renavam");
        List<Veiculo> lista = q.getResultList();
        return lista;
    }

    public List<Veiculo> pesquisa(String renavam) {
        Query q = em.createNativeQuery("select * from veiculo where renavam like :renavam order by renavam", Veiculo.class);
        q.setParameter("renavam", '%' + renavam + '%');
        List<Veiculo> lista = q.getResultList();
        return lista;
    }
}
