using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScripts : MonoBehaviour
{
    public static MenuScripts instance;

    public int coins = 0;
    public Text CoinText;

    private void wake()
    {
        instance = this;
    }
    public void GameScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void BackToHome()
    {
        SceneManager.LoadScene(0);
    }

    public void Garage()
    {
        SceneManager.LoadScene(2);
    }
}
