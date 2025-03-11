using UnityEngine;

public class Bullet : MonoBehaviour
{

    //총알의 이동 속도
    public float moveSpeed = 0.45f;
    public GameObject explosion;
    void Start()
    {
    }

    void Update()
    {
        float distanceY = moveSpeed * Time.deltaTime;
        transform.Translate(0, distanceY, 0);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


    //충돌 트리거 이벤트시 호출
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //미사일과 적이 부딪히면
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //폭발 이펙트 생성
            Instantiate(explosion, transform.position, Quaternion.identity);

            //적 제거
            Destroy(collision.gameObject);
            //총알 제거(자신)
            Destroy(gameObject);

            //점수 올리기
            GamaManager.Instance.AddScore(10);

            //몬스터 사망 소리 재생
            SoundManager.Instance.SoundBullet();
        }
    }


}
