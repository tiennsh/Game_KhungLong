using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class GameGUIManager : Singleton<GameGUIManager>
{
    public GameObject homeGui;
    public GameObject gameGui;
    public GameObject gameOverGui;

    public Text scoreText;

    public override void Awake()
    {
        MakeSingleton(false);
    }

    public void ShowGameGui(bool isShow)
    {
        if (gameGui)
            gameGui.SetActive(isShow);
        if (homeGui)
        {
            homeGui.SetActive(!isShow);
        }
    }

    public void ShowGameOverGui(bool isShow)
    {
        gameOverGui.SetActive(isShow);
    }

    public void UpdateScoreText(string score)
    {
        scoreText.text = score;
    }

    public void Replay()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {

        Application.Quit();
    }
}
