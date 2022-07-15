using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 movement;
    public Rigidbody2D rb;

    public int health = 3;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void Damage()
    {
        health--;

        if(health<1)
        {
            Debug.Log("Player died");
        }
    }

}
