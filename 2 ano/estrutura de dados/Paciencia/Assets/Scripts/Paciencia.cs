using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paciencia : MonoBehaviour
{
    public Sprite[] faceCartas;
    public GameObject cardPrefab;

    public static string[] naipes = new string[] { "P", "O", "C", "E" };
    public static string[] valores = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    public List<string> baralho;

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
            print(carta);
        }
        PacienciaDeal();
    }

    public static List<string> GerarBaralho()
    {
        List<string> novoBaralho = new List<string>();
        foreach (string n in naipes)
        {
            foreach (string v in valores)
            {
                novoBaralho.Add(n + v);
            }
        }
        return novoBaralho;
    }

    void Embaralhar<T>(List<T> list)
    {
        System.Random rng = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    void PacienciaDeal()
    {
        float yOffset = 0;
        float zOffset = 0.03f;
        foreach(string carta in baralho)
        {
            GameObject novaCarta = Instantiate(cardPrefab, new Vector3(transform.position.x, transform.position.y - yOffset, transform.position.z - zOffset), Quaternion.identity);
            novaCarta.name = carta;
            novaCarta.GetComponent<Selecionado>().faceCima = true;

            yOffset = yOffset + 0.5f;
            zOffset = zOffset + 0.03f;
        }
    }
}
