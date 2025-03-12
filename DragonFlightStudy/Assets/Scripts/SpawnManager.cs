using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject monster;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnMonster", 1.0f, 1.0f);
    }

    void SpawnMonster()
    {

        Instantiate(monster, new Vector2(Random.Range(-2.0f,2.0f), transform.position.y), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
