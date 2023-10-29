using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comprobar_llave : MonoBehaviour
{
    public abrir_cerrar abrir_cerrar;

    void OnCollisionEnter(Collision collision)
    {
        if (!abrir_cerrar.abierto && collision.gameObject.CompareTag("llave"))
        {
            StartCoroutine(abrir_cerrar.AbrirPuerta());
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (abrir_cerrar.abierto)
        {
            StartCoroutine(abrir_cerrar.CerrarPuerta());
        }
    }

}
