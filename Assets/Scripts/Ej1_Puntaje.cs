using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1_Puntaje : MonoBehaviour
{

    [SerializeField] int[] puntajes = new int [10];

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El mayor puntaje es" + ObtenerMayorPuntaje()); 
        Debug.Log(("El menor puntaje es" + ObtenerNivelDeMenorPuntaje()));
        Debug.Log(("El puntaje promedio es" + ObtenerPuntajePromedio()));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    int ObtenerMayorPuntaje()
    {
        int mayorPuntaje = 0;
        //int retorno = 0;

        foreach (int puntaje in puntajes)
        {
            if(puntaje > mayorPuntaje)
            {
                mayorPuntaje = puntaje;
            }
        }

        return mayorPuntaje;
    }
    int ObtenerNivelDeMenorPuntaje()
    {
        int indiceNivelMenorPuntaje = 0;
        int menorPuntaje = puntajes[0];
        for(int i = 0; i < puntajes.Length; i++)
        {
            if (puntajes[i] < menorPuntaje)
            {
                  menorPuntaje= puntajes[i];
                indiceNivelMenorPuntaje = i;
            }
        }

        return indiceNivelMenorPuntaje;
    }
    float ObtenerPuntajePromedio()
    {
        float Promedio = 0;

        float suma = 0;
        foreach (int num in puntajes)
        {
            suma += num;
        }
        Promedio = suma / puntajes.Length * 1.0f;

        return Promedio;
    }
}
