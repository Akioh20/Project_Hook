using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    #region Public Variables
    public Slider slider;
    public float sliderValue;
    #endregion

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("audioVolume", slider.value);
        AudioListener.volume = slider.value;
    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("audioVolume", sliderValue);
        AudioListener.volume = slider.value;
    }
}