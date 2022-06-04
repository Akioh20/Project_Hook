using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    private static DontDestroy instance;

    public AudioSource music0;
    public AudioSource music1;
    public AudioSource music2;

    private int musicCounter = 0;
    private bool otherPlaying = false;

    private void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    private void Update()
    {
        /*if (!music1.isPlaying && otherPlaying == false)
        {
            music1.Play();
            Invoke("HasFinished1", music1.clip.length - 1);
        }
        else if (!music2.isPlaying && otherPlaying)
        {
            music2.Play();
            Invoke("HasFinished2", music2.clip.length - 1);
        }*/

        switch (musicCounter)
        {
            case 0:
                if (!music0.isPlaying)
                {
                    music0.Play();
                    Invoke("HasFinished", music0.clip.length - 0.5f);
                }
                break;
            case 1:
                if (!music1.isPlaying)
                {
                    music1.Play();
                    Invoke("HasFinished", music1.clip.length - 0.5f);
                }
                break;
            default:
                break;
        }
    }
    void HasFinished()
    {
        musicCounter += 1;

        if (musicCounter == 2)
        {
            musicCounter = 0;
        }
    }
}