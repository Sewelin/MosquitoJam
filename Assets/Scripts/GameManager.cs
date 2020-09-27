using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool GameEnded { get; private set; } = false;

    [SerializeField] private Slider mainGauge;
    private float _drinkGauge = 50f;
    private float _talkGauge = 50f;

    [SerializeField] private float drinkGain = 0.1f;
    [SerializeField] private float talkGain = 1f;
    [SerializeField] private float drinkLoss = 0.5f;
    [SerializeField] private float talkLoss = 0.8f;
    
    private float DrinkGauge
    {
        get => _drinkGauge;
        set
        {
            _drinkGauge = value;
            if (_drinkGauge > 100f)
                _drinkGauge = 100f;
            else if (_drinkGauge < 0f)
                _drinkGauge = 0f;
            mainGauge.value = _drinkGauge + TalkGauge;
        }
    }

    private float TalkGauge
    {
        get => _talkGauge;
        set
        {
            _talkGauge = value;
            if (_talkGauge > 100f)
                _talkGauge = 100f;
            else if (_talkGauge < 0f)
                _talkGauge = 0f;
            mainGauge.value = DrinkGauge + _talkGauge;
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

    private void Update()
    {
        DrinkGauge -= drinkLoss * Time.deltaTime;
        TalkGauge -= talkLoss * Time.deltaTime;
    }
}
