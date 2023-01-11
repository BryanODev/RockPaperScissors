using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsController : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void StartHandShuffle()
    {
        animator.SetTrigger("RockPaperScissors!");
    }

    public void SetHandGesture(RPSAbility selectedAbility)
    {
        //set the animator ability index to show which option we choose
        switch (selectedAbility)
        {
            case RPSAbility.Rock:
                animator.SetInteger("AbilityIndex", 0);
                break;

            case RPSAbility.Paper:
                animator.SetInteger("AbilityIndex", 1);
                break;

            case RPSAbility.Scissor:
                animator.SetInteger("AbilityIndex", 2);
                break;
        }
    }
}
