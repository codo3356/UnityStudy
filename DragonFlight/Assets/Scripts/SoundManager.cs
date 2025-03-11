using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance; // ½Ì±ÛÅæ ¼±¾ð
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
    { // ÃÑ¾Ë ¹ß»ç ¼Ò¸®
        myAudio.PlayOneShot(soundBullet);
    }
    public void SoundDie() // ¸ó½ºÅÍ°¡ Á×À» ¶§ ¼Ò¸®
    {
        myAudio.PlayOneShot(soundDie);
    }
}
