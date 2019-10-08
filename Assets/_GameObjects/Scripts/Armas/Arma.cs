using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]//indica que el scritp solo se puede alojar en objetos con rigidbody y si no lo tiene se lo crea
public abstract class Arma : MonoBehaviour
{

    [Header("Tiempo entre disparos (segundos)")] // cabecera con texto en el inspector de unity
    [Range(0, 10)] // barra de ajuste de la variable siguiente
    [SerializeField] float cadencia; //Tiempo entre disparos (segundos)

    [Header("Capacidad de proyectiles del Cargador")] // cabecera con texto en el inspector de unity
    [SerializeField] int capacidadCargador;

    [Header("Tiempo de Recarga")] // cabecera con texto en el inspector de unity
    [Range(0, 4)] // barra de ajuste de la variable siguiente
    [SerializeField] float tiempoRecarga;

    [Header("Numero de Cargadores en mochila")] // cabecera con texto en el inspector de unity
    [Space(30)]
    [SerializeField] int numeroCargadores;
    //Municion disponible en el cargador
    [SerializeField] int municionCargador;

    [Header("Variables de Estado")] // cabecera con texto en el inspector de unity
    [SerializeField] bool recargando = false;
    [SerializeField] bool esperandoCandencia = false;//Esperando tiempo de cadencia

    [Header("Sonidos")]
    [SerializeField] AudioClip acShoot;
    [SerializeField] AudioClip acReload;
    [SerializeField] AudioClip acFail;
    private AudioSource audioSource;




    public void Start()
    {
        municionCargador = capacidadCargador;
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(acReload);
    }


    public void IntentarDisparar()
    {
        bool puedeDisparar = municionCargador > 0 && recargando == false && esperandoCandencia == false;
        if (puedeDisparar)
        {
            Disparar();
            audioSource.PlayOneShot(acShoot);
            DisparoRealizado();
        }
    }

public abstract void Disparar();

    public void Recargar()
    {
        if (numeroCargadores > 0 && recargando == false)
        {
            municionCargador = capacidadCargador;
            numeroCargadores--;
            recargando = true;
            Invoke("ReiniciarCargando", tiempoRecarga);
            Debug.Log("Recargado");
            audioSource.PlayOneShot(acReload);


        }
        
    }
    public void IncrementarCargador(int numeroCargadores)
    {
        this.numeroCargadores = this.numeroCargadores + numeroCargadores;
    }
    
    protected void DisparoRealizado()
    {
        
        municionCargador--;
        //Actualizar UI
        esperandoCandencia = true;
        Invoke("ReiniciarCadencia", cadencia);
    }

    private void ReiniciarCadencia()
    {
        esperandoCandencia = false;
    }

    private void ReiniciarCargando()
    {
        recargando = false;
    }

}
