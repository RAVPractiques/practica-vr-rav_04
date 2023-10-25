using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    public prueba prueba;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerEnter(Collider other)
        {
            if (!prueba.abierto)
            {
                StartCoroutine(prueba.AbrirPuerta());
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (prueba.abierto)
            {
                StartCoroutine(prueba.CerrarPuerta());
            }
        }
    }
}
