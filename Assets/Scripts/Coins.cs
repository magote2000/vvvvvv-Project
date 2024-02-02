using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int totalCoins;
    private GameObject[] coins;
    
    void Awake()
    {
        coins = gameObject.GetComponentsInChildren<GameObject>();
        totalCoins = coins.Length;
        Debug.Log(totalCoins);
    }
}
