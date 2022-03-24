using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffs : MonoBehaviour
{
    public float speed = 0.3f;
    public float damage = 10f;
    public float cooldown = 1f;
    public float maxHealth = 100;
    public float playerSpeed = 4f;


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
