using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WwiseGlobalObject : MonoBehaviour
{
    public static GameObject ObjectGaugeRTPC { get; private set; }

    private void Awake()
    {
        ObjectGaugeRTPC = gameObject;
    }
}
