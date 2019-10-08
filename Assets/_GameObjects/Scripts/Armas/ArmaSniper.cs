using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaSniper : Arma
{
    [Header ("Zoom")]
    [SerializeField] Camera camara;
  

    private void Update()
    {
        //base.Update();

        if (Input.GetMouseButtonDown(1))
        {
            camara.fieldOfView = 20;
            Debug.Log("Zoom");
        }
        else if (Input.GetMouseButtonUp(1))
        {
            camara.fieldOfView = 60;
            Debug.Log("Zoom Off");
        }
    }


    public override void Disparar()
    {
        //throw new System.NotImplementedException();
    }

}
