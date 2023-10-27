using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobar_estado_puerta : MonoBehaviour
{
    public abrir_cerrar abrir_cerrar;

    void OnTriggerEnter(Collider other)
    {
        if (!abrir_cerrar.abierto)
        {
            StartCoroutine(abrir_cerrar.AbrirPuerta());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (abrir_cerrar.abierto)
        {
            StartCoroutine(abrir_cerrar.CerrarPuerta());
        }
    }
}
