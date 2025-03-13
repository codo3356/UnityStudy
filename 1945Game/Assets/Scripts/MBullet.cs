using UnityEngine;

public class MBullet : MonoBehaviour
{
    public float speed = 3f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector2.down * speed*Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            //플레이어와 충돌 시 미사일 삭제
            Destroy(gameObject) ;
        }
        
    }
}
