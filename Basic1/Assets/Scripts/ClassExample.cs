using UnityEngine;


public class Player
{
    public string name;
    public int score;

    public Player(string playername, int score)
    {
        name = playername;
        this.score = score;
    }

    public void showinfo()
    {
        Debug.Log($"이름 : {name} 점수 : {score}");
    }
}
public class ClassExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player p = new Player("asdf", 30);
        p.showinfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
