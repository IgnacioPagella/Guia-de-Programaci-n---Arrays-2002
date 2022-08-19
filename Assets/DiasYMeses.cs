using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiasYMeses : MonoBehaviour
{
    [SerializeField] string[] nombresMeses = new string[12];
    [SerializeField] int[] nombresDias = new int[12];
        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    bool ValidarFormatoFecha(string fecha)
    {
        bool fechaValida = false;
        if (fecha.Length == 4)
        {
            string dia = "";
            dia += fecha[0];
        }

        return fechaValida;
    }
}
