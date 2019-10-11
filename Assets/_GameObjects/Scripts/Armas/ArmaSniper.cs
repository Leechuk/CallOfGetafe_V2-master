using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ArmaSniper : Arma
{
    [Header ("Zoom")]
    [SerializeField] Camera camara;
    [SerializeField] GameObject bala; //Prefab
    [SerializeField] Transform pOrigen;
    [SerializeField] int fuerza = 100; //Fuerza que se implementa
    [SerializeField] Image mirillaIMG;

    public void Start()
    {

        base.Start();
        if (mirillaIMG.isActiveAndEnabled == true)
        {
            mirillaIMG.gameObject.SetActive(false);
        }
        


    }


    private void Update()
    {
        //base.Update();

        if (Input.GetMouseButtonDown(1))
        {
            camara.fieldOfView = 20;
            Debug.Log("Zoom");
            mirillaIMG.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(1))
        {
            camara.fieldOfView = 60;
            Debug.Log("Zoom Off");
            mirillaIMG.gameObject.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Disparar();

            print("Dispara");
        }
    }


    public override void Disparar()
    {
        RaycastHit rch;
        bool hayImpacto = Physics.Raycast(
            pOrigen.position,
            pOrigen.forward,
            out rch);
        if (hayImpacto)
        {
            print(rch.collider.gameObject.name);

            if (rch.collider.gameObject.GetComponent<Rigidbody>() != null)
            {
                print("Distancia" + rch.distance);// para saber la distancia del impacto
                rch.collider.gameObject.GetComponent<Rigidbody>().
                    AddForce(pOrigen.forward.normalized * fuerza);
            }
        }
    }

}
