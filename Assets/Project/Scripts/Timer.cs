using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    #region Public Variables
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI BestTimeText;
    #endregion

    #region Private Variables
    private WinCondition WinScript;
    private SaveData dataScript;
    private MenuManager menuScript;
    private float startTime;
    private float bestTime;
    private bool timeStored = false;
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
}
