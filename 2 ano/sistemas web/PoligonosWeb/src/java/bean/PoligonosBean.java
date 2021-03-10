/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bean;

import poligonos.Poligonos;
import javax.faces.bean.ManagedBean;

/**
 *
 * @author Adm
 */
@ManagedBean
public class PoligonosBean {
    private Poligonos poli = new Poligonos();
    public String areaQuadrado() {
        getPoli().areaQuadrado();
        return null;
    }
    public String perimetro() {
        getPoli().perimetro();
        return null;
    }
    public String areaTriangulo() {
        getPoli().areaTriangulo();
        return null;
    }
    /**
     * @return the poli
     */
    public Poligonos getPoli() {
        return poli;
    }

    /**
     * @param poli the calc to set
     */
    public void setPoli(Poligonos poli) {
        this.poli = poli;
    }
}
