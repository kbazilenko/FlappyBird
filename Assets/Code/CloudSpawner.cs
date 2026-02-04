using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject Cloud;
    public float spawnInterval = 2;
    private float timer;
    public float lifeTime = 15f;
    public Vector2 spawnPositionMin = new Vector2(30, -13);
    public Vector2 spawnPositionMax = new Vector2(30, 13);
    
    private void ObjectSpawn()
    {
        float randomYN = Random.Range(0, spawnPositionMax.y);
        float randomYS = Random.Range(spawnPositionMin.y, 0);
        Vector2 spawnPositionN = new Vector2(30, randomYN);
        Vector2 spawnPositionS = new Vector2(35, randomYS);
        var cloudN = Instantiate(Cloud, spawnPositionN, Quaternion.identity);
        var cloudS = Instantiate(Cloud, spawnPositionS, Quaternion.identity);
        Destroy(cloudN, lifeTime);
        Destroy(cloudS, lifeTime);
    }
    
    private void Start()
    {
        timer = spawnInterval;
        ObjectSpawn();
    }
    
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            ObjectSpawn();
            timer = spawnInterval;
        }
    }
}
