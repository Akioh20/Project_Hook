using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public RestartLevel restart;

    public void Start()
    {

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

    public void Restart()
    {
        restart.Restart();
    }
}
