using UnityEngine;

public class Singleton : MonoBehaviour
{
    //�̱��� : �ϳ��� �ν��Ͻ��� �����ϸ鼭 ��𼭵� ���� �����ϰ�
    public static Singleton Instance { get; private set; }

    private void Awake()
    {
        //awake : start���� �� �� ������ ���۵Ǵ� ���� 1ȸ �Լ�
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // ���� �ٲ� destroy ���� �ʵ��� �ϴ� �Լ�
        }
        else
            Destroy(gameObject); // �ߺ� ���� ����
    }

    // Update is called once per frame
    public void PrintMessage()
    {
        Debug.Log("�̱��� �ż��� ���");
    }
}
