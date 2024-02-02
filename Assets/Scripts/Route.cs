using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Route : MonoBehaviour
{

    public static Transform[] PointsList;

    // Start is called before the first frame update
    void Awake()
    {
        PointsList = GetComponentsInChildren<Transform>();
    }

    public Transform[] GetRoute()
    {
        return PointsList;
    }
}
