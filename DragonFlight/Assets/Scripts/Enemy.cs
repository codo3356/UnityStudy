using UnityEngine;

public class Enemy : MonoBehaviour
{

    //�̵��ӵ� ����
    public float moveSpeed = 1.3f;
    void Start()
    {
        
    }

    void Update()
    {
        //������ �Ÿ�
        float distanceY = moveSpeed * Time.deltaTime;
        //�����̱�
        transform.Translate(0, -distanceY, 0);
    }

    //ȭ�� ������ ���� ī�޶󿡼� �Ⱥ��� �� ȣ��Ǵ� �Լ�

    private void OnBecameInvisible()
    {
        //ī�޶󿡼� ������ ����
        Destroy(gameObject); 
    }

}
