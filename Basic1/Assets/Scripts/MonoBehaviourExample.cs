using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start : ������ ���� �� �� ȣ��˴ϴ�");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update : �����Ӹ��� ȣ��˴ϴ�.");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdata : ���� ���꿡 ���˴ϴ�.");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    
    //��Ʈ�� ����Ʈ m

}
