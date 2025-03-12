using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Player_bullet bullet;
    void Start()
    {
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
