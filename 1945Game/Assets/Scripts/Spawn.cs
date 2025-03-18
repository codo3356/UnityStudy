using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float ss = -2;
    public float es = 2;
    public float StartTime = 2;
    public float SpawnStop = 10;
    public GameObject monster;
    public GameObject monster2;
    public GameObject boss;

    bool swi = true;
    bool swi2 = true;

    [SerializeField]
    GameObject textBossWarning;

    private void Awake()
    {
        textBossWarning.SetActive(false);

        //오브젝트 풀 사용해보기. 몬스터를 10개 만들어두기
        //PoolManager.Instance.CreatePool(monster, 10);
    }

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

            //오브젝트 풀로 만들어보기 -> 어웨이크에서 풀 만들어두고
            //GameObject enemy = PoolManager.Instance.Get(monster);
            //enemy.transform.position = r;
            //삭제는 플레이어불릿에서 

        }
    }

    IEnumerator RandomSpawn2()
    {
        while (swi2)
        {
            yield return new WaitForSeconds(StartTime+1);
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
        Invoke("Stop2",SpawnStop);

    }


    void Stop2()
    {
        swi2 = false;
        StopCoroutine("RandomSpawn2");
        
        //보스 워닝
        textBossWarning.SetActive(true);

        //보스 생성 2.97
        Vector3 vec3 = new Vector3(0, 2.97f, 0);
        Instantiate(boss,vec3,Quaternion.identity);
    }
}
