using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] public bool isABot;
    public HandsController playerHand;
    public AbilityController abilityController;
    protected RPSAbility selectedAbility;
    public RPSAbility SelectedAbility { get { return selectedAbility; } }
    protected bool bCanChooseAbility = true;
    public bool bChoosedAbility;

    private void Awake()
    {
        playerHand = GetComponentInChildren<HandsController>();
        bCanChooseAbility = true;
    }

    public virtual void SelectRock() { }
    public virtual void SelectPaper() { }
    public virtual void SelectScissors() { }

    public void CanSelectAbility(bool newCanSelect)
    {
        bCanChooseAbility = newCanSelect;
    }

    public void PickRandomAbility()
    {
        int randomAbility = Random.Range(0, 3);
        Debug.Log(randomAbility);

        switch (randomAbility)
        {
            case 0:
                SelectRock();
                break;
            case 1:
                SelectPaper();
                break;
            case 2:
                SelectScissors();
                break;
        }
    }

}
