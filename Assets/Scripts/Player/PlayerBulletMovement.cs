using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletMovement : MonoBehaviour
{
    private Vector2 bulletPoint;
    private Vector2 result;


    public float bulletSpeed = 0.3f;


    private void Start()
    {
        Destroy(gameObject, 4f);
        Vector2 playerPos = FindObjectOfType<PlayerMovement>().transform.position;
        bulletPoint = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        result = bulletPoint - playerPos;

    }

    private void FixedUpdate()
    {
        transform.Translate(result.normalized * bulletSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
