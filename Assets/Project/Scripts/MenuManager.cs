using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class MenuManager : MonoBehaviour
{
    #region Public Variables
    [HideInInspector]
    public RestartLevel restart;
    public TextMeshProUGUI StarsText = null;
    [HideInInspector]
    public int totalStars = 0;
    public TMPro.TMP_Dropdown resolutionDropdown;
    #endregion

    #region Private Variables
    private SaveData dataScript;
    private Resolution[] resolutions;
    private int totalLevels = 30; // --> Change this if I add levels!!
    #endregion

    private void Start()
    {
        dataScript = FindObjectOfType<SaveData>();
        CountingStars();
        SetTextStars(StarsText, totalStars, "Stars: ");

        int currentResolutionIndex = 0;
        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " " + resolutions[i].refreshRate + "Hz";
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }
    public void LoadLevels(float level)
    {
        switch (level)
        {
            case 1.0f:
                SceneManager.LoadScene("Level_1");
                break;
            case 2.0f:
                SceneManager.LoadScene("Level_2");
                break;
            case 3.0f:
                SceneManager.LoadScene("Level_3");
                break;
            case 4.0f:
                SceneManager.LoadScene("Level_4");
                break;
            case 5.0f:
                SceneManager.LoadScene("Level_5");
                break;
            case 6.0f:
                SceneManager.LoadScene("Level_6");
                break;
            case 7.0f:
                SceneManager.LoadScene("Level_7");
                break;
            case 8.0f:
                SceneManager.LoadScene("Level_8");
                break;
            case 9.0f:
                SceneManager.LoadScene("Level_9");
                break;
            case 10.0f:
                SceneManager.LoadScene("Level_10");
                break;
            case 11.0f:
                SceneManager.LoadScene("Level_11");
                break;
            case 12.0f:
                SceneManager.LoadScene("Level_12");
                break;
            case 13.0f:
                SceneManager.LoadScene("Level_13");
                break;
            case 14.0f:
                SceneManager.LoadScene("Level_14");
                break;
            case 15.0f:
                SceneManager.LoadScene("Level_15");
                break;
            case 16.0f:
                SceneManager.LoadScene("Level_16");
                break;
            case 17.0f:
                SceneManager.LoadScene("Level_17");
                break;
            case 18.0f:
                SceneManager.LoadScene("Level_18");
                break;
            case 19.0f:
                SceneManager.LoadScene("Level_19");
                break;
            case 20.0f:
                SceneManager.LoadScene("Level_20");
                break;
            case 21.0f:
                SceneManager.LoadScene("Level_21");
                break;
            case 22.0f:
                SceneManager.LoadScene("Level_22");
                break;
            case 23.0f:
                SceneManager.LoadScene("Level_23");
                break;
            case 24.0f:
                SceneManager.LoadScene("Level_24");
                break;
            case 25.0f:
                SceneManager.LoadScene("Level_25");
                break;
            case 26.0f:
                SceneManager.LoadScene("Level_26");
                break;
            case 27.0f:
                SceneManager.LoadScene("Level_27");
                break;
            case 28.0f:
                SceneManager.LoadScene("Level_28");
                break;
            case 29.0f:
                SceneManager.LoadScene("Level_29");
                break;
            case 30.0f:
                SceneManager.LoadScene("Level_30");
                break;
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
        restart.Restart();
    }

    public void CountingStars()
    {
        totalStars = 0;
        for (int i = 1; i <= totalLevels; i++)
        {
            int temp = dataScript.GetLevelStars(i);
            totalStars += temp;
        }
    }

    private void SetTextStars(TextMeshProUGUI text, int stars, string description = "")
    {
        text.text = description + stars;
    }

    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Menu");
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void FullScreen(bool isMondongo)
    {
        Screen.fullScreen = isMondongo;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}