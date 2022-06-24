using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//public class PlayerManager : MonoBehaviour
{
    public static int playerHP = 100;
    public TextMeshProUGUI playerHPText;
    public static bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerHPText.text = "" + playerHP;
        if (isGameOver)
        {

        }
    }
    public static void PlayerDamage(int damageDone)
    {
        playerHP -= damageDone;
        if(playerHP < 0)
        {
            isGameOver = true;
        }
    }
}
