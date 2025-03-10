using UnityEngine;

public class ConditionalExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public int health = 100;
    // Update is called once per frame
    void Update()
    {
        health--;
        Debug.Log(health);
        if(health <= 0)
        {
            Debug.Log("Game Over");
            health = 100;
        }
    }
}
