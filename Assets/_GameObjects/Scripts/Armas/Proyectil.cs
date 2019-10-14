using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    [SerializeField] int danyo;


    private void Start()
    {
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            collision.gameObject.GetComponent<EnemigoBasico>().RecibirDanyo(danyo);
            Destroy(gameObject);
        }
    }


}
