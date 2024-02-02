using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class item : MonoBehaviour
{
    public Sprite sprite;
    public string name;
    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = sprite;
    }
    public abstract void Apply(GameObject target);
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Apply(collision.gameObject);
    }
}
