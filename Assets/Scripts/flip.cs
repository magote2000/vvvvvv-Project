using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    float tempScaleX;
    float tempScaleY;
    float scaleX;
    float scaleY;
    float hor;

    public void Init()
    {
        tempScaleX = scaleX;
        tempScaleY = scaleY;
    }

    private void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        tempScaleX = scaleX;
        tempScaleY = scaleY;
    }

    void Update()
    {
        if (hor > 0)
        {
            tempScaleX = scaleX;
        }
        else if (hor < 0)
        {
            tempScaleX = -scaleX;
        }
        transform.localScale = new Vector3(tempScaleX, tempScaleY, transform.localScale.z);
    }

    public void GetInputs(float h)
    {
        hor = h;
    }

    public void Flip()
    {
        tempScaleY *= -1;
    }
}

