using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    //Coroutine ?? 
    // �Ϲ����� �Լ��� �ٸ��� ����ٰ� �ٽ� ������ �� �ִ� ���
    // ���� �ð� �� ���� or Ư�� ������ �����Ǹ� ���� ���� �� �� ����
    void Start()
    {
        //StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("�ڷ�ź ����");
        yield return new WaitForSeconds(2); // 2�� ���
        Debug.Log("2�� ��� �� ����");
    }
}
