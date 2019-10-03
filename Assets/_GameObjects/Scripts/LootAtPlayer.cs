using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootAtPlayer : MonoBehaviour
{
    private Transform transformPlayer;
    // Start is called before the first frame update
    void Start()
    {
        transformPlayer = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transformPlayer);
        transform.Rotate(0, 180, 0);
    }
}
