using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Text healtText;
    private GameObject player;
    private float maxHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        maxHealth = player.GetComponent<PlayerHealth>().maxHealth;
        SetMaxHealth(maxHealth);
    }

    public void SetMaxHealth(float maxHealth)
    {
        slider.maxValue = maxHealth;
        slider.value = maxHealth;
        healtText.text = "HP 100 %";
    }

    public void SetHealth(float health)
    {
        slider.value = health;
        healtText.text = "HP " + (health / maxHealth).ToString("0 %");
        Debug.Log(health);
    }
}
