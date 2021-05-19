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
public class Veiculo implements Serializable{
    // private static final long serialVersionUID = 1L;
    @Id
    // @GeneratedValue(strategy = GenerationType.IDENTITY)
    private String renavam;
    private String placa;
    private String chassi;
    private String marca;
    private String modelo;
    @Temporal(TemporalType.DATE) 
    private Date anofab;
    private Date anomod;
    public Veiculo(String renavam) {
        this.renavam = renavam;
    }
    public Veiculo(){}

    /**
     * @return the renavam
     */
    public String getRenavam() {
        return renavam;
    }

    /**
     * @param renavam the renavam to set
     */
    public void setRenavam(String renavam) {
        this.renavam = renavam;
    }

    /**
     * @return the placa
     */
    public String getPlaca() {
        return placa;
    }

    /**
     * @param placa the placa to set
     */
    public void setPlaca(String placa) {
        this.placa = placa;
    }

    /**
     * @return the chassi
     */
    public String getChassi() {
        return chassi;
    }

    /**
     * @param chassi the chassi to set
     */
    public void setChassi(String chassi) {
        this.chassi = chassi;
    }

    /**
     * @return the marca
     */
    public String getMarca() {
        return marca;
    }

    /**
     * @param marca the marca to set
     */
    public void setMarca(String marca) {
        this.marca = marca;
    }

    /**
     * @return the modelo
     */
    public String getModelo() {
        return modelo;
    }

    /**
     * @param modelo the modelo to set
     */
    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    /**
     * @return the anofab
     */
    public Date getAnofab() {
        return anofab;
    }

    /**
     * @param anofab the anofab to set
     */
    public void setAnofab(Date anofab) {
        this.anofab = anofab;
    }

    /**
     * @return the anomod
     */
    public Date getAnomod() {
        return anomod;
    }

    /**
     * @param anomod the anomod to set
     */
    public void setAnomod(Date anomod) {
        this.anomod = anomod;
    }
}
