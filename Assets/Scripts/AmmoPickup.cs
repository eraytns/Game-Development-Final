//Jimmy Vegas Unity Tutorials
//This script will start to pick up ammo


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    public GameObject theAmmo;
    public GameObject ammoDisplayBox;

    void OnTriggerEnter(Collider other)
    {
        ammoDisplayBox.SetActive(true);
        GlobalAmmo.ammoCount += 7;
        theAmmo.SetActive(false);
    }

}