using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    //공격력
    //이펙트
    public GameObject explosion;


    void Update()
    {
        // 미사일 위쪽으로 이동
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }


    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Monster"))
        {
            //이펙트 생성 해서 오브젝트 변수에 넣어줌
            GameObject this_explosion = Instantiate(explosion,collision.transform.position, Quaternion.identity);
            //1초 뒤에 삭제
            Destroy(this_explosion, 1);

            //미사일 삭제
            Destroy(gameObject) ;

            //몬스터 삭제
            Destroy(collision.gameObject);
        }
    }
}
