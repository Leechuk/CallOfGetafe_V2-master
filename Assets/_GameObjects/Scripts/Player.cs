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
    }

    void ActivarArma(int numeroArma)
    {

    }

    void ApretarGatillo()
    {
        //arma.Disparar();
    }

    public void Recargar(int numeroBalas)
    {
        //arma.Recargar(numeroBalas);
    }


}
