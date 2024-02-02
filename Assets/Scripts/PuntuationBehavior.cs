using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class PuntuationBehavior : MonoBehaviour
{
    public int maxPuntuation;
    public int puntuation = 0;

    public UnityEvent maxPuntReached;
    public UnityEvent<int, int> sumPunt;

    public void Init()
    {
        puntuation = 0;
        GetPoint(ItemManager.Instance.ReturnItemsPicked());
    }

    public void Start()
    {
        puntuation = 0;
        maxPuntuation = ItemManager.Instance.itemslist.Count;
        Invoke("Init",0.01f);
    }

    public void GetPoint(int sum)
    {
        puntuation += sum;
        sumPunt.Invoke(puntuation, maxPuntuation);
        if (puntuation >= maxPuntuation)
        {
            puntuation = maxPuntuation;
            maxPuntReached.Invoke();
        }
    }
}
