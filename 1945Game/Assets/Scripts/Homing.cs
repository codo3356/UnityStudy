using UnityEngine;

public class Homing : MonoBehaviour
{
    public GameObject target; // 플레이어
    public float Speed = 3f;
    //방향 벡터
    Vector2 dir; 
    Vector2 dirNo;
    void Start()
    {
        //플레이어 찾기(태그 사용)
        target = GameObject.FindGameObjectWithTag("Player");


        // A - B 벡터 : B가 A를 바라보는 벡터
        dir = target.transform.position - transform.position;
        // 방향벡터(정규화, 노말라이즈)
        dirNo = dir.normalized;
    }

    void Update()
    {
        //// A - B 벡터 : B가 A를 바라보는 벡터
        //dir = target.transform.position - transform.position;
        //// 방향벡터(정규화, 노말라이즈)
        //dirNo = dir.normalized;


        transform.Translate(dirNo * Speed*Time.deltaTime);

        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position,Speed*Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
