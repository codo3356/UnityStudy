using UnityEngine;

public class FunctionExample : MonoBehaviour
{

    void sayHello()
    {
        Debug.Log("Hello, Unity!");
    }

    int AddNumbers(int a, int b)
    {
        return a + b;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sayHello();
        Debug.Log("Sum : " + AddNumbers(4, 6));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
