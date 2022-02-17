/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package br.com.santanapg.crud.controller;

import br.com.santanapg.crud.repository.ContatoRepository;
import br.com.santanapg.crud.vo.Contato;
import java.util.List;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

/**
 *
 * @author Thiago
 */
@RestController
@RequestMapping({"/contato"})
public class ContatoController {

    ContatoRepository repository;

    ContatoController(ContatoRepository contatoRepository) {
        this.repository = contatoRepository;
    }

    @GetMapping
    public List findAll() {
        return repository.findAll();
    }

    @GetMapping(path = {"/{id}"})
    public ResponseEntity<Contato> findById(@PathVariable int id) {
        return repository.findById(id).map(record -> ResponseEntity.ok().body(record)).orElse(ResponseEntity.notFound().build());
    }

    @PostMapping
    public Contato create(@RequestBody Contato contato) {
        return repository.save(contato);
    }

    @PutMapping(value = "/{id}")
    public ResponseEntity<Contato> update(@PathVariable("id") int id, @RequestBody Contato contato) {
        return repository.findById(id).map(record -> {
            record.setNome(contato.getNome());
            record.setEmail(contato.getEmail());
            record.setTelefone(contato.getTelefone());
            Contato atualizado = repository.save(record);
            return ResponseEntity.ok().body(atualizado);
        }).orElse(ResponseEntity.notFound().build());
    }

    @DeleteMapping(path = {"/{id}"})
    public ResponseEntity<?> delete(@PathVariable("id") int id) {
        return repository.findById(id).map(record -> {
            repository.deleteById(id);
            return ResponseEntity.ok().build();
        }).orElse(ResponseEntity.notFound().build());
    }
}
