// Spawner.cs
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject flaskPrefab;
    public float baseSpawnInterval = 1.2f;
    public float spawnIntervalMin = 0.25f;
    public float baseFallSpeed = 2.0f;
    public float fallSpeedMax = 8.0f;
    public float spawnXPadding = 0.2f;

    float spawnTimer = 0f;

    void Update()
    {
        float t = GameManager.I != null ? GameManager.I.caughtCount : 0;
        float spawnInterval = Mathf.Lerp(baseSpawnInterval, spawnIntervalMin, t / 20f);
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0f)
        {
            spawnTimer = spawnInterval;
            SpawnFlask();
        }
    }

    void SpawnFlask()
    {
        float camLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + spawnXPadding;
        float camRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - spawnXPadding;
        float x = Random.Range(camLeft, camRight);
        Vector3 pos = new Vector3(x, Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y + 0.5f, 0);
        var go = Instantiate(flaskPrefab, pos, Quaternion.identity);
        float t = GameManager.I != null ? GameManager.I.caughtCount : 0;
        float speed = Mathf.Lerp(baseFallSpeed, fallSpeedMax, t / 20f);
        var f = go.GetComponent<Flask>();
        if (f != null) f.Init(speed);
    }
}
