using UnityEngine;


public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnInterval = 2;
    private float timer;
    public float lifeTime = 5f;
    public Vector2 spawnPositionMin = new Vector2(30, -10);
    public Vector2 spawnPositionMax = new Vector2(30, 10);

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

    private void ObjectSpawn()
    {
        float randomY = Random.Range(spawnPositionMin.y, spawnPositionMax.y);
        Vector2 spawnPosition = new Vector2(30, randomY);
        var pipe = Instantiate(Pipe, spawnPosition, Quaternion.identity);
        Destroy(pipe, lifeTime);
    }
}
