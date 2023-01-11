using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartOnePlayerGame()
    {
        GameOptionsSettings.Instance.EnableBot();

        SceneManager.LoadScene(1);
    }

    public void StartTwoPlayerGame() 
    {
        GameOptionsSettings.Instance.DisableBot();

        SceneManager.LoadScene(1);
    }

    public void Quit() 
    {
        Application.Quit();
    }
}
