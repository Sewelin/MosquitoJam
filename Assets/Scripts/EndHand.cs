using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHand : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToDeactivate = new List<GameObject>();
    [SerializeField] private List<Animator> objectsToEndHand = new List<Animator>();
    private static readonly int End = Animator.StringToHash("EndHand");

    private void Start()
    {
        objectsToDeactivate.ForEach(obj => obj.SetActive(false));
        objectsToEndHand.ForEach(animator => animator.SetTrigger(End));
    }
}
