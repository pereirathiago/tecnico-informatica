/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package br.com.santanapg.crud.repository;

import br.com.santanapg.crud.vo.Contato;
import org.springframework.data.jpa.repository.JpaRepository;

/**
 *
 * @author Thiago
 */
public interface ContatoRepository extends JpaRepository<Contato, Integer> {
    
}
