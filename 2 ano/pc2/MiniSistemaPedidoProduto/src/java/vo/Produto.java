/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vo;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

/**
 *
 * @author 2info2021
 */
@Entity
public class Produto {
    private static long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idProduto = 0;
    private Integer codBar;
    private String descricao;
    private Integer minimo;
    private Integer quantidadeProd;
    public Produto(Integer idProduto) {
        this.idProduto = idProduto;
    }
    public Produto(){}

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

    /**
     * @return the idProduto
     */
    public Integer getIdProduto() {
        return idProduto;
    }

    /**
     * @param idProduto the idProduto to set
     */
    public void setIdProduto(Integer idProduto) {
        this.idProduto = idProduto;
    }

    /**
     * @return the codBar
     */
    public Integer getCodBar() {
        return codBar;
    }

    /**
     * @param codBar the codBar to set
     */
    public void setCodBar(Integer codBar) {
        this.codBar = codBar;
    }

    /**
     * @return the descricao
     */
    public String getDescricao() {
        return descricao;
    }

    /**
     * @param descricao the descricao to set
     */
    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    /**
     * @return the minimo
     */
    public Integer getMinimo() {
        return minimo;
    }

    /**
     * @param minimo the minimo to set
     */
    public void setMinimo(Integer minimo) {
        this.minimo = minimo;
    }

    /**
     * @return the quantidadeProd
     */
    public Integer getQuantidadeProd() {
        return quantidadeProd;
    }

    /**
     * @param quantidadeProd the quantidadeProd to set
     */
    public void setQuantidadeProd(Integer quantidadeProd) {
        this.quantidadeProd = quantidadeProd;
    }
}
