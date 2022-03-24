using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private float bulletSpeed = 0.3f;
    private Vector2 bulletPoint;
    private Vector2 result;
    public string collisionTag;
    public int PlayerDamage = 10;


    private void Start()
    {
        Destroy(gameObject, 4f);
        Vector2 playerPos = FindObjectOfType<PlayerMovement>().transform.position;
        bulletPoint = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        result = bulletPoint - playerPos;

    }

    private void FixedUpdate()
    {
        Debug.Log(bulletPoint);
        transform.Translate(result.normalized * bulletSpeed);
    }
}
