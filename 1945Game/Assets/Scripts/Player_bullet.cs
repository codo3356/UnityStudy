using UnityEngine;

public class Player_bullet : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaY = moveSpeed * Time.deltaTime;
        transform.Translate(new Vector3(0f,deltaY,0f));
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }


}
