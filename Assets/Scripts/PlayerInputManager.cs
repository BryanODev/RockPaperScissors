using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    PlayerInputs playerInputs;
    GameMode gameModeReference;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
        playerInputs.Enable();
    }

    private void Start()
    {
        SetUpInputs();
    }

    private void OnEnable()
    {
        playerInputs.Enable();
    }


    void SetUpInputs()
    {
        playerInputs.PlayerOne.Rock.performed += ctx => GameMode.Instance.PlayerOne.SelectRock();
        playerInputs.PlayerOne.Paper.performed += ctx => GameMode.Instance.PlayerOne.SelectPaper();
        playerInputs.PlayerOne.Scissors.performed += ctx => GameMode.Instance.PlayerOne.SelectScissors();
        playerInputs.PlayerOne.Pause.performed += ctx => PauseMenu.Instance.OpenPauseMenu();

        playerInputs.PlayerTwo.Rock.performed += ctx => GameMode.Instance.PlayerTwo.SelectRock();
        playerInputs.PlayerTwo.Paper.performed += ctx => GameMode.Instance.PlayerTwo.SelectPaper();
        playerInputs.PlayerTwo.Scissors.performed += ctx => GameMode.Instance.PlayerTwo.SelectScissors();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }
}
