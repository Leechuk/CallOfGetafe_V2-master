using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Rigidbody))]//indica que el scritp solo se puede alojar en objetos con rigidbody y si no lo tiene se lo crea
public class Arma : MonoBehaviour
{
    
    [Header("Tiempo entre disparos (segundos)")] // cabecera con texto en el inspector de unity
    [Range(0,10)] // barra de ajuste de la variable siguiente
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
    private int municionCargador;

    public void Disparar()
    {

    }
    public void Recargar()
    {

    }
    public void IncrementarCargador(int numeroCargadores)
    {
        this.numeroCargadores = this.numeroCargadores + numeroCargadores;
    }

}
