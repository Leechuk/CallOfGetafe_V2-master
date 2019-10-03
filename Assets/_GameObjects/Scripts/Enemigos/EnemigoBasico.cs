using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoBasico : MonoBehaviour
{
    public int vida;
    public int danyo;//Que inflinje el enemigo al player
    public GameObject prefabExplosion;

    public void RecibirDanyo(int danyoRecibido)
    {
        vida = vida - danyoRecibido;
        if (vida < 0)
        {
            Morir();
        }
    }


    public void Atacar()
    {

    }

    public void Morir()
    {

    }
}
