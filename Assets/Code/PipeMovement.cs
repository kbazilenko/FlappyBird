using System;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 1;
    
    private void Update()
    {
       var pos = transform.position;
       gameObject.transform.position = new Vector2(pos.x - speed*Time.deltaTime,pos.y); 
    }
}
