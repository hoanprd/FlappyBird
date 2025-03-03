using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightVariation = 2f;

    void Start()
    {
        if (Bird.gameOver == false)
        {
            InvokeRepeating(nameof(SpawnPipe), 0f, spawnRate);
        }
    }

    void SpawnPipe()
    {
        float randomY = Random.Range(-heightVariation, heightVariation);
        Vector3 spawnPos = new Vector3(5f, randomY, 0);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}
