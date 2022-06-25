using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool GameIsOver = false;
    public GameObject gameOverUI;

    void Update()
    {
        if (GameObject.Find("Player").GetComponent<PlayerMovement>().Health <= 0)
        {
            gameOver();
        }
    }

    void gameOver()
    {
        Time.timeScale = 0;
        GameIsOver = true;
        gameOverUI.SetActive(true);
        Cursor.visible = true;
    }

    public void Restart()
    {
        GlobalAmmo.ammoCount = 0;
        SceneManager.LoadScene(1);
        Cursor.visible = false;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
