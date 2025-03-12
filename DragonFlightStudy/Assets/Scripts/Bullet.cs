using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float MoveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, MoveSpeed * Time.deltaTime, 0));
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Monster")) // 몬스터와 충돌 시
        {
            //점수 추가
            SmallEnemy enemy;
            if (collision.TryGetComponent<SmallEnemy>(out enemy)) // 몬스터가 스몰에네미 인 경우
            {
                GamaManager.Instant.AddScore(enemy.point); // 점수 더하기
            }
            //적 제거
            Destroy(collision.gameObject);
            //총알 제거
            Destroy(gameObject);
            //이펙트 재생

            //소리 재생
        }
    }




}
