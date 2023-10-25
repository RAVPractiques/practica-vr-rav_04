using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porta : MonoBehaviour
{
    public Transform puntoderotacion;
    private bool abierto = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void abrir()
    {
        Vector3 ejerotacion = puntoderotacion.up; // Eje en el que rota
        Vector3 puntorotacion = puntoderotacion.position; // Posici�n del objeto hijo para rotar
        transform.RotateAround(puntorotacion, ejerotacion, 20 * Time.deltaTime);
        StartCoroutine(movewithDelay());
    }

    public void close()
    {
        Vector3 ejerotacion = puntoderotacion.up; // Eje en el que rota
        Vector3 puntorotacion = puntoderotacion.position; // Posici�n del objeto hijo para rotar
        transform.RotateAround(puntorotacion, ejerotacion, -20 * Time.deltaTime);
    }

    IEnumerator movewithDelay() //rutina
    {
        yield return new WaitForSeconds(8);
        close();
    }

    // Update is called once per frame
    void Update()
    {
        float eulerAng = transform.rotation.eulerAngles.y;
        if (!abierto && eulerAng < 90)
        {
            abrir();
        }

        

    }
}
