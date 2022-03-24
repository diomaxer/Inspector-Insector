using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject experience;
    public float health = 10;
    public float maxHealth = 10;
    private float ExpChance = 1f;

    public void TakeHit(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Destroy(gameObject);
            if (gameObject.tag == "Enemy" )
            {
                if (Random.value <= ExpChance)
                {
                    Instantiate(experience, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                }
            }
        }
    }
}
