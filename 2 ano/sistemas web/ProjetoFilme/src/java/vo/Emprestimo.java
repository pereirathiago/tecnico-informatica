/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vo;

import java.io.Serializable;
import java.util.Date;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.Temporal;
import javax.persistence.TemporalType;

/**
 *
 * @author 2info2021
 */
@Entity
public class Emprestimo implements Serializable {
    private static long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id=0;
    private Integer idCliente;
    private Integer idFilme;
    @Temporal(TemporalType.DATE)
    private Date dataempr; 
    public Emprestimo(Integer id) {
        this.id = id;
    }
    public Emprestimo(){}

    /**
     * @return the id
     */
    public Integer getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(Integer id) {
        this.id = id;
    }

    /**
     * @return the idCliente
     */
    public Integer getIdCliente() {
        return idCliente;
    }

    /**
     * @param idCliente the idCliente to set
     */
    public void setIdCliente(Integer idCliente) {
        this.idCliente = idCliente;
    }

    /**
     * @return the idFilme
     */
    public Integer getIdFilme() {
        return idFilme;
    }

    /**
     * @param idFilme the idFilme to set
     */
    public void setIdFilme(Integer idFilme) {
        this.idFilme = idFilme;
    }

    /**
     * @return the dataempr
     */
    public Date getDataempr() {
        return dataempr;
    }

    /**
     * @param dataempr the dataempr to set
     */
    public void setDataempr(Date dataempr) {
        this.dataempr = dataempr;
    }

    /**
     * @return the serialVersionUID
     */
    public static long getSerialVersionUID() {
        return serialVersionUID;
    }

    /**
     * @param aSerialVersionUID the serialVersionUID to set
     */
    public static void setSerialVersionUID(long aSerialVersionUID) {
        serialVersionUID = aSerialVersionUID;
    }
}
