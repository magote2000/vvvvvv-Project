using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator _animation;

    public void Init()
    {
        _animation.SetInteger("dead", 0);
    }

    private void Start()
    {
        _animation = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        int moving = 0;
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            moving = 1;
        }
        _animation.SetInteger("moving", moving);
    }

    public void Dying()
    {
        _animation.SetInteger("dead", 1);
    }
}



