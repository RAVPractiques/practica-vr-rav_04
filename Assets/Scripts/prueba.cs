using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public Transform puntoDeRotacion;
    private bool abierto = false;

    private void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (!abierto)
        {
            StartCoroutine(AbrirPuerta());
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (abierto)
        {
            StartCoroutine(CerrarPuerta());
        }
    }

    private IEnumerator AbrirPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;

        while (transform.rotation.eulerAngles.y < 90)
        {
            transform.RotateAround(puntoRotacion, Vector3.up, 20* Time.deltaTime);
            yield return new WaitForSeconds(4); 
        }

        abierto = true;
    }

    private IEnumerator CerrarPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;

        while (transform.rotation.eulerAngles.y > 0)
        {
            transform.RotateAround(puntoRotacion, Vector3.up, -20* Time.deltaTime);
            yield return new WaitForSeconds(4);
        }

        abierto = false;
    }

}


