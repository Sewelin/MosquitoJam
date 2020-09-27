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
    [SerializeField] private List<Image> drinkAction = new List<Image>();
    [SerializeField] private List<Text> drinkActionText = new List<Text>();
    [SerializeField] private List<Image> talkAction = new List<Image>();
    [SerializeField] private List<Text> talkActionText = new List<Text>();
    [SerializeField] private List<Sprite> buttonSprites = new List<Sprite>();

    [SerializeField] private AK.Wwise.Event drinkSound;
    
    private Controls _controls;
    private List<InputAction> _actions;
    private readonly List<InputAction> _currentDrinkAction = new List<InputAction> {null, null};
    private readonly List<InputAction> _currentTalkAction = new List<InputAction> {null, null};
    private List<Animator> _drinkAnimators = new List<Animator>();
    private readonly List<bool> _talkPossible = new List<bool> {false, false};

    [SerializeField] private Rect talkZone0 = new Rect();
    [SerializeField] private Rect talkZone1 = new Rect();

    [SerializeField] private float drinkChangeTime = 4f; 
    [SerializeField] private float talkAppearTime = 1f;

    private static readonly int Pressed = Animator.StringToHash("Pressed");

    private void SetTalkPossible(int num, bool value, string actionName = "", Sprite buttonSprite = null)
    {
        _talkPossible[num] = value;
        if (value)
        {
            var talkZone = num == 0 ? talkZone0 : talkZone1;
            var min = new Vector2(Random.Range(talkZone.xMin, talkZone.xMax),
                Random.Range(talkZone.yMin, talkZone.yMax));
            ((RectTransform) talkAction[num].transform).anchorMin = min;
            ((RectTransform) talkAction[num].transform).anchorMax = min + new Vector2(0.07f, 0.124f);

            talkAction[num].sprite = buttonSprite;
            talkActionText[num].text = actionName;
        }
        talkAction[num].gameObject.SetActive(_talkPossible[num]);
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
        
        drinkAction.ForEach(action => _drinkAnimators.Add(action.GetComponent<Animator>()));
    }

    private void Start()
    {
        StartCoroutine("DrinkAssignation", 0);
        StartCoroutine("TalkAssignation", 0);
        StartCoroutine("DrinkAssignation", 1);
        StartCoroutine("TalkAssignation", 1);
    }

    private IEnumerator DrinkAssignation(int num)
    {
        while (!GameManager.GameEnded)
        {
            var testAction = _currentDrinkAction[num];
            var buttonSprite = drinkAction[num].sprite;
            while (testAction == _currentDrinkAction[0] || testAction == _currentDrinkAction[1] ||
                   testAction == _currentTalkAction[0] || testAction == _currentTalkAction[1])
            {
                var i = Random.Range(0, _actions.Count - 4);
                testAction = _actions[i];
                buttonSprite = buttonSprites[i];
            }
            _currentDrinkAction[num] = testAction;
            drinkAction[num].sprite = buttonSprite;
            drinkActionText[num].text = _currentDrinkAction[num].name;
            
            switch (num)
            {
                case 0:
                    _currentDrinkAction[num].performed += Drink0;
                    break;
                case 1:
                    _currentDrinkAction[num].performed += Drink1;
                    break;
            }
            yield return new WaitForSeconds(drinkChangeTime);
            switch (num)
            {
                case 0:
                    _currentDrinkAction[num].performed -= Drink0;
                    break;
                case 1:
                    _currentDrinkAction[num].performed -= Drink1;
                    break;
            }
        }
    }
    
    private IEnumerator TalkAssignation(int num)
    {
        while (!GameManager.GameEnded)
        {
            var testAction = _currentTalkAction[num];
            var buttonSprite = talkAction[num].sprite;
            while (testAction == _currentDrinkAction[0] || testAction == _currentDrinkAction[1] ||
                   testAction == _currentTalkAction[0] || testAction == _currentTalkAction[1])
            {
                var i = Random.Range(0, _actions.Count - 4);
                testAction = _actions[i];
                buttonSprite = buttonSprites[i];
            }
            _currentTalkAction[num] = testAction;

            SetTalkPossible(num, true, _currentTalkAction[num].name, buttonSprite);
            switch (num)
            {
                case 0:
                    _currentTalkAction[num].performed += Talk0;
                    break;
                case 1:
                    _currentTalkAction[num].performed += Talk1;
                    break;
            }
            yield return new WaitForSeconds(talkAppearTime);
            switch (num)
            {
                case 0:
                    _currentTalkAction[num].performed -= Talk0;
                    break;
                case 1:
                    _currentTalkAction[num].performed -= Talk1;
                    break;
            }
        }
    }

    private void Drink0(InputAction.CallbackContext ctx)
    {
        if (GameManager.GameEnded) return;
        gameManager.Drink();
        _drinkAnimators[0].SetTrigger(Pressed);
        drinkSound.Post(gameObject);
    }
    
    private void Drink1(InputAction.CallbackContext ctx)
    {
        if (GameManager.GameEnded) return;
        gameManager.Drink();
        _drinkAnimators[1].SetTrigger(Pressed);
        drinkSound.Post(gameObject);
    }

    private void Talk0(InputAction.CallbackContext ctx)
    {
        if (!_talkPossible[0] || GameManager.GameEnded) return;
        SetTalkPossible(0, false);
        gameManager.Talk();
    }
    
    private void Talk1(InputAction.CallbackContext ctx)
    {
        if (!_talkPossible[1] || GameManager.GameEnded) return;
        SetTalkPossible(1, false);
        gameManager.Talk();
    }
}
