using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieDeath : MonoBehaviour
{

    public int EnemyHealth = 20;
    public Slider HealthBar;
    public GameObject TheEnemy;
    public int StatusCheck;
    public Animator animator;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }

    void Update()
    {
        HealthBar.value = EnemyHealth;
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            animator.SetTrigger("Death");
            StatusCheck = 2;
            Debug.Log("died");

        }
        
    }
}