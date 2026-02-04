using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private float jumpForce = 5;
    private Rigidbody2D rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = new Vector2(0, jumpForce);
        }
    }
}
