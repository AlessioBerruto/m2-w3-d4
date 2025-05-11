using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public string frase = "";

    // Start is called before the first frame update
    void Start()
    {        
        int posizioneAperta = frase.IndexOf("(");
        int posizioneChiusa = frase.IndexOf(")");

        if (posizioneAperta != 0 || posizioneChiusa < 0 || posizioneChiusa <= posizioneAperta +1 )
        {
            Debug.Log("C'è un errore nella frase scritta, deve contenere le parentesi ( e )");
            return;
        }

        string fraseTraParentesi = frase.Substring(posizioneAperta + 1, posizioneChiusa - posizioneAperta - 1);
        string[] arrayDiFrase = fraseTraParentesi.Split(";");
        string restoFrase = frase.Substring(posizioneChiusa + 1);               

        for (int i = 0; i < arrayDiFrase.Length; i++)
        {
            Debug.Log(arrayDiFrase[i]);
        }

        Debug.Log(restoFrase);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
