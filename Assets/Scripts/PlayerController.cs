using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Controls _controls;
    private List<Action<InputAction.CallbackContext>> _actions;

    private void Awake()
    {
        _controls = new Controls();
        _controls.Everything.Enable();
        
        _controls.Everything.A.performed += TestText;
        //StartCoroutine(TestChange());
    }

    private void TestText(InputAction.CallbackContext context)
    {
        Debug.Log("A");
    }

    private IEnumerator TestChange()
    {
        yield return new WaitForSeconds(5f);
        _controls.Everything.A.performed -= TestText;
    }
}
