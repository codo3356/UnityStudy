using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
    // 싱글톤 선언
    public static GamaManager Instance;
    public Text scoreText; // 점수표시하는 텍스트 객체
    public Text StartText; // 게임 시작 3 2 1 떙 

    int score = 0;

    private void Awake()
    {
        if (GamaManager.Instance == null)
            GamaManager.Instance = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        int i = 3; 
        while(i > 0 )
        {
            StartText.text = i.ToString();

            yield return new WaitForSeconds(1); // 1초 기다리기 

            i--;

            if(i == 0 )
            {
                StartText.gameObject.SetActive(false); // UI 감추기

            }
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score : " + score;
    }

    void Update()
    {
        
    }
}
