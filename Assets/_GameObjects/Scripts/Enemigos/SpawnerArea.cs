using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerArea : MonoBehaviour
{
    [SerializeField]
    GameObject prefab; //Objeto que respawneamos
    [SerializeField]
    float delay; // tiempo que tardan en respawnear los enemigos
    [SerializeField]
    int limit; // Cantidad de objetos que Respawneamos
    private int NumerosdeInstancias;
    [SerializeField] Transform limiteSuperior;
    [SerializeField] Transform limiteInferior;

    void Start()
    {
        InvokeRepeating("Spawnear", 0, delay);
    }

    void Spawnear()
    {
        float x = Random.Range(limiteInferior.position.x, limiteSuperior.position.x);
        float y = transform.position.y;
        float z = Random.Range(limiteInferior.position.z, limiteSuperior.position.z);

        // Instanciar el enemigo en la ubicacion del Spawner como hijo, pero si este se mueve se mueve detras los objetos.
        //Instantiate(_prefab, transform);

        // Instanciar el enemigo sin depender del Spawner
        Instantiate(prefab, new Vector3(x, y, z), transform.rotation);
        NumerosdeInstancias++; //Es lo mismo que numeroinstancias=numeroinstancias+1;

        if (NumerosdeInstancias == limit) //Si llegamos al limite de enemigos se destruye el spawner
        {
            CancelInvoke();
            //Destroy(this.gameObject); // se destruye este gameobject o Destroy(this); desactivamos el script
        }

    }
}
