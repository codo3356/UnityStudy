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

        //������Ʈ Ǯ ����غ���. ���͸� 10�� �����α�
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
            //1�� ����
            yield return new WaitForSeconds(StartTime);
            //���� x��
            float x = Random.Range(ss, es);
            //y�� �����Ŵ��� ��ġ
            Vector2 r = new Vector2(x, transform.position.y);
            //���� ����
            Instantiate(monster, r, Quaternion.identity);

            //������Ʈ Ǯ�� ������ -> �����ũ���� Ǯ �����ΰ�
            //GameObject enemy = PoolManager.Instance.Get(monster);
            //enemy.transform.position = r;
            //������ �÷��̾�Ҹ����� 

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
        //2���� ���� ���� ����
        StartCoroutine("RandomSpawn2");
        //30�� �ڿ� 2��° ���� ���߱�
        Invoke("Stop2",SpawnStop);

    }


    void Stop2()
    {
        swi2 = false;
        StopCoroutine("RandomSpawn2");
        
        //���� ����
        textBossWarning.SetActive(true);

        //���� ���� 2.97
        Vector3 vec3 = new Vector3(0, 2.97f, 0);
        Instantiate(boss,vec3,Quaternion.identity);
    }
}
