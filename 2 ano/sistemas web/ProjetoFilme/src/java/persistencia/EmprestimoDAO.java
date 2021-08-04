/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import javax.persistence.EntityManager;
import vo.Emprestimo;

/**
 *
 * @author 2info2021
 */
public class EmprestimoDAO {
    
    EntityManager em;
    public EmprestimoDAO() {
        em = EntityManagerProvider.getEM();
    }
    
    public void salva(Emprestimo e) {
        em.getTransaction().begin();
        if (e.getId() == 0) {
            em.persist(e);
        } else {
            em.merge(e);
        }
        em.getTransaction().commit();
   }
}
