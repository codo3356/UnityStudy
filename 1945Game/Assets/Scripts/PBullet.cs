using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    //���ݷ�
    //����Ʈ
    public GameObject explosion;


    void Update()
    {
        // �̻��� �������� �̵�
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
            //����Ʈ ���� �ؼ� ������Ʈ ������ �־���
            GameObject this_explosion = Instantiate(explosion,collision.transform.position, Quaternion.identity);
            //1�� �ڿ� ����
            Destroy(this_explosion, 1);

            //�̻��� ����
            Destroy(gameObject) ;

            //���� ����
            Destroy(collision.gameObject);
        }
    }
}
