using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction
        ;
    public Animator handAnimator;
    void Start()
    {
        
    }

    void Update()
    {
        float triggerValue = pinchAnimationAction.action.ReadValue<float>();
        float gripValue = gripAnimationAction.action.ReadValue<float>();
        print("Trigger Value: " + triggerValue);
        print("grip Value: " + gripValue);
        handAnimator.SetFloat("Trigger",triggerValue);
        handAnimator.SetFloat("Grip",gripValue);
    }
}
