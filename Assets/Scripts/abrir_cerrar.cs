using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrir_cerrar : MonoBehaviour
{
    public Transform puntoDeRotacion;
    public bool abierto = false;

    public IEnumerator AbrirPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;

        while (transform.rotation.eulerAngles.y < 90)
        {
            transform.RotateAround(puntoRotacion, Vector3.up, 20 * Time.deltaTime);
            yield return null;
        }
        abierto = true;
        
    }

    public IEnumerator CerrarPuerta()
    {
        Vector3 puntoRotacion = puntoDeRotacion.position;
        yield return new WaitForSeconds(2);
        while (transform.rotation.eulerAngles.y >= 0.3f)
        {
            Debug.Log(transform.rotation.eulerAngles.y);
            transform.RotateAround(puntoRotacion, Vector3.up, -20 * Time.deltaTime);
            yield return null;
        }
        abierto = false;


    }
}
