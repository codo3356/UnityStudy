using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; // �̱��� ����
    public AudioClip soundDie;
    public AudioClip soundBullet;
    AudioSource myAudio;

    private void Awake()
    {
        if (SoundManager.Instance == null)
        {
            SoundManager.Instance = this;
        }
        else
            Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAudio = GetComponent<AudioSource>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundBullet()
    { // �Ѿ� �߻� �Ҹ�
        myAudio.PlayOneShot(soundBullet);
    }
    public void SoundDie() // ���Ͱ� ���� �� �Ҹ�
    {
        myAudio.PlayOneShot(soundDie);
    }
}
