using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffs : MonoBehaviour
{
    public float bulletSpeed;
    public float damage;
    public float cooldown;
    public float maxHealth;

    private void Start()
    {
        bulletSpeed = gameObject.GetComponent<PlayerMovement>().bulletSpeed;
        damage = gameObject.GetComponent<PlayerMovement>().damage;
        cooldown = gameObject.GetComponent<PlayerMovement>().cooldown;
        maxHealth = gameObject.GetComponent<PlayerMovement>().maxHealth;
    }


    public void RandomBuff()
    {
       if(Random.value <= 0.5)
        {
            BuffDamage();
        } else
        {
            BuffCooldown();
        }
    }

    public void BuffDamage()
    {
        damage += 5;
        DiscribeBuff("damage + 5");
        

    }
    public void BuffCooldown()
    {
        cooldown *= 0.85f;
        DiscribeBuff("Cooldown redused on 15%");

    }

    public void DiscribeBuff(string message)
    {
        Debug.Log(message);
    }

}
