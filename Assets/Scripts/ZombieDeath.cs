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
        //HealthBar.value = EnemyHealth;
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            AudioManager.instance.Play("Zombie_Death");
            AudioManager.instance.Stop("ZombieAttack");
            animator.SetTrigger("Death");
            StatusCheck = 2;
            Destroy(gameObject, 1.5f);
        }
    }
}