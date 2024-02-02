using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out GhostBehavior gbh))
        {
            gbh.ChangeGravity();
        }
    }
}