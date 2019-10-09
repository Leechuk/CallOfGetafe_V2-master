using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pow : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            //Opcion 1
            /*GameObject[] enenigos = GameObject.FindGameObjectsWithTag("Enemigo");
            for(int i = 0; i < enenigos.Length; i++)
            {
                enenigos[i].GetComponent<EnemigoBasico>().RecibirDanyo(50);
            }*/

            //Opcion 2

            /*EnemigoBasico[] enemigos = GameObject.FindObjectOfType<EnemigoBasico>();
            for (int i = 0; i<enemigos.Length>; i++)
            {
                enemigos[i].RecibirDanyo(50);

            }*/

            //Opcion 3

            EnemigoBasico.efectoMagia = true;


            Destroy(gameObject);
        }
       
        
    }
}
