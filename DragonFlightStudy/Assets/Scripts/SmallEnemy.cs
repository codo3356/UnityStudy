using UnityEngine;

public class SmallEnemy : MonoBehaviour
{
    public int point;
    public int MoveSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -MoveSpeed * Time.deltaTime, 0));
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
