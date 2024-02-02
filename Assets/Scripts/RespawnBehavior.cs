using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class RespawnBehavior : MonoBehaviour
{
    public UnityEvent RespawnEvent;
    public GameObject lastCheckpoint;

    private void Init()
    {
        lastCheckpoint = GetComponent<LastCheckPoint>().GetLastCheckpoint();
        lastCheckpoint.GetComponent<TP>().TeleportTo();
    }

    private void Start()
    {
        Invoke("Init", 0.01f);
    }

    public void Respawn()
    {
        RespawnEvent.Invoke();
        lastCheckpoint = GetComponent<LastCheckPoint>().GetLastCheckpoint();
        lastCheckpoint.GetComponent<TP>().TeleportTo();
    }
}
