using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Paciencia : MonoBehaviour
{
    public Sprite[] faceCartas;
    public GameObject cardPrefab;
    public GameObject[] bottomPos;
    public GameObject[] topPos;

    public static string[] naipes = new string[] { "P", "O", "C", "E" };
    public static string[] valores = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    public List<string>[] bottoms;
    public List<string>[] tops;

    private List<string> bottom0 = new List<string>();
    private List<string> bottom1 = new List<string>();
    private List<string> bottom2 = new List<string>();
    private List<string> bottom3 = new List<string>();
    private List<string> bottom4 = new List<string>();
    private List<string> bottom5 = new List<string>();
    private List<string> bottom6 = new List<string>();

    public List<string> baralho;

    // Start is called before the first frame update
    void Start()
    {
        bottoms = new List<string>[] { bottom0, bottom1, bottom2, bottom3, bottom4, bottom5, bottom6 };
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
        PacienciaSort();
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
        for (int i = 0; i < 7; i++)
        {
            float yOffset = 0;
            float zOffset = 0.03f;
            foreach (string carta in bottoms[i])
            {
                GameObject novaCarta = Instantiate(cardPrefab, new Vector3(bottomPos[i].transform.position.x, bottomPos[i].transform.position.y - yOffset, bottomPos[i].transform.position.z - zOffset), Quaternion.identity, bottomPos[i].transform);
                novaCarta.name = carta;
                novaCarta.GetComponent<Selecionado>().faceCima = true;

                yOffset = yOffset + 0.5f;
                zOffset = zOffset + 0.03f;
            }
        }
    }

    void PacienciaSort()
    {
        for(int i = 0; i < 7; i++)
        {
            for(int j = i; j < 7; j++)
            {
                bottoms[j].Add(baralho.Last<string>());
                baralho.RemoveAt(baralho.Count - 1);
            }
        }
    }
}
