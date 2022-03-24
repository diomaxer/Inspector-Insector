using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100f;
    public float maxHealth = 100f;

    public void TakeHit(float damage)
    {
        health -= damage;
        GameObject.FindGameObjectWithTag("HealthBar").GetComponent<HealthBar>().SetHealth(health);

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void PlusHealth(int heal)
    {
        health += heal;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
