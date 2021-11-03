using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    private CardGame cardgame;
    public GameObject slot1;

    // Start is called before the first frame update
    void Start()
    {
        cardgame = FindObjectOfType<CardGame>();
        slot1 = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseClick();
    }
    void GetMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -10));
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(hit)
            {
                if (hit.collider.CompareTag("Deck"))
                {
                    // clicou no baralho
                    Baralho();
                }
                else if (hit.collider.CompareTag("Card"))
                {
                    // clicou na carta
                    Card(hit.collider.gameObject);
                }
                else if (hit.collider.CompareTag("Top"))
                {
                    // clicou top
                    Top(hit.collider.gameObject);
                }
            }
        }
    }

    void Baralho()
    {
        // click no baralho
        //print("baralho");
        cardgame.TirarCarta();
        slot1 = this.gameObject;
    }

    void Card(GameObject selected)
    {
        print("clicou no carta");
        if (selected.GetComponent<Selecionado>().inDeckPile)
        {
             slot1 = selected;
            print("ta na pilha");
        }
        else
        {
            print("nn ta na pilha");
            if (slot1 == this.gameObject)
            {
                slot1 = selected;
            }

            else if (slot1 != selected)
            {
                if (Stackable(selected))
                {
                    Stack(selected);
                }
                else
                {
                    slot1 = selected;
                }
            }
        }
    }

    void Top(GameObject selected)
    {
        if (slot1.CompareTag("Card"))
        {
            if (slot1.GetComponent<Selecionado>().value == 1)
            {
                Stack(selected);
            }
        }
    }

    bool Stackable(GameObject selected)
    {
        Selecionado s1 = slot1.GetComponent<Selecionado>();
        Selecionado s2 = selected.GetComponent<Selecionado>();
        if (!s2.inDeckPile)
        {
            if (s2.top)
            {
                if (s1.suit == s2.suit || (s1.value == 1 && s2.suit == null))
                {
                    if (s1.value == s2.value + 1)
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (s1.value == s2.value - 1)
                {
                    bool card1Red = true;
                    bool card2Red = true;

                    if (s1.suit == "P" || s1.suit == "E")
                    {
                        card1Red = false;
                    }
                    if (s2.suit == "P" || s2.suit == "E")
                    {
                        card2Red = false;
                    }

                    if (card1Red == card2Red)
                    {
                        print("nao pilhavel");
                        return false;
                    }
                    else
                    {
                        print("pilhavel");
                        return true;
                    }
                }
            }
        }
        return false;
    }

    void Stack(GameObject selected)
    {
        Selecionado s1 = slot1.GetComponent<Selecionado>();
        Selecionado s2 = selected.GetComponent<Selecionado>();
        float yOffset = 0.3f;
        print("s1:"+s1);
        print("s2: " + s2.top);

        if (s2.top || (!s2.top && s1.value == 13))
        {
            yOffset = 0;
        }

        slot1.transform.position = new Vector3(selected.transform.position.x, selected.transform.position.y - yOffset, selected.transform.position.z - 0.01f);
        slot1.transform.parent = selected.transform;
        if (s1.inDeckPile)
        {

            print("remove" + cardgame.tempBaralho.Pop());
            print("remove" + cardgame.baralho.Pop());


        }
        else if (s1.top && s2.top && s1.value == 1)
        {
            cardgame.topPos[s1.row].GetComponent<Selecionado>().value = 0;
            cardgame.topPos[s1.row].GetComponent<Selecionado>().suit = null;
        }
        else if (s1.top)
        {
            cardgame.topPos[s1.row].GetComponent<Selecionado>().value = s1.value - 1;
        }
        s1.inDeckPile = false;
        s1.row = s2.row;

        if (s2.top)
        {
            cardgame.topPos[s1.row].GetComponent<Selecionado>().value = s1.value;
            cardgame.topPos[s1.row].GetComponent<Selecionado>().suit = s1.suit;
            s2.value = s1.value;
            s2.suit = s1.suit;
            print("jkfadsjlfajl ");

            s1.top = true;
        }
        else
        {
            s1.top = false;
        }
        slot1 = this.gameObject;
    }
}
