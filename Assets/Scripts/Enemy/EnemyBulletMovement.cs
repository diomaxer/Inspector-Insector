using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    public float bulletSpeed = 0.05f;
    public float offset = -92f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 result = FindObjectOfType<PlayerMovement>().transform.position - transform.position;
        float rotatteZ = Mathf.Atan2(result.y, result.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotatteZ + offset);
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.up.normalized * bulletSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
