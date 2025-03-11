using UnityEngine;

public class Player : MonoBehaviour
{
    // 움직이는 속도
    public float moveSpeed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveControl();
    }

    private void moveControl()
    {
        //단위시간당 이동거리
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //이동시키기 
        transform.Translate(distanceX, 0, 0);
    }
}
