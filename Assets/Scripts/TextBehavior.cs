using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavior : MonoBehaviour
{
    public Text text;
    private int maxPuntuation;
    public GameObject Player;

    public void Start()
    {
        maxPuntuation = Player.GetComponent<GetPuntuation>().GetMaxPuntuation();
        text.text = "0 / " + maxPuntuation;
    }

    public void TextBehav(int punt, int maxPunt)
    {
        text.text = punt + "  /  " + maxPunt;
    }
}
