using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour
{
    

    [SerializeField] Transform target;
    void Update()
    {
        /*Vector3 vt = new Vector3(0, Time.deltaTime, 0);
        transform.Translate(vt);*/

        //transform.Translate(Vector3.down * Time.deltaTime);


        //Vector3.MoveTowards(transform.position, target.position,  Time.deltaTime);
        //transform.LookAt(target);


    }



}
