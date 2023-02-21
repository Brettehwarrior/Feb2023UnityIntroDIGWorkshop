using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Fields
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpSpeed = 10f;
    [SerializeField] private float moveSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        
        rb.AddForce(new Vector2(horizontalInput, 0f) * moveSpeed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Platform") && rb.velocity.y < 0f)
        {
            Jump();
            Destroy(col.gameObject);
        }
    }
}
