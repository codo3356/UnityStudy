using UnityEngine;

public class Bullet : MonoBehaviour
{

    //�Ѿ��� �̵� �ӵ�
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


    //�浹 Ʈ���� �̺�Ʈ�� ȣ��
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //�̻��ϰ� ���� �ε�����
        if(collision.gameObject.CompareTag("Enemy"))
        {
            //���� ����Ʈ ����
            Instantiate(explosion, transform.position, Quaternion.identity);

            //�� ����
            Destroy(collision.gameObject);
            //�Ѿ� ����(�ڽ�)
            Destroy(gameObject);

            //���� �ø���
            GamaManager.Instance.AddScore(10);

            //���� ��� �Ҹ� ���
            SoundManager.Instance.SoundBullet();
        }
    }


}
