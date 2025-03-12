using UnityEngine;

public class Player : MonoBehaviour
{

    public float MoveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*MoveSpeed*Time.deltaTime, 0, 0);
    }
}
