using UnityEngine;

public class Background : MonoBehaviour
{

    public float ScrollSpeed;
    Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mat = this.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newoffset = new Vector2(0, ScrollSpeed * Time.deltaTime) + mat.mainTextureOffset;
        mat.mainTextureOffset = newoffset;
        
    }
}
