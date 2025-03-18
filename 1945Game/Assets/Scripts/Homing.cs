using System.Collections;
using UnityEngine;

public class Homing : MonoBehaviour
{
    public GameObject target; // �÷��̾�
    public float Speed = 3f;
    //���� ����
    Vector2 dir; 
    Vector2 dirNo;
    Vector2 vec2 = Vector2.down;
    bool flag = false;
    void Start()
    {
        //�÷��̾� ã��(�±� ���)
        target = GameObject.FindGameObjectWithTag("Player");


        // A - B ���� : B�� A�� �ٶ󺸴� ����
        dir = target.transform.position - transform.position;
        // ���⺤��(����ȭ, �븻������)
        dirNo = dir.normalized;

    }

    void Update()
    {
        transform.Translate(dirNo * Speed* Time.deltaTime);

        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position,Speed*Time.deltaTime);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
