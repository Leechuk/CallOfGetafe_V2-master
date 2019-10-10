﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovil : EnemigoBasico
{
    public float speed;
    public float tiempoRotacion;

    public void Start()
    {
        base.Start();
        
        InvokeRepeating("Rotar", tiempoRotacion, tiempoRotacion);
        
    }

    public void Update()
    {
        
        Mover();
        base.Update();
    }


    public void Mover()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    public void Rotar()
    {
        if (estado != ESTADO.Siguiendo)
        {
            transform.Rotate(0, Random.Range(-180, 180), 0);
        }
    }

  

}
