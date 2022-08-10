using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Volume : MonoBehaviour
{
    #region Public Variables
    public Slider MusicSlider;
    public Slider SFXSlider;
    public float MusicSliderValue;
    public float SFXSliderValue;
    public AudioMixer audioManager;
    #endregion

    void Start()
    {
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume", MusicSlider.value);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume", SFXSlider.value);
        audioManager.SetFloat("MusicVolume", MusicSlider.value);
        audioManager.SetFloat("SFXVolume", SFXSlider.value);
    }

    public void SetSoundFXlvl(float SFXlvl)
    {
        audioManager.SetFloat("SFXVolume", SFXlvl);
        SFXSliderValue = SFXlvl;
        PlayerPrefs.SetFloat("SFXVolume", SFXSliderValue);
    }

    public void SetSoundMusic(float Musiclvl)
    {
        audioManager.SetFloat("MusicVolume", Musiclvl);
        MusicSliderValue = Musiclvl;
        PlayerPrefs.SetFloat("MusicVolume", MusicSliderValue);
    }
}