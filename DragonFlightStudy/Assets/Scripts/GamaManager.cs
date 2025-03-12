using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GamaManager : MonoBehaviour
{
    public static GamaManager Instant;
    public int score { get; private set; }
    public Text Scoretext;
    public Text Starttext;

    private void Awake()
    {
        //½Ì±ÛÅæ ¸¸µé±â 
        if (GamaManager.Instant == null)
            GamaManager.Instant = this;
        else
            Destroy(gameObject);
    }
    void Start()
    {
        score = 0;
        StartCoroutine(StartCount());
    }

    IEnumerator StartCount()
    {
        int i = 3;
        while(i > 0)
        {
            Starttext.text = i.ToString();
            yield return new WaitForSecondsRealtime(1);
            i--;

            if(i == 0)
            {
                Starttext.gameObject.SetActive(false);
            }
        }
    }

    public void AddScore(int num)
    {
        score += num;
        Scoretext.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
