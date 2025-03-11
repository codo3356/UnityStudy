using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
    // �̱��� ����
    public static GamaManager Instance;
    public Text scoreText; // ����ǥ���ϴ� �ؽ�Ʈ ��ü
    public Text StartText; // ���� ���� 3 2 1 �� 

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

            yield return new WaitForSeconds(1); // 1�� ��ٸ��� 

            i--;

            if(i == 0 )
            {
                StartText.gameObject.SetActive(false); // UI ���߱�

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
