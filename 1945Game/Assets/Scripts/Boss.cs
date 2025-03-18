using System;
using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour
{
    int flag = 1;
    int speed = 2;
    int hp = 1000;

    public GameObject mb;
    public GameObject mb2;
    public Transform launcher1;
    public Transform launcher2;

    void Start()
    {
        Invoke("Hide", 3);
        //Hide();
        StartCoroutine(BossShoot());
        StartCoroutine(CircleFire());
        
    }

    void Hide()
    {
        GameObject.Find("TextBossWarning").SetActive(false);
    }

    IEnumerator BossShoot()
    {
        while (true)
        {
            //�̻��� ���
            Instantiate(mb, launcher1.position, Quaternion.identity);
            Instantiate(mb, launcher2.position, Quaternion.identity);

            yield return new WaitForSeconds(1);

        }
    }

    //����� �̻��� �߻�
    IEnumerator CircleFire()
    {
        float attackRate = 3;
        int count = 30;
        //�߻�ü ������ ����
        float intervalAngle = 360 / count;
        //���ߵǴ� ����(������ġ�� �߻����� �ʵ��� ����
        float weightAngle = 0f;
        
        //�� ���·� ����ϴ� �߻�ü ����
        while (true)
        {
            for(int i = 0; i < count; i ++)
            {
                //�߻�ü ����
                GameObject clone = Instantiate(mb2, transform.position,Quaternion.identity);

                //�߻�ü ���� ����
                float angle = weightAngle + intervalAngle * i;
                //�߻�ü �̵� ����(����)
                //cos�������� �Ϸ��� ������ ��������
                //angle * Mathf.Deg2Radd
                float x = Mathf.Cos(angle*Mathf.Deg2Rad);
                float y = Mathf.Sin(angle*Mathf.Deg2Rad);

                //�߻�ü �̵� ���� ����
                clone.GetComponent<BossBullet>().Move(new Vector2(x, y));
            }
            //�����߻� ���ݾ� Ʋ���ֱ�
            weightAngle += 1;

            //3�ʸ��� �߻�
            yield return new WaitForSeconds(attackRate);
        }
    }
    void Update()
    {
        if (transform.position.x >= 1)
            flag *= -1;
        if (transform.position.x <= -1)
            flag *= -1;

        transform.Translate(flag * speed * Time.deltaTime,0,0);
    }

    public void Damage(int attack)
    {
        hp-=attack;
        if(hp < 0)
        {
            Destroy(gameObject);
        }
    }
}
