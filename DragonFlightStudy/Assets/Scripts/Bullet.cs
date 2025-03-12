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
        if (collision.CompareTag("Monster")) // ���Ϳ� �浹 ��
        {
            //���� �߰�
            SmallEnemy enemy;
            if (collision.TryGetComponent<SmallEnemy>(out enemy)) // ���Ͱ� �������׹� �� ���
            {
                GamaManager.Instant.AddScore(enemy.point); // ���� ���ϱ�
            }
            //�� ����
            Destroy(collision.gameObject);
            //�Ѿ� ����
            Destroy(gameObject);
            //����Ʈ ���

            //�Ҹ� ���
        }
    }




}
