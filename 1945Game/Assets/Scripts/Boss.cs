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
            //미사일 쏘기
            Instantiate(mb, launcher1.position, Quaternion.identity);
            Instantiate(mb, launcher2.position, Quaternion.identity);

            yield return new WaitForSeconds(1);

        }
    }

    //원모양 미사일 발사
    IEnumerator CircleFire()
    {
        float attackRate = 3;
        int count = 30;
        //발사체 사이의 각도
        float intervalAngle = 360 / count;
        //가중되는 각도(같은위치로 발사하지 않도록 설정
        float weightAngle = 0f;
        
        //원 형태로 방사하는 발사체 생성
        while (true)
        {
            for(int i = 0; i < count; i ++)
            {
                //발사체 생성
                GameObject clone = Instantiate(mb2, transform.position,Quaternion.identity);

                //발사체 각도 변경
                float angle = weightAngle + intervalAngle * i;
                //발사체 이동 방향(벡터)
                //cos라디안으로 하려고 각도를 라디안으로
                //angle * Mathf.Deg2Radd
                float x = Mathf.Cos(angle*Mathf.Deg2Rad);
                float y = Mathf.Sin(angle*Mathf.Deg2Rad);

                //발사체 이동 방향 설정
                clone.GetComponent<BossBullet>().Move(new Vector2(x, y));
            }
            //원형발사 조금씩 틀어주기
            weightAngle += 1;

            //3초마다 발사
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
