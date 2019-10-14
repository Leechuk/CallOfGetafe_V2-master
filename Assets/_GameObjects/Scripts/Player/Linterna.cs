using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    [SerializeField]
    GameObject linterna;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            linterna.SetActive(!linterna.activeSelf);
        }
    }
}
