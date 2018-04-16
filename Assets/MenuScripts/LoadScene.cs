using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
        FallEnemy.fallSpeed = 5f;
        Boarders.currScore = 0;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadShop()
    {
        SceneManager.LoadScene(2);
    }
    public void FromShopToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
