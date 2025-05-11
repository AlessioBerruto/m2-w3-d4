using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax;
    List<int> lista= new List<int>();
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numeroMax + 1; i++)
        {
            if (i % 3 == 0)
            {
                lista.Insert(0, i);
            }
            else if (i % 3 == 1)
            {
                lista.Add(i);
            }
            else if (i % 3 == 2)
            {
                lista.Insert(lista.Count / 2, i);
            }

            string contenutoLista = string.Join(", ", lista);
            Debug.Log("Contenuto lista: " + contenutoLista);
        }

    }

        // Update is called once per frame
    void Update()
    {
        
    }
}
