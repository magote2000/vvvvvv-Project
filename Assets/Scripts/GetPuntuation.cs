using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPuntuation : MonoBehaviour
{
   public int GetMaxPuntuation() 
    {
        return ItemManager.Instance.itemslist.Count;
    }
}
