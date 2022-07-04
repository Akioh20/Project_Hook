using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    #region Public Variables
    public AudioSource music0;
    public AudioSource music1;
    public AudioSource music2;
    #endregion

    #region Private Variables
    private static DontDestroy instance;
    private int musicCounter = 0;
    private int numberOfSongs = 3;
    #endregion

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
        switch (musicCounter)
        {
            case 0:
                if (!music0.isPlaying)
                {
                    music0.Play();
                    Invoke(nameof(HasFinished), music0.clip.length - 0.3f);
                }
                break;
            case 1:
                if (!music1.isPlaying)
                {
                    music1.Play();
                    Invoke(nameof(HasFinished), music1.clip.length - 0.3f);
                }
                break;
            case 2:
                if (!music2.isPlaying)
                {
                    music2.Play();
                    Invoke(nameof(HasFinished), music2.clip.length -0.3f);
                }
                break;
            default:
                break;
        }
    }
    void HasFinished()
    {
        musicCounter += 1;

        music0.Stop();
        music1.Stop();
        music2.Stop();

        if (musicCounter == numberOfSongs)
        {
            musicCounter = 0;
        }
    }
}