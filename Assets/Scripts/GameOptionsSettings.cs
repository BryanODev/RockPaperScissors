using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOptionsSettings : MonoBehaviour
{
    public static GameOptionsSettings Instance { get; private set; }

    public bool UseBots;
    public bool isPaused;

    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void EnableBot() 
    {
        UseBots = true;
    }

    public void DisableBot() 
    {
        UseBots = false;
    }

}
