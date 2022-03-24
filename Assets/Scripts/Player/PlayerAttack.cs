using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] GameObject PlayerBullet;

    private bool canFire = true;
    public float cooldown;
    public float reload = 0;

    private void Start()
    {
        cooldown = gameObject.GetComponent<Buffs>().cooldown;
        Debug.Log(cooldown);
    }


    private void Update()
    {
        if (Input.GetMouseButton(0) && canFire)
        {
            Instantiate(PlayerBullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            canFire = false;
        }

        if (!canFire)
        {
            cooldown = gameObject.GetComponent<Buffs>().cooldown;
            if (reload >= cooldown)
            {
                canFire = true;
                reload = 0;
            }
            else
            {
                reload += Time.deltaTime;
            }
        }
    }
}
