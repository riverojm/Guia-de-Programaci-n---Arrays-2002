using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    [SerializeField] int[] Puntaje = new int[10];
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es"+MayorPuntaje());
        Debug.Log("El indice del menor puntaje es" + MenorPuntaje());
        Debug.Log("EL promedio del array es "+promedioarray());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    int MayorPuntaje()
    {
        int MayorNumero = 0;

        foreach(int num in Puntaje)
        {
            if(num > MayorNumero)
            {
                MayorNumero = num;
            }
        }

        return MayorNumero;
    }

    int MenorPuntaje()
    {
        int Indice = 0;
        int MenorNumero = Puntaje[0];

        for (int i = 0; i < Puntaje.Length; i++)
        {
            if (Puntaje[1] < MenorNumero)
            {
                Indice = i;
                MenorNumero = Puntaje[i];
            }
        }

        return MenorNumero;
    }

    float promedioarray()
    {
        float promedio = 0;

        foreach (int num in Puntaje)
        {
            promedio += num;
        }
        return promedio / Puntaje.Length;
    }
}
