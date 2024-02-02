using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComponentBehavior : MonoBehaviour
{
    private Collider2D _collider;

    private void Awake()
    {
        _collider = GetComponent<Collider2D>();
    }

    public void DisableComponent ()
    {
        _collider.enabled = false;
    }
}
