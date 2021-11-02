using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardGame : MonoBehaviour
{
    public Sprite[] faceCartas;
    public GameObject cardPrefab;
    public GameObject deckButton;
    public GameObject[] topPos;

    public static string[] naipes = new string[] { "P", "O", "C", "E" };
    public static string[] valores = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    public Queue<string> baralho;
    public Stack<string> tempBaralho = new Stack<string>();
    public List<string> discardPile = new List<string>();

    private int qtdTempBaralho;
    private string primeiraCarta;

    // Start is called before the first frame update
    void Start()
    {
        JogarCartas();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JogarCartas()
    {
        baralho = GerarBaralho();
        Embaralhar(baralho);
        foreach (string carta in baralho)
        {
            print("baralho1: " + carta);
        }
    }

    public static Queue<string> GerarBaralho()
    {
        Queue<string> novoBaralho = new Queue<string>();
        foreach (string n in naipes)
        {
            foreach (string v in valores)
            {
                novoBaralho.Enqueue(n + v);
            }
        }
        return novoBaralho;
    }


    public static void Embaralhar<T>(Queue<T> stack)
    {
        System.Random rnd = new System.Random();
        var values = stack.ToArray();
        stack.Clear();
        foreach (var value in values.OrderBy(x => rnd.Next()))
            stack.Enqueue(value);
    }

    public void TirarCarta()
    {
        foreach (Transform child in deckButton.transform)
        {
            if (child.CompareTag("Card"))
            {
                print("tirei"+baralho.Dequeue());
                discardPile.Add(child.name);
                //print("discardpile: " + discardPile.Last());
                Destroy(child.gameObject);
            }
        }

        qtdTempBaralho = baralho.Count();

        if (qtdTempBaralho != 0)
        {
            print("qtd: " + qtdTempBaralho);
            float xOffset = 2.5f;
            float zOffset = -0.2f;
            string cartaTop = baralho.Peek();
            GameObject newTopCard = Instantiate(cardPrefab, new Vector3(deckButton.transform.position.x + xOffset, deckButton.transform.position.y, deckButton.transform.position.z + zOffset), Quaternion.identity, deckButton.transform);
            newTopCard.GetComponent<Selecionado>().inDeckPile = true;
            newTopCard.name = cartaTop;
            newTopCard.GetComponent<Selecionado>().faceCima = true;
            if(qtdTempBaralho == 52)
            {
                primeiraCarta = cartaTop;
            }
            tempBaralho.Push(cartaTop);
        } else
        {
            RestackTopDeck();
        }
    }

    void RestackTopDeck()
    {
        baralho.Clear();
        foreach (string carta in discardPile)
        {
            baralho.Enqueue(carta);
        }
        baralho.Enqueue(primeiraCarta);
        discardPile.Clear();
        TirarCarta();
    }
}
