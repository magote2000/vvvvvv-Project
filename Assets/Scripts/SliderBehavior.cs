using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBehavior : MonoBehaviour
{
    public Slider slide;
    public void BarBehav(int punt, int maxPunt)
    {
        float progressPerc = ((float)punt / (float)maxPunt);
        slide.value = progressPerc;
    }
}
