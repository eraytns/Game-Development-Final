using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSwitch : MonoBehaviour
{
    public GameObject flashLight;
    public bool isActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(isActive == false)
            {
                isActive = true;
                flashLight.GetComponent<MeshRenderer>().enabled = true;
            }
            else
            {
                isActive = false;
                flashLight.GetComponent<MeshRenderer>().enabled = false;
            }
        }
    }
}
