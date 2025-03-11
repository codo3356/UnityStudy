using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject bullet; // �̻��� �������� �����ð�
    void Start()
    {
        //�޼��带 �ʱ������ð� 0.5 �Ŀ� 0.5���� �ݺ�
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        //(�̻��� ������, ��ó�� ������, ���Ⱚ ����)
        Instantiate(bullet, transform.position, Quaternion.identity);
        SoundManager.Instance.SoundBullet();
    }

    void Update()
    {
        
    }
}
