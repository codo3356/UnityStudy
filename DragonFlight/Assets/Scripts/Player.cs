using UnityEngine;

public class Player : MonoBehaviour
{
    // �����̴� �ӵ�
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
        //�����ð��� �̵��Ÿ�
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //�̵���Ű�� 
        transform.Translate(distanceX, 0, 0);
    }
}
