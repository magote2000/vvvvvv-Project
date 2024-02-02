using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBehavior : MonoBehaviour
{
    private Vector3 direction;
    public float velocity;
    private int ver;
    private int back;

    private MovementBehavior _movement;
    private Animator _animation;

    private void Awake()
    {
        _movement = gameObject.GetComponent<MovementBehavior>();
        _animation = gameObject.GetComponent<Animator>();
        ver = 1;
    }

    void Update()
    {
        _movement.Move(new Vector3(0, ver, 0), velocity);
    }

    public void ChangeGravity()
    {
        ver *= -1;
        back = 1 - back;
        _animation.SetInteger("back", 1-back);
    }
}
