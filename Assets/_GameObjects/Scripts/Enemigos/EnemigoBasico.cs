using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemigoBasico : MonoBehaviour
{
    //Estado del Enemigo
    protected enum ESTADO { Normal, Siguiendo};
    protected ESTADO estado = ESTADO.Normal;
    //Connfiguracion
    public int vida;
    public int danyo;//Que recibe el enemigo del player
    public GameObject prefabExplosion;
    public TextMesh textoVida;
    protected GameObject player;
    

    public static bool efectoMagia = false;

    public void Start()
    {
              
        player = GameObject.Find("Player");
        textoVida.text = vida.ToString();
        
    }

    public void Update()
    {
        if (efectoMagia)
        {
            RecibirDanyo(50);
           // var renderer = GetComponent<Renderer>(); //Cambiar color del material.
           //renderer.material.SetColor("_Color", Color.red);
           
        }
    }

    public void LateUpdate()
    {
        efectoMagia = false;
    }

    public void RecibirDanyo(int danyoRecibido)
    {
        vida = vida - danyoRecibido;
        textoVida.text = vida.ToString();
        if (vida <= 0)
        {
            Morir();
            print("Muere");
        }
    }


    public void Atacar()
    {

    }

    public void Morir()
    {
        Instantiate(prefabExplosion, transform.position, transform.rotation);
        Destroy(gameObject);


    }
}
