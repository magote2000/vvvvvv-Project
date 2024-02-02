using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsController : MonoBehaviour
{
    private Animator _animationEffects;

    private void Awake()
    {
        _animationEffects = GetComponent<Animator>();
    }

    public void TriggerAnim()
    {
        _animationEffects.SetTrigger("Trigger");
    }
}
