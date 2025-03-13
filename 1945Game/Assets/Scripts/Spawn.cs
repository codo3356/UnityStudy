using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float ss = -2;
    public float es = 2;
    public float StartTime = 1;
    public float SpawnStop = 10;
    public GameObject monster;
    public GameObject monster2;

    bool swi = true;
    bool swi2 = true;
    void Start()
    {
        StartCoroutine("RandomSpawn");
        Invoke("Stop", SpawnStop);
    }

    IEnumerator RandomSpawn()
    {
        while (swi)
        {
            //1�� ����
            yield return new WaitForSeconds(StartTime);
            //���� x��
            float x = Random.Range(ss, es);
            //y�� �����Ŵ��� ��ġ
            Vector2 r = new Vector2(x, transform.position.y);
            //���� ����
            Instantiate(monster, r, Quaternion.identity);

        }
    }

    IEnumerator RandomSpawn2()
    {
        while (swi2)
        {
            yield return new WaitForSeconds(StartTime+2);
            float x = Random.Range(ss, es);
            Vector2 r2 = new Vector2(x, transform.position.y);
            Instantiate(monster2, r2, Quaternion.identity);
        }
    }

    void Stop()
    {
        swi = false;
        StopCoroutine("RandomSpawn");
        //2���� ���� ���� ����
        StartCoroutine("RandomSpawn2");
        //30�� �ڿ� 2��° ���� ���߱�
        Invoke("Stop2",SpawnStop+20);

    }


    void Stop2()
    {
        swi2 = false;
        StopCoroutine("RandomSpawn2");

    }
}
