using System;
using UnityEngine;

public class BirdCollision : MonoBehaviour
{
    public GameManager GameManager;
    
    private void OnCollisionEnter2D(Collision2D other)
     {
         GameManager.GameOver();
     }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.AddScore();
    }
    
 }
