using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arma : MonoBehaviour
{
    [SerializeField] GameObject bala;
    [SerializeField] Transform puntoInicioProyectil;
    [SerializeField] float fuerza;
    [SerializeField] int capacidadCargador;
    [SerializeField] Text txtBalas;
    [SerializeField] int numeroBalas;

    public void Start()
    {
        numeroBalas = capacidadCargador;
        txtBalas.text = numeroBalas.ToString();/////////////UI //añadir texto: "Balas: " + numeroBalas por ejemplo
    }

    
    public void Recargar(int numeroBalasExtra)
    {
        numeroBalas = Mathf.Min(numeroBalas + numeroBalasExtra, capacidadCargador);
        txtBalas.text = numeroBalas.ToString();/////////////UI
    }

    public void Disparar()
    {

        if (numeroBalas > 0)
        {

            //Generamos proyectil
            GameObject proyectil = Instantiate(bala);
            // Asigno al proyectil la posicion y rotacion del punto de spanw
            proyectil.transform.position = puntoInicioProyectil.position;
            proyectil.transform.rotation = puntoInicioProyectil.rotation;
            // impulsamos proyectil
            proyectil.GetComponent<Rigidbody>().AddForce(proyectil.transform.forward * fuerza);

            numeroBalas--;

            txtBalas.text = numeroBalas.ToString();/////////////UI

        }
        else
        {
            Debug.Log("No tienes Balas");
        }
    }
}
