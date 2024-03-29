using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public void DestroyObject()
    {
        Destroy(gameObject);
    }

    public void DisableObject()
    {
        gameObject.SetActive(false);
    }
}
