using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1.0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnEnemy()
    {
        float randomx = Random.Range(-2f, 2f);

        Instantiate(enemy, new Vector3(randomx,transform.position.y,0), Quaternion.identity);
    }
}
