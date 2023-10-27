using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour
{
    public Transform puntoDeRotacion;
    public bool abierto = false;

    public IEnumerator AbrirPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;

        while (transform.rotation.eulerAngles.y < 90)
        {
            transform.RotateAround(puntoRotacion, Vector3.up, 20* Time.deltaTime);
            yield return null;
        }
        Debug.Log("abierto a true");
        abierto = true;
    }

    public IEnumerator CerrarPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;

        while (transform.rotation.eulerAngles.y >= 0.0f)
        {
            Debug.Log(transform.rotation.eulerAngles.y);
            transform.RotateAround(puntoRotacion, Vector3.up, -20* Time.deltaTime);
            yield return null;
        }
        Debug.Log("abierto a false");
        abierto = false;


    }

}


