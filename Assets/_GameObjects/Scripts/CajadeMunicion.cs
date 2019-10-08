﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajadeMunicion : MonoBehaviour
{
    [SerializeField] int numeroBalas;


    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Arma")
        {

            //recargar arma
            other.gameObject.GetComponent<Arma>().Recargar();
            //desaparece el cubo
            Destroy(gameObject);
        }



    }
}
