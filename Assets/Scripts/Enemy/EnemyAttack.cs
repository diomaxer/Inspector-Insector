using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public float cooldownTime = 2f;
    public float currentTime = 0;


    private void FixedUpdate()
    {
        if (currentTime >= cooldownTime && GameObject.FindGameObjectWithTag("Player"))
        {
            currentTime = 0;
            Instantiate(enemyBulletPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }
}
