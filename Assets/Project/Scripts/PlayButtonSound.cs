using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonSound : MonoBehaviour
{
    public AudioSource clickSound;
    public AudioSource hoverSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClickSound()
    {
        clickSound.Play();
    }
    public void PlayHoverSound()
    {
        if(!hoverSound.isPlaying)
            hoverSound.Play();
    }
}