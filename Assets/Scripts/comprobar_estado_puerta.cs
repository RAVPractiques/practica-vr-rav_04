using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobar_estado_puerta : MonoBehaviour
{
    public abrir_cerrar abrir_cerrar;

    void OnCollissionEnter(Collider other)
    {
        if (!abrir_cerrar.abierto)
        {
            StartCoroutine(abrir_cerrar.AbrirPuerta());
        }
    }

    void OnCollisionExit(Collider other)
    {
        if (abrir_cerrar.abierto)
        {
            StartCoroutine(abrir_cerrar.CerrarPuerta());
        }
    }
}
