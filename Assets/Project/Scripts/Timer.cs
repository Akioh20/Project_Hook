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

    [Header ("Slider Components")]
    public Slider sliderTimer;
    public Image fillSlider;

    [Header("Star Image Slider")]
    public GameObject starImage1;
    public GameObject starImage2;
    public GameObject starImage3;

    public GameObject greyStarImage1;
    public GameObject greyStarImage2;
    public GameObject greyStarImage3;
    #endregion

    #region Private Variables
    private WinCondition WinScript;
    private SaveData dataScript;
    private MenuManager menuScript;
    private float startTime;
    private float bestTime;
    private bool timeStored = false;

    float currentVelocity = 0;

    private bool star1executed = false;
    private bool star2executed = false;
    private bool star3executed = false;
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

        sliderTimer.maxValue = dataScript.OneStarTime;
        currentTime = Mathf.SmoothDamp(sliderTimer.value, t, ref currentVelocity, Time.deltaTime);
        sliderTimer.value = currentTime;

        if (t >= dataScript.ThreeStarTime && !star1executed)
        {
            starImage1.SetActive(false);
            greyStarImage1.SetActive(true);
            fillSlider.color = Color.yellow;
            star1executed = true;
        }
        if (t >= dataScript.TwoStarTime && !star2executed)
        {
            starImage2.SetActive(false);
            greyStarImage2.SetActive(true);
            fillSlider.color = Color.red;
            star2executed = true;
        }
        if (t >= dataScript.OneStarTime && !star3executed)
        {
            starImage3.SetActive(false);
            greyStarImage3.SetActive(true);
            fillSlider.color = Color.grey;
            star3executed = true;
        }
    }
}
