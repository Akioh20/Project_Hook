using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI BestTimeText;
    WinCondition WinScript;
    private float startTime;

    float bestTime;
    bool timeStored = false;
    // Start is called before the first frame update
    void Start()
    {
        WinScript = FindObjectOfType<WinCondition>();
        startTime = Time.time;
        //Store level data
        //PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "_stars", 3);
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

    // Update is called once per frame
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
            }
        }
    }
}
