using UnityEngine;

public class Backgroundrepeat : MonoBehaviour
{

    //스크롤 할 속도 
    public float scrollSpeed = 0.4f;
    private Material thisMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 객체가 생성될 때 이 객체의 컴포넌트 렌더러 메테리얼 가져오기
        thisMaterial = GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newoffset = thisMaterial.mainTextureOffset;
        newoffset.Set(0, newoffset.y + (scrollSpeed * Time.deltaTime));
        thisMaterial.mainTextureOffset = newoffset;
    }
}
