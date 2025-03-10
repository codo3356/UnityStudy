using UnityEngine;

public class LoopExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 1; i <= 10; i ++)
        {
            Debug.Log("Conut : " + i);
        }

        int count = 0;
        while(count <= 5)
        {
            Debug.Log("Count : " + count);
            count++;
        }
    }

}
