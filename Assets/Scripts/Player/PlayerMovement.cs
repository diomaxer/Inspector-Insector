using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 movement;

    // Movement speed
    public float moveSpeed = 4f;

    // Attack
    public float bulletSpeed = 0.3f;
    public float damage = 10f;
    public float cooldown = 1f;

    // Health
    public float health = 100f;
    public float maxHealth = 100f;
    
    
    // EXP
    public int exp = 0;
    public int level = 0;
    public int newLvl = 5;

    private void FixedUpdate()
    {
        MovementInput();
        rb.velocity = movement * moveSpeed;
    }

    void MovementInput()
    {
        float mx = Input.GetAxis("Horizontal");
        float my = Input.GetAxis("Vertical");

        movement = new Vector2(mx, my).normalized;
    }
}
