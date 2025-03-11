using UnityEngine;

public class Enemy : MonoBehaviour
{

    //이동속도 지정
    public float moveSpeed = 1.3f;
    void Start()
    {
        
    }

    void Update()
    {
        //움직일 거리
        float distanceY = moveSpeed * Time.deltaTime;
        //움직이기
        transform.Translate(0, -distanceY, 0);
    }

    //화면 밖으로 나가 카메라에서 안보일 때 호출되는 함수

    private void OnBecameInvisible()
    {
        //카메라에서 나가면 삭제
        Destroy(gameObject); 
    }

}
