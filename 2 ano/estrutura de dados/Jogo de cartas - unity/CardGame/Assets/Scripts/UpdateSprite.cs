using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
    private Selecionado selecionado;
    private CardGame cardGame;
    private UserInput userInput;

    // Start is called before the first frame update
    void Start()
    {
        Queue<string> baralho = CardGame.GerarBaralho();
        cardGame = FindObjectOfType<CardGame>();
        userInput = FindObjectOfType<UserInput>();
        /*foreach(Sprite carta in cardGame.faceCartas)
        {
            print("sprite:" + carta);
        }*/

        int i = 0;
        foreach (string carta in baralho)
        {
            //print("name: " + this.name + " carta: " + carta);
            //print(i);
            if (this.name == carta)
            {
                cardFace = cardGame.faceCartas[i];
                //print("cardface: " + cardFace);
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
        if (selecionado.faceCima == true)
        {
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }

        if (userInput.slot1)
        {
            if (name == userInput.slot1.name)
            {
                spriteRenderer.color = Color.yellow;
            }
            else
            {
                spriteRenderer.color = Color.white;
            }
        }
    }
}
