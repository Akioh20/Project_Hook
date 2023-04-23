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

    public RectTransform loadingImage;
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
                StartCoroutine("LoadLevel", 1);
                break;
            case 2.0f:
                StartCoroutine("LoadLevel", 2);
                break;
            case 3.0f:
                StartCoroutine("LoadLevel", 3);
                break;
            case 4.0f:
                StartCoroutine("LoadLevel", 4);
                break;
            case 5.0f:
                StartCoroutine("LoadLevel", 5);
                break;
            case 6.0f:
                StartCoroutine("LoadLevel", 6);
                break;
            case 7.0f:
                StartCoroutine("LoadLevel", 7);
                break;
            case 8.0f:
                StartCoroutine("LoadLevel", 8);
                break;
            case 9.0f:
                StartCoroutine("LoadLevel", 9);
                break;
            case 10.0f:
                StartCoroutine("LoadLevel", 10);
                break;
            case 11.0f:
                StartCoroutine("LoadLevel", 11);
                break;
            case 12.0f:
                StartCoroutine("LoadLevel", 12);
                break;
            case 13.0f:
                StartCoroutine("LoadLevel", 13);
                break;
            case 14.0f:
                StartCoroutine("LoadLevel", 14);
                break;
            case 15.0f:
                StartCoroutine("LoadLevel", 15);
                break;
            case 16.0f:
                StartCoroutine("LoadLevel", 16);
                break;
            case 17.0f:
                StartCoroutine("LoadLevel", 17);
                break;
            case 18.0f:
                StartCoroutine("LoadLevel", 18);
                break;
            case 19.0f:
                StartCoroutine("LoadLevel", 19);
                break;
            case 20.0f:
                StartCoroutine("LoadLevel", 20);
                break;
            case 21.0f:
                StartCoroutine("LoadLevel", 21);
                break;
            case 22.0f:
                StartCoroutine("LoadLevel", 22);
                break;
            case 23.0f:
                StartCoroutine("LoadLevel", 23);
                break;
            case 24.0f:
                StartCoroutine("LoadLevel", 24);
                break;
            case 25.0f:
                StartCoroutine("LoadLevel", 25);
                break;
            case 26.0f:
                StartCoroutine("LoadLevel", 26);
                break;
            case 27.0f:
                StartCoroutine("LoadLevel", 27);
                break;
            case 28.0f:
                StartCoroutine("LoadLevel", 28);
                break;
            case 29.0f:
                StartCoroutine("LoadLevel", 29);
                break;
            case 30.0f:
                StartCoroutine("LoadLevel", 30);
                break;
            case 31.0f:
                StartCoroutine("LoadLevel", 31);
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

    IEnumerator LoadLevel(int index)
    {
        loadingImage.gameObject.SetActive(true);
        //SCALE IMAGE TO 25
        float value = 0f;
        float duration = 0.5f;
        while (value < duration)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, duration);
            loadingImage.localScale = Vector2.one * 25f * (Mathf.Sqrt(value / duration));
            yield return null;
        }
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("Level_" + index);
    }

}