using UnityEngine;

public class Singleton : MonoBehaviour
{
    //싱글톤 : 하나의 인스턴스를 유지하면서 어디서든 접근 가능하게
    public static Singleton Instance { get; private set; }

    private void Awake()
    {
        //awake : start보다 좀 더 빠르게 시작되는 최초 1회 함수
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬이 바뀌어도 destroy 하지 않도록 하는 함수
        }
        else
            Destroy(gameObject); // 중복 생성 방지
    }

    // Update is called once per frame
    public void PrintMessage()
    {
        Debug.Log("싱글톤 매세지 출력");
    }
}
