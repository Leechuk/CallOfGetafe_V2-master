using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Arma[] armas;
    [SerializeField] int armaActiva = 0;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ActivarArma(0); 
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ActivarArma(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ActivarArma(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ActivarArma(3);
        }
        else
        {
            Debug.Log("Error Tecla Incorrecta");
        }

    }

    void ActivarArma(int numeroArma)
    {
        if (numeroArma != armaActiva)
        {
            /*if(numeroArma == armaActiva) // Mala opcion
           {
               return;
           }*/

            //OPCION 1

            armas[armaActiva].gameObject.SetActive(false);
            armaActiva = numeroArma;
            armas[armaActiva].gameObject.SetActive(true);

            //OPCION 2

            /*armaActiva = numeroArma;
            for (int i = 0; i < armas.Length; i++)
            {
                armas[i].gameObject.SetActive(false);
            }
            armas[armaActiva].gameObject.SetActive(true);*/
        }


    }

    void ApretarGatillo()
    {
        armas[armaActiva].Disparar();
    }

    public void Recargar(int numeroBalas)
    {
        //arma.Recargar(numeroBalas);
    }


}
