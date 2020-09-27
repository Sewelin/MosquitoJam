using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    [SerializeField] private Animator white;
    [SerializeField] private Animator black;

    [SerializeField] private float talkTime;
    [SerializeField] private float breakTime;
    
    private static readonly int Stop = Animator.StringToHash("Stop");
    private static readonly int StartTalking = Animator.StringToHash("StartTalking");
    private static readonly int StartRolling = Animator.StringToHash("StartRolling");
    private static readonly int StartYawning = Animator.StringToHash("StartYawning");
    private static readonly int StartDrinking = Animator.StringToHash("StartDrinking");

    private void Start()
    {
        StartCoroutine("Discussion");
    }

    private IEnumerator Discussion()
    {
        var c1 = black;
        var c2 = white;
        
        while (!GameManager.GameEnded)
        {Debug.Log(c1.name + " " + c2.name);
            yield return new WaitForSeconds(breakTime);
            c1.SetTrigger(StartTalking);
            var ratio = (gameManager.DrinkGauge + gameManager.TalkGauge) / 200f;
            c2.SetTrigger(ratio < 0.25 ? StartRolling : ratio < 0.5 ? StartYawning : StartDrinking);
            yield return new WaitForSeconds(talkTime);
            c1.SetTrigger(Stop);
            c2.SetTrigger(Stop);

            var cTemp = c2;
            c2 = c1;
            c1 = cTemp;
        }
    }
}
