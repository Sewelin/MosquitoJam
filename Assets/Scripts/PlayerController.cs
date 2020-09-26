using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Text drinkAction;
    [SerializeField] private Text talkAction;

    [SerializeField] private AK.Wwise.Event drinkSound;
    
    private Controls _controls;
    private List<InputAction> _actions;
    private InputAction _currentDrinkAction;
    private InputAction _currentTalkAction;

    [SerializeField] private float drinkChangeTime = 4f; 
    [SerializeField] private float talkAppearTime = 1f;

    private bool _talkPossible = false;

    private bool TalkPossible
    {
        get => _talkPossible;
        set
        {
            _talkPossible = value;
            talkAction.gameObject.SetActive(_talkPossible);
        }
    }

    private void Awake()
    {
        _controls = new Controls();
        _controls.Everything.Enable();
        
        _actions = new List<InputAction>
        {
            _controls.Everything.A,
            _controls.Everything.B,
            _controls.Everything.X,
            _controls.Everything.Y,
            _controls.Everything.Bottom,
            _controls.Everything.Right,
            _controls.Everything.Left,
            _controls.Everything.Up,
            _controls.Everything.LS,
            _controls.Everything.LT,
            _controls.Everything.RS,
            _controls.Everything.RT
        };
    }

    private void Start()
    {
        StartCoroutine("DrinkAssignation");
        StartCoroutine("TalkAssignation");
    }

    private IEnumerator DrinkAssignation()
    {
        while (!GameManager.GameEnded)
        {
            var testAction = _currentDrinkAction;
            while (testAction == _currentDrinkAction || testAction == _currentTalkAction)
            {
                testAction = _actions[Random.Range(0, _actions.Count - 4)];
            }
            _currentDrinkAction = testAction;
            drinkAction.text = _currentDrinkAction.name;
            
            _currentDrinkAction.performed += Drink;
            yield return new WaitForSeconds(drinkChangeTime);
            _currentDrinkAction.performed -= Drink;
        }
    }
    
    private IEnumerator TalkAssignation()
    {
        while (!GameManager.GameEnded)
        {
            var testAction = _currentTalkAction;
            while (testAction == _currentDrinkAction || testAction == _currentTalkAction)
            {
                testAction = _actions[Random.Range(0, _actions.Count - 4)];
            }
            _currentTalkAction = testAction;
            talkAction.text = _currentTalkAction.name;

            TalkPossible = true;
            _currentTalkAction.performed += Talk;
            yield return new WaitForSeconds(talkAppearTime);
            _currentTalkAction.performed -= Talk;
        }
    }

    private void Drink(InputAction.CallbackContext ctx)
    {
        gameManager.Drink();
        drinkSound.Post(gameObject);
    }

    private void Talk(InputAction.CallbackContext ctx)
    {
        if (!TalkPossible) return;
        TalkPossible = false;
        gameManager.Talk();
    }
}
