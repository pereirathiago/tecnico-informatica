using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paciencia : MonoBehaviour
{
    public static string[] naipes = new string[] { "P", "O", "C", "E" };
    public static string[] valores = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "J", "Q", "K" };

    public List<string> baralho;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
