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
            //1초 마다
            yield return new WaitForSeconds(StartTime);
            //랜덤 x에
            float x = Random.Range(ss, es);
            //y는 스폰매니저 위치
            Vector2 r = new Vector2(x, transform.position.y);
            //몬스터 생성
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
        //2번쨰 몬스터 스폰 시작
        StartCoroutine("RandomSpawn2");
        //30초 뒤에 2번째 몬스터 멈추기
        Invoke("Stop2",SpawnStop+20);

    }


    void Stop2()
    {
        swi2 = false;
        StopCoroutine("RandomSpawn2");

    }
}
