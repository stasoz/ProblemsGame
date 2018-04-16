using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {
    public static bool isClick=false;
    public static bool isClickOnMenu = false;
    public void Restart()
    {
        SceneManager.LoadScene(1);
        Boarders.IsAlive = true;
        isClick = true;
        FallEnemy.fallSpeed = 5f;
        Boarders.currScore = 0;
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        isClickOnMenu = true;
        Boarders.IsAlive = true;
    }
}
