using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajadeMunicion : MonoBehaviour
{
    [SerializeField] int numeroBalas;


    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {

            //recargar arma
            other.gameObject.GetComponent<Player>().Recargar(numeroBalas);
            //desaparece el cubo
            Destroy(gameObject);
        }



    }
}
