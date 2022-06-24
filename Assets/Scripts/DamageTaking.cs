using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTaking : MonoBehaviour
{
    public PlayerMovement playerMovement;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            playerMovement.Health -= 0.5f;
        }
    }
}
