using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Slider slider;
    public Text expText;
    public PlayerExperience playerExp;

    void Start()
    { 
        SetStartExp(playerExp.exp);
    }

    public void SetStartExp(int exp)
    {
        slider.value = exp;
    }

    public void SetExp(int exp, int newLvl)
    {
        slider.value = exp;
        expText.text = "LVL " + playerExp.level;
        slider.maxValue = newLvl;
    }
}
