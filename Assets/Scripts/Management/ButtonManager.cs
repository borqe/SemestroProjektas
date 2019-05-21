﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public EscMenuManager escMenu;
    public LevelRestart levelRestart;

    public void doRestartCurrentLevel()
    {
        escMenu.Continue();
        levelRestart.doRestartCurrentLevel();
    }

    public void doExitGame()
    {
        Application.Quit();
    }

    public void doContinue()
    {
        MainMenuLoading.loading = true;
        SceneManager.LoadScene("HomeForest");
    }

    public void doStartNewGame()
    {
        SceneManager.LoadScene("HomeForest");
    }

    public void doGoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
