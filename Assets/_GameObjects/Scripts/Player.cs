using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Arma arma;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ApretarGatillo();
        }
    }

    void ApretarGatillo()
    {
        arma.Disparar();
    }

    public void Recargar(int numeroBalas)
    {
        arma.Recargar(numeroBalas);
    }
}
