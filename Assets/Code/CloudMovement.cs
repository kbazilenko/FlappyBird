using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speedCloud = 2;
    
    private void Update()
    {
        var pos = transform.position;
        gameObject.transform.position = new Vector2(pos.x - speedCloud*Time.deltaTime,pos.y); 
    }
}
