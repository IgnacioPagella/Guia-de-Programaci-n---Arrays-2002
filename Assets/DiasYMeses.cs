using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiasYMeses : MonoBehaviour
{
    [SerializeField] string[] nombresMeses = new string[12];
    [SerializeField] int[] nombresDias = new int[12];
    public int fechaIngresada;
        // Start is called before the first frame update
    void Start()
    {
        ValidarFormatoFecha(fechaIngresada);
    }
    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;
        if (fecha.Length == 4)
        {
            string dia = "";
            dia += fecha[0];
            dia += fecha[1];
            int.Parse(dia);
            Debug.Log(dia);
        }
        else
        {
            Debug.Log("El largo de la fecha es incorrecto")
        }

        return fechaValida;
    }
}
