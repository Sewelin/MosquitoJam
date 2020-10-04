using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkScript : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        (animator.gameObject.name == "White" ? Characters.StartTalk1 : Characters.StartTalk2).Post(animator.gameObject);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
        
        (animator.gameObject.name == "White" ? Characters.StopTalk1 : Characters.StopTalk2).Post(animator.gameObject);
    }
}
