using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endAnimation : StateMachineBehaviour
{
    public Sprite replacementSprite;
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)        
    {
        GameObject.Find("Player").GetComponent<SpriteRenderer>().sprite = replacementSprite;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}
}
