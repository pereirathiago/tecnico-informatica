﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
    private Selecionado selecionado;
    private Paciencia paciencia;



    // Start is called before the first frame update
    void Start()
    {
        List<string> baralho = Paciencia.GerarBaralho();
        paciencia = FindObjectOfType<Paciencia>();

        int i = 0;
        foreach (string carta in baralho)
        {
            if (this.name == carta)
            {
                cardFace = paciencia.faceCartas[i];
                break;
            }
            i++;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        selecionado = GetComponent<Selecionado>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selecionado.faceUp == true)
        {
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
