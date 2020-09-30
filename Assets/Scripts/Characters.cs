using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

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

    [SerializeField] private GameObject dialogue1;
    [SerializeField] private GameObject dialogue2;
    [SerializeField] private Text dialogueText1;
    [SerializeField] private Text dialogueText2;

    private List<string> _redDialogues;
    private List<string> _yellowDialogues;
    private List<string> _greenDialogues;
    
    private static readonly int Stop = Animator.StringToHash("Stop");
    private static readonly int StartTalking = Animator.StringToHash("StartTalking");
    private static readonly int StartRolling = Animator.StringToHash("StartRolling");
    private static readonly int StartYawning = Animator.StringToHash("StartYawning");
    private static readonly int StartDrinking = Animator.StringToHash("StartDrinking");

    private void Awake()
    {
        _redDialogues = new List<string>
        {
            "Bloody hell, what is wrong with you? ",
            "Listen, I'm not so pumped up tonight",
            "I think this whole date might be in vein",
            "Sorry but I am more of a AB-type person",
            "Maybe we should start again from scratch?",
            "This place/this date sucks"
        };

        _yellowDialogues = new List<string>
        {
            "As a software developer I do get rid of bugs",
            "I only bite vegetarians",
            "Have you found still waters to stay nearby?",
            "Ever been to the mosque-ito?",
            "Do you often go skin-diving? ",
            "I mostly listen to Sting",
            "Are you into astronomy? Because tonight's the blood moon"
        };

        _greenDialogues = new List<string>
        {
            "You're bloody gorgeous, you know that?",
            "One would say this date is a total success",
            "I'm actually itching for another drink",
            "A human tried to clap me once",
            "I got a déjà vu, aren't we blood related?"
        };
    }

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
            c2.SetTrigger(ratio < 0.25 ? StartRolling : ratio < 0.75 ? StartYawning : StartDrinking);
            (c1 == white ? dialogue1 : dialogue2).SetActive(true);
            var dialogues = (ratio < 0.25 ? _redDialogues : ratio < 0.75 ? _yellowDialogues : _greenDialogues);
            (c1 == white ? dialogueText1 : dialogueText2).text = dialogues[Random.Range(0, dialogues.Count)];
            yield return new WaitForSeconds(talkTime);
            
            c1.SetTrigger(Stop);
            c2.SetTrigger(Stop);
            (c1 == white ? dialogue1 : dialogue2).SetActive(false);

            var cTemp = c2;
            c2 = c1;
            c1 = cTemp;
        }
    }
}
