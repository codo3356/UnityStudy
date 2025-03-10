using UnityEngine;

public class MoveWithGravity : MonoBehaviour
{


    public Rigidbody rb;
    public float JumpForce = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SpaceBar 누르면 점프
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //rigidbody 
            //addforce : 오브젝트에 힘을 가함
            //forcemode.impulse : 순간 힘을 가함
            rb.AddForce(Vector3.up * JumpForce,ForceMode.Impulse);
        }
    }
}
