using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject bullet; // 미사일 프리펩을 가져올것
    void Start()
    {
        //메서드를 초기지연시간 0.5 후에 0.5마다 반복
        InvokeRepeating("Shoot", 0.5f, 0.5f);
    }

    void Shoot()
    {
        //(미사일 프리펩, 런처의 포지션, 방향값 없음)
        Instantiate(bullet, transform.position, Quaternion.identity);
        SoundManager.Instance.SoundBullet();
    }

    void Update()
    {
        
    }
}
