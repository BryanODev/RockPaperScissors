using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum RPSAbility 
{
    Rock,
    Paper,
    Scissor
}

public class PlayerController : Controller
{

    private void Awake()
    {
        playerHand = GetComponentInChildren<HandsController>();
    }

    public override void SelectRock() 
    {
        if (!bCanChooseAbility)
        {
            return;
        }

        if (GameOptionsSettings.Instance && !isABot) 
        {
            if (GameOptionsSettings.Instance.isPaused) 
            {
                return;
            }
        }

        selectedAbility = RPSAbility.Rock;
        playerHand.SetHandGesture(selectedAbility);
        abilityController.OnSelectAbility();
        bChoosedAbility = true;

        Debug.Log("Rock Selected");

        CanSelectAbility(false);
        GameMode.Instance.OnPlayerAbilityChose();
    }

    public override void SelectPaper() 
    {
        if (!bCanChooseAbility) 
        {
            return;
        }

        if (GameOptionsSettings.Instance && !isABot)
        {
            if (GameOptionsSettings.Instance.isPaused)
            {
                return;
            }
        }

        selectedAbility = RPSAbility.Paper;
        playerHand.SetHandGesture(selectedAbility);
        abilityController.OnSelectAbility();
        bChoosedAbility = true;

        Debug.Log("Paper Selected");

        CanSelectAbility(false);
        GameMode.Instance.OnPlayerAbilityChose();
    }

    public override void SelectScissors() 
    {
        if (!bCanChooseAbility)
        {
            return;
        }

        if (GameOptionsSettings.Instance && !isABot)
        {
            if (GameOptionsSettings.Instance.isPaused)
            {
                return;
            }
        }

        selectedAbility = RPSAbility.Scissor;
        playerHand.SetHandGesture(selectedAbility);
        abilityController.OnSelectAbility();
        bChoosedAbility = true;

        Debug.Log("Scissor Selected");

        CanSelectAbility(false);
        GameMode.Instance.OnPlayerAbilityChose();
    }

}
