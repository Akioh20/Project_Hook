using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button tapButton;
    public Button holdButton;
    public void Start()
    {
        bool holdControl = PlayerPrefs.GetInt("HoldControl?", 0) == 1;
        if(tapButton != null)
            tapButton.interactable = holdControl;
        if(holdButton != null)
            holdButton.interactable = !holdControl;
    }
    public void PressControlButton(bool isHold)
    {
        PlayerPrefs.SetInt("HoldControl?", isHold ? 1 : 0);
        tapButton.interactable = isHold;
        holdButton.interactable = !isHold;
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }


    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level_3");
    }


    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToControls() {
        SceneManager.LoadScene("Controls");
    }

    public void GoToSound()
    {
        SceneManager.LoadScene("Sound");
    }

    public void LevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
