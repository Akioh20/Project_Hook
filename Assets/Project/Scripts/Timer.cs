using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    #region Public Variables
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI BestTimeText;

    public Slider sliderTimer;

    public float StarTimer1;
    public float StarTimer2;
    public float StarTimer3;
    #endregion

    #region Private Variables
    private WinCondition WinScript;
    private SaveData dataScript;
    private MenuManager menuScript;
    private float startTime;
    private float bestTime;
    private bool timeStored = false;
    float currentVelocity = 0;
    #endregion

    void Start()
    {
        WinScript = FindObjectOfType<WinCondition>();
        dataScript = FindObjectOfType<SaveData>();
        menuScript = FindObjectOfType<MenuManager>();
        startTime = Time.time;
        bestTime = PlayerPrefs.GetFloat(SceneManager.GetActiveScene().name + "_bestTime", -1f); //1 must be player time
        SetTextTimer(BestTimeText, bestTime, "Best: ");
    }

    void SetTextTimer(TextMeshProUGUI text, float time, string description = "")
    {
        if(time < 0f)
        {
            text.text = description + "None";
            return;
        }
        string seconds = ((int)time).ToString();
        string millis = ((int)(1000f * (time-Mathf.Floor(time)))).ToString();

        text.text = description + seconds + ":" + millis;
    }

    void Update()
    {
        float t = Time.time - startTime;
        if (!WinScript.Won)
        {
            SetTextTimer(TimerText, t, "Time: ");
            ChangeSlider(t);
        }
        else
        {
            if (!timeStored)
            {
                timeStored = true;
                float newTime = t;
                if (t < bestTime || bestTime < 0f)
                {
                    PlayerPrefs.SetFloat(SceneManager.GetActiveScene().name + "_bestTime", t);
                    //Fancy animation
                    SetTextTimer(BestTimeText, t, "Best: ");
                }
                dataScript.SaveStars(newTime);
                menuScript.CountingStars();
                WinScript.WinOrRetry();
            }
        }
    }

    void ChangeSlider(float t)
    {
        float currentTime;
        if (t <= StarTimer1)
        {
            sliderTimer.maxValue = StarTimer1;
            currentTime = Mathf.SmoothDamp(sliderTimer.value, t, ref currentVelocity, Time.deltaTime);
            sliderTimer.value = currentTime;
        }
        else if (t <= StarTimer2)
        {
            sliderTimer.maxValue = StarTimer2;
            currentTime = Mathf.SmoothDamp(sliderTimer.value, t, ref currentVelocity, Time.deltaTime);
            sliderTimer.value = currentTime;
        }
        else if (t <= StarTimer3)
        {
            sliderTimer.maxValue = StarTimer3;
            currentTime = Mathf.SmoothDamp(sliderTimer.value, t, ref currentVelocity, Time.deltaTime);
            sliderTimer.value = currentTime;
        }
    }
}
