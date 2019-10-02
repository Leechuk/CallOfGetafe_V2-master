using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoTonto : EnemigoMovil
{
    [SerializeField]
    AudioClip sonidoSoldado;
    AudioSource audioSource;
    
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void Update()
    {

    }

    public void Explota()
    {



    }
}
