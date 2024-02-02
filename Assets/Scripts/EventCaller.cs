using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class EventCaller : MonoBehaviour
{
    public UnityEvent newEvent;

    public void CallEvent()
    {
        newEvent.Invoke();
    }
}
