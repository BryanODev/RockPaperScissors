using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu Instance { get; private set; }
    public GameObject PauseMenuHolder;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void TogglePauseMenu() 
    {
        if (GameOptionsSettings.Instance)
        {
            //Check if game is paused
            if (GameOptionsSettings.Instance.isPaused)
            {
                //We unpause
                ClosePauseMenu();
            }
            else 
            {
                //We pause
                OpenPauseMenu();
            }
        }
    }

    public void OpenPauseMenu() 
    {
        if (GameOptionsSettings.Instance) 
        {
            GameOptionsSettings.Instance.isPaused = true;
        }

        //Stop time
        Time.timeScale = 0;

        PauseMenuHolder.SetActive(true);
    }

    public void ClosePauseMenu()
    {
        if (GameOptionsSettings.Instance)
        {
            GameOptionsSettings.Instance.isPaused = false;
        }

        //Resume time
        Time.timeScale = 1;

        PauseMenuHolder.SetActive(false);
    }

    public void ContinueGame() 
    {
        ClosePauseMenu();
    }

    public void BackToMenu() 
    {
        ClosePauseMenu();
        SceneManager.LoadScene(0);
    }
}
