using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject Audiosource;
    public GameObject Audiosource2;
    public GameObject Audiosource3;
    public GameObject Audiosource4;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("ANDA EL ESPACIO");
        }    
    }
}
