using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class PlayerController : MonoBehaviour
{
    public UnityEvent ChangeGravity;
    public GameObject player;

    public float velocityX;
    public float velocityY;
    float hor;
    float ver;

    bool dying;

    private MovementBehavior _movement;
    private flip _flip;

    public void Init()
    {
        dying = false;
        ver = -1;
    }

    private void Start()
    {
        dying = false;
        _flip = player.GetComponent<flip>();
        _movement = player.GetComponent<MovementBehavior>();
        ver = -1;
    }    

    void Update()
    {   
        if (dying==false)
        {
            hor = Input.GetAxisRaw("Horizontal");
            _flip.GetInputs(hor);

            if (Input.GetKeyDown("space"))
            {
                ver *= -1;
                ChangeGravity.Invoke();
            }
        }        
    }

    void FixedUpdate()
    {
        _movement.Move(new Vector3(hor, 0, 0), velocityX);
        _movement.Move(new Vector3(0, ver, 0), velocityY);
    }

    public void Dying()
    {
        dying = true;
        hor = 0;
        ver = 0;
    }    
}



