using UnityEngine;

public class Backgroundrepeat : MonoBehaviour
{

    //��ũ�� �� �ӵ� 
    public float scrollSpeed = 0.4f;
    private Material thisMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ��ü�� ������ �� �� ��ü�� ������Ʈ ������ ���׸��� ��������
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
