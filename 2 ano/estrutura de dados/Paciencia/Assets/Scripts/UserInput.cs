using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class UserInput : MonoBehaviour
{
    private Paciencia paciencia;

    // Start is called before the first frame update
    void Start()
    {
        paciencia = FindObjectOfType<Paciencia>();
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }

    void GetMouseClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit)
            {
                // pode clicar em baralho, carta, vazio
                if(hit.collider.CompareTag("Deck"))
                {
                    // clicou no baralho
                    Baralho();
                } else if (hit.collider.CompareTag("Card"))
                {
                    // clicou na carta
                    Carta();
                }
                else if (hit.collider.CompareTag("Top"))
                {
                    // clicou top
                    Top();
                }
                else if (hit.collider.CompareTag("Bottom"))
                {
                    // clicou bottom
                    Bottom();
                }
            }
        }
    }

    void Baralho()
    {
        // click no baralho
        print("clicou no baralho");
        paciencia.DealFromDeck();
    }
    void Carta()
    {
        // click no carta
        print("clicou no carta");
    }
    void Top()
    {
        // click no top
        print("clicou no top");
    }
    void Bottom()
    {
        // click no bottom
        print("clicou no bottom");
    }
}
