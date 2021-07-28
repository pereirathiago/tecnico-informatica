/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistencia;

import javax.persistence.EntityManager;

/**
 *
 * @author 2info2021
 */
public class EmprestimoDAO {
    
    EntityManager em;
    public EmprestimoDAO() {
        em = EntityManagerProvider.getEM();
    }
}
