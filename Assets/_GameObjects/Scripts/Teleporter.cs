using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//Paquete de gestion de Escenas

public class Teleporter : MonoBehaviour
{
    [SerializeField] string nombreEscena;
    [SerializeField] float delay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            Invoke("CambiarEscena", delay);
        }
    }
    private void CambiarEscena()
    {
        //Cambio de Escena
        // SceneManager.LoadScene(1);

        SceneManager.LoadScene(nombreEscena);
    }
}
