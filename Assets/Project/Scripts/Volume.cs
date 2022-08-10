using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Volume : MonoBehaviour
{
    #region Public Variables
    [Header("Assign Audio Manager")]
    public AudioMixer audioManager;
    [Header ("Sliders")]
    public Slider MasterSlider;
    public Slider MusicSlider;
    public Slider SFXSlider;
    public TextMeshProUGUI MasterVolumeText;
    public TextMeshProUGUI MusicVolumeText;
    public TextMeshProUGUI SFXVolumeText;
    #endregion

    #region Private Variables
    private float MasterSliderValue;
    private float MusicSliderValue;
    private float SFXSliderValue;
    #endregion

    void Start()
    {
        MasterSlider.value = PlayerPrefs.GetFloat("MasterVolume", MasterSlider.value);
        MusicSlider.value = PlayerPrefs.GetFloat("MusicVolume", MusicSlider.value);
        SFXSlider.value = PlayerPrefs.GetFloat("SFXVolume", SFXSlider.value);
        audioManager.SetFloat("MasterVolume", MasterSlider.value);
        audioManager.SetFloat("MusicVolume", MusicSlider.value);
        audioManager.SetFloat("SFXVolume", SFXSlider.value);
        MasterVolumeText.text = (MasterSlider.value * 2 + 100).ToString() + "%";
        MusicVolumeText.text = (MusicSlider.value * 2 + 100).ToString() + "%";
        SFXVolumeText.text = (SFXSlider.value * 2 + 100).ToString() + "%";
    }

    public void SetMasterVolume(float Masterlvl)
    {
        audioManager.SetFloat("MasterVolume", Masterlvl);
        MasterSliderValue = Masterlvl;
        PlayerPrefs.SetFloat("MasterVolume", MasterSliderValue);
        MasterVolumeText.text = (MasterSlider.value * 2 + 100).ToString() + "%";
    }

    public void SetSoundMusic(float Musiclvl)
    {
        audioManager.SetFloat("MusicVolume", Musiclvl);
        MusicSliderValue = Musiclvl;
        PlayerPrefs.SetFloat("MusicVolume", MusicSliderValue);
        MusicVolumeText.text = (MusicSlider.value * 2 + 100).ToString() + "%";
    }

    public void SetSoundFXlvl(float SFXlvl)
    {
        audioManager.SetFloat("SFXVolume", SFXlvl);
        SFXSliderValue = SFXlvl;
        PlayerPrefs.SetFloat("SFXVolume", SFXSliderValue);
        SFXVolumeText.text = (SFXSlider.value * 2 + 100).ToString() + "%";
    }
}