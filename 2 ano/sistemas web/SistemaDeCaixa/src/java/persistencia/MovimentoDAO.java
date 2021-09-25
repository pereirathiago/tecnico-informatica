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
        Query q = em.createQuery("select m from Movimento m order by m.data");
        List<Movimento> listaMovimento = q.getResultList();
        return listaMovimento;
    }
    public List<Movimento> pesquisaSaidas() {
        Query q = em.createQuery("select m from Movimento m where m.tipo = 'Saída' order by m.data");
        List<Movimento> listaMovimento = q.getResultList();
        return listaMovimento;
    }
    public List<Movimento> pesquisaEntradas() {
        Query q = em.createQuery("select m from Movimento m where m.tipo = 'Entrada' order by m.data");
        List<Movimento> listaMovimento = q.getResultList();
        return listaMovimento;
    }
    public Double calcularSaldo(){
        Double entradas = calcularSaldoEntradas();
        Double saidas = calcularSaldoSaidas();
        Double saldo = entradas - saidas;
        return saldo;
    }
    public Double calcularSaldoEntradas(){
        Query q = em.createNativeQuery("select SUM(valor) from movimento where tipo = 'Entrada'");
        List<Double> lista = q.getResultList();
        Double saldo = lista.get(0)!=null?lista.get(0):0;
        return saldo;
    }
    public Double calcularSaldoSaidas(){
        Query q = em.createNativeQuery("select SUM(valor) from movimento where tipo = 'Saida'");
        List<Double> lista = q.getResultList();
        Double saldo = lista.get(0)!=null?lista.get(0):0;
        return saldo;
    }
}
