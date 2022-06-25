using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    public float maxHealth = 100f;
    PlayerMovement Player;


    private void Start()
    {
        healthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerMovement>();
    }

    private void Update()
    {
        currentHealth = Player.Health;
        healthBar.fillAmount = currentHealth / maxHealth;
    }

}
