using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    public float followSpeed = 0.05f;
    public float offset = -92f;
    public int damage = 5;
    public float coolDown = 1f;
    public float currentTime = 1f;

    private void FixedUpdate()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            Vector3 result = FindObjectOfType<PlayerMovement>().transform.position - transform.position;
            float rotatteZ = Mathf.Atan2(result.y, result.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotatteZ + offset);
            transform.Translate(Vector3.up.normalized * followSpeed);
        }
    }

    /*private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && coolDown <= currentTime)
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
            health.TakeHit(damage);
            currentTime = 0;
        }
        else
        {
            currentTime += Time.deltaTime;
        }
    }*/
}
