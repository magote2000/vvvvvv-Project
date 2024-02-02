using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public void Animate(float hor, float ver)
    {
        if (hor != 0) FlipHor(hor);
        //else animator.moving = 0;
        FlipVer(ver);
    }

    void FlipVer(float ver)
    {
        /*
        if (ver == 1) GetComponent<Rigidbody2D>().flipy = 1;
        else GetComponent<Rigidbody2D>().flipy = 0;
        */
    }

    void FlipHor(float hor)
    {
        //GetComponent<Animator>().moving = 0;
        //if (hor == 1) int uwu = 0;/*GetComponent<Rigidbody2D>().flipx = 1;*/
        //else
        //{
            //transform.LocalScale *= -1;
        //}         
    }
}


