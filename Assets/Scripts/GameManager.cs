using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool GameEnded { get; private set; } = false;

    [SerializeField] private Slider mainGauge;
    [SerializeField] private float drinkGauge = 50f;
    [SerializeField] private float talkGauge = 50f;

    [SerializeField] private float drinkGain = 0.1f;
    [SerializeField] private float talkGain = 1f;
    [SerializeField] private float drinkLoss = 0.5f;
    [SerializeField] private float talkLoss = 0.8f;
    
    private float DrinkGauge
    {
        get => drinkGauge;
        set
        {
            drinkGauge = value;
            if (drinkGauge > 100f)
                drinkGauge = 100f;
            else if (drinkGauge < 0f)
                drinkGauge = 0f;
            mainGauge.value = drinkGauge + TalkGauge;
        }
    }

    private float TalkGauge
    {
        get => talkGauge;
        set
        {
            talkGauge = value;
            if (talkGauge > 100f)
                talkGauge = 100f;
            else if (talkGauge < 0f)
                talkGauge = 0f;
            mainGauge.value = DrinkGauge + talkGauge;
        }
    }

    public void Drink()
    {
        DrinkGauge += drinkGain;
    }
    
    public void Talk()
    {
        TalkGauge += talkGain;
    }

    private void Start()
    {
        mainGauge.value = DrinkGauge + TalkGauge;
    }

    private void Update()
    {
        DrinkGauge -= drinkLoss * Time.deltaTime;
        TalkGauge -= talkLoss * Time.deltaTime;
    }
}
