using UnityEngine;

public class PBullet : MonoBehaviour
{
    public float Speed = 4.0f;
    //���ݷ�
    public int Attack = 10;
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
            collision.gameObject.GetComponent<Monster>().Damage(Attack);
            //PoolManager.Instance.Return(collision.gameObject);
        }

        if (collision.CompareTag("Boss"))
        {
            //Destroy(collision.gameObject);
            //����Ʈ ���� �ؼ� ������Ʈ ������ �־���
            GameObject this_explosion = Instantiate(explosion, collision.transform.position, Quaternion.identity);
            //1�� �ڿ� ����
            Destroy(this_explosion, 1);
            Destroy(gameObject);
        }
    }

}
