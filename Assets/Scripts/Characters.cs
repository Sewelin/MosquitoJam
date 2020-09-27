using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    [SerializeField] private Animator white;
    [SerializeField] private Animator black;

    [SerializeField] private float talkTime;
    [SerializeField] private float breakTime;

    private void Start()
    {
        
    }

    private IEnumerator Discussion()
    {
        while (!GameManager.GameEnded)
        {
            yield return new WaitForSeconds(3f);
        }
    }
}
