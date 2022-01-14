using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button tapButton;
    public Button holdButton;
    public Canvas CanvasDeath;
    public Image TransitionImage;

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

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level_4");
    }

    public void LoadLevel5()
    {
        SceneManager.LoadScene("Level_5");
    }
    
    public void LoadLevel6()
    {
        SceneManager.LoadScene("Level_6");
    }
    
    public void LoadLevel7()
    {
        SceneManager.LoadScene("Level_7");
    }
    
    public void LoadLevel8()
    {
        SceneManager.LoadScene("Level_8");
    }
    
    public void LoadLevel9()
    {
        SceneManager.LoadScene("Level_9");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void GoToSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        StartCoroutine(VisibleCanvas());
    }

    IEnumerator VisibleCanvas()
    {
        CanvasDeath.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        int SceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneNumber);
        yield return new WaitForSecondsRealtime(0.1f);
        CanvasDeath.gameObject.SetActive(false);
    }
}
