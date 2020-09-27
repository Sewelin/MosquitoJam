using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    [SerializeField] private Animator white;
    [SerializeField] private Animator black;

    [SerializeField] private AK.Wwise.Event startTalk1;
    [SerializeField] private AK.Wwise.Event stopTalk1;
    [SerializeField] private AK.Wwise.Event startTalk2;
    [SerializeField] private AK.Wwise.Event stopTalk2;
    public static AK.Wwise.Event StartTalk1;
    public static AK.Wwise.Event StopTalk1;
    public static AK.Wwise.Event StartTalk2;
    public static AK.Wwise.Event StopTalk2;

    [SerializeField] private float talkTime;
    [SerializeField] private float breakTime;
    
    private static readonly int Stop = Animator.StringToHash("Stop");
    private static readonly int StartTalking = Animator.StringToHash("StartTalking");
    private static readonly int StartRolling = Animator.StringToHash("StartRolling");
    private static readonly int StartYawning = Animator.StringToHash("StartYawning");
    private static readonly int StartDrinking = Animator.StringToHash("StartDrinking");

    private void Start()
    {
        StartTalk1 = startTalk1;
        StopTalk1 = stopTalk1;
        StartTalk2 = startTalk2;
        StopTalk2 = stopTalk2;
        
        StartCoroutine("Discussion");
    }

    private IEnumerator Discussion()
    {
        var c1 = black;
        var c2 = white;
        
        while (!GameManager.GameEnded)
        {
            yield return new WaitForSeconds(breakTime);

            if (GameManager.GameEnded)
                break;
            
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
