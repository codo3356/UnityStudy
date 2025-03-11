using System.Collections;
using UnityEngine;

public class CoroutineStudy : MonoBehaviour
{
    //Coroutine ?? 
    // 일반적인 함수랑 다르게 멈췄다가 다시 시작할 수 있는 기능
    // 일정 시간 후 실행 or 특정 조건이 만족되면 실행 등을 할 수 있음
    void Start()
    {
        //StartCoroutine("ExampleCoroutine");
        StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        Debug.Log("코루탄 시작");
        yield return new WaitForSeconds(2); // 2초 대기
        Debug.Log("2초 대기 후 실행");
    }
}
