using UnityEngine;

public class Monster : MonoBehaviour
{
    public float Speed = 3;
    //총알 연사 속도
    public float Delay = 1f;
    public Transform launcher1;
    public Transform launcher2;
    public GameObject bullet;
    public GameObject item;

    void Start()
    {
        //한번 함수 호출
        Invoke("CreateBullet", Delay);
    }

    void CreateBullet()
    {
        Instantiate(bullet, launcher1.position, Quaternion.identity);
        Instantiate(bullet, launcher2.position , Quaternion.identity);

        //재귀호출
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
        if(Random.Range(1,100)<=40) //40퍼 확률
        {
            Instantiate(item, transform.position, Quaternion.identity);
        }
        Destroy(gameObject );
    }
}
