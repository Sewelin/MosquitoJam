using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodEnd : MonoBehaviour
{
    [SerializeField] private List<GameObject> objectsToDeactivate = new List<GameObject>();
    [SerializeField] private List<Animator> objectsToGoodHand = new List<Animator>();
    private static readonly int End = Animator.StringToHash("GoodEnd");

    private void Start()
    {
        objectsToDeactivate.ForEach(obj => obj.SetActive(false));
        objectsToGoodHand.ForEach(animator => animator.SetTrigger(End));
    }
}
