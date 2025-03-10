using UnityEngine;

public class VariableExample : MonoBehaviour
{
    public int playerscore = 0;
    public float speed = 5.5f;
    public string playerName = "Hero";
    public bool isGameOver = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //출력해보기
        Debug.Log("Player Name : " + playerName);
        Debug.Log($"Player Name : {playerName}");
        Debug.Log("Player Score : " + playerscore);
        Debug.Log("Player Speed : " + speed);
        Debug.Log("Is Game Over? : " + isGameOver);
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
