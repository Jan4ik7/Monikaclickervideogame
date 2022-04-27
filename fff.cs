using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fff : MonoBehaviour
{
    public GameObject obj;
    private Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();

    }
     void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
        if (Input.GetKeyUp (KeyCode.A))
        {
            Destroy(obj);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
