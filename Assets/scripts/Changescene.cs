using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Changescene : MonoBehaviour
{
    public void StartScene()
    {
        SceneManager.LoadScene("Start");
    }


    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
