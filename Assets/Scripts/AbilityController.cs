using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour
{
    public Image RockAbilityUI;
    public Image PaperAbilityUI;
    public Image ScissorsAbilityUI;

    public Color SelectedAbilityTint;
    public Color UnselectedAbilityTint;

    public void ToggleHolder(bool newToggle) 
    {
        gameObject.SetActive(newToggle);
    }

    public void OnSelectAbility() 
    {
        RockAbilityUI.color = UnselectedAbilityTint;
        PaperAbilityUI.color = UnselectedAbilityTint;
        ScissorsAbilityUI.color = UnselectedAbilityTint;
    }

    public void ResetSelection()
    {
        RockAbilityUI.color = SelectedAbilityTint;
        PaperAbilityUI.color = SelectedAbilityTint;
        ScissorsAbilityUI.color = SelectedAbilityTint;
    }
}
