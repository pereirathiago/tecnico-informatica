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
 * @author Thiago
 */
@Entity
public class Aluno implements Serializable {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id = 0;
    private String nome;
    @Temporal(TemporalType.DATE)
    private Date datanasc; 
    private String endereco;
    private String Filiacao;
    private Integer idFiliacao;

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
     * @return the nome
     */
    public String getNome() {
        return nome;
    }

    /**
     * @param nome the nome to set
     */
    public void setNome(String nome) {
        this.nome = nome;
    }

    /**
     * @return the datanasc
     */
    public Date getDatanasc() {
        return datanasc;
    }

    /**
     * @param datanasc the datanasc to set
     */
    public void setDatanasc(Date datanasc) {
        this.datanasc = datanasc;
    }

    /**
     * @return the endereco
     */
    public String getEndereco() {
        return endereco;
    }

    /**
     * @param endereco the endereco to set
     */
    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    /**
     * @return the idfiliacao
     */
    public Integer getIdFiliacao() {
        return idFiliacao;
    }

    /**
     * @param idFiliacao the idfiliacao to set
     */
    public void setIdFiliacao(Integer idFiliacao) {
        this.idFiliacao = idFiliacao;
    }

    /**
     * @return the Filiacao
     */
    public String getFiliacao() {
        return Filiacao;
    }

    /**
     * @param Filiacao the Filiacao to set
     */
    public void setFiliacao(String Filiacao) {
        this.Filiacao = Filiacao;
    }
}
