using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;

    private void Start()
    {
        health = gameObject.GetComponent<PlayerMovement>().health;
        maxHealth = gameObject.GetComponent<PlayerMovement>().maxHealth;
    }

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
