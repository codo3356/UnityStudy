using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("ShootBullet", 0.5f, 0.5f);
    }


    public void ShootBullet()
    {
        Instantiate(bullet, this.GetComponent<Transform>().position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
