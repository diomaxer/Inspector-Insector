using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public float damage;

    private void Start()
    {
        damage = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().damage;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Health health = collision.gameObject.GetComponent<Health>();
            health.TakeHit(damage);
        }
        Destroy(gameObject);
    }
}
