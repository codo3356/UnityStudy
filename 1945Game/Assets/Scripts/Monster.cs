using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3;
    //�Ѿ� ���� �ӵ�
    public float Delay = 1f;
    public Transform launcher1;
    public Transform launcher2;
    public GameObject bullet;
    public GameObject item;

    void Start()
    {
        //�ѹ� �Լ� ȣ��
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, launcher1.position, Quaternion.identity);
        Instantiate(bullet, launcher2.position , Quaternion.identity);

        //���ȣ��
        Invoke("CreateBullet", Delay);

    }


    void Update()
    {
        transform.Translate(Vector2.down * Speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if(Random.Range(1,100)<=40) //40�� Ȯ��
        {
            Instantiate(item, transform.position, Quaternion.identity);
        }
        Destroy(gameObject );
    }
}
