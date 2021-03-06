﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool GameEnded { get; private set; } = false;
    public static Controls Controls;

    [SerializeField] private Slider mainGauge;
    [SerializeField] private GameObject hand;
    [SerializeField] private GameObject goodEnd;

    [SerializeField] private AK.Wwise.RTPC gauge;
    [SerializeField] private AK.Wwise.Event badEnding;
    [SerializeField] private AK.Wwise.Event goodEnding;
    
    [SerializeField] private float drinkGauge = 50f;
    [SerializeField] private float talkGauge = 50f;

    [SerializeField] private float drinkGain = 0.1f;
    [SerializeField] private float talkGain = 1f;
    [SerializeField] private float drinkLoss = 0.5f;
    [SerializeField] private float talkLoss = 0.8f;
    
    public float DrinkGauge
    {
        get => drinkGauge;
        private set
        {
            drinkGauge = value;
            if (drinkGauge > 100f)
                drinkGauge = 100f;
            else if (drinkGauge < 0f)
                drinkGauge = 0f;
            mainGauge.value = drinkGauge + TalkGauge;
            if (WwiseGlobalObject.ObjectGaugeRTPC != null)
                gauge.SetValue(WwiseGlobalObject.ObjectGaugeRTPC, mainGauge.value/2f);
        }
    }

    public float TalkGauge
    {
        get => talkGauge;
        private set
        {
            talkGauge = value;
            if (talkGauge > 100f)
                talkGauge = 100f;
            else if (talkGauge < 0f)
                talkGauge = 0f;
            mainGauge.value = DrinkGauge + talkGauge;
            if (WwiseGlobalObject.ObjectGaugeRTPC != null)
                gauge.SetValue(WwiseGlobalObject.ObjectGaugeRTPC, mainGauge.value/2f);
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
        if (GameEnded)
            return;
        
        DrinkGauge -= drinkLoss * Time.deltaTime;
        TalkGauge -= talkLoss * Time.deltaTime;

        if (DrinkGauge + TalkGauge < 20f)
        {
            hand.SetActive(true);
            StartCoroutine("BindQuit");
            badEnding.Post(gameObject);
            GameEnded = true;
        }
        else if (DrinkGauge + TalkGauge > 181f)
        {
            goodEnd.SetActive(true);
            StartCoroutine("BindQuit");
            goodEnding.Post(gameObject);
            GameEnded = true;
        }
    }

    private IEnumerator BindQuit()
    {
        yield return new WaitForSeconds(3f);
        BindOnAnyButtonPressed(() => Quit());
    }

    private void Quit()
    {Debug.Log("quit");
        Application.Quit();
    }
    
    private delegate void MyDelegate();
    private void BindOnAnyButtonPressed(MyDelegate myDelegate)
    {
        InputSystem.onEvent += (eventPtr, device) =>
        {
            if (!eventPtr.IsA<StateEvent>() && !eventPtr.IsA<DeltaStateEvent>()) return;
        
            var controls = device.allControls;
            var buttonPressPoint = InputSystem.settings.defaultButtonPressPoint;
            foreach (var c in controls)
            {
                var control = c as ButtonControl;
                if (control == null || control.synthetic || control.noisy) continue;
                if (!control.ReadValueFromEvent(eventPtr, out var value) || !(value >= buttonPressPoint)) continue;
            
                myDelegate();
                break;
            }
        };
    }
}
