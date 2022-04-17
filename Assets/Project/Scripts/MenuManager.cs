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
            case 0.1f:
                SceneManager.LoadScene("Level_2_Tutorial");
                break;
            case 0.2f:
                SceneManager.LoadScene("Level_8_Tutorial");
                break;
            case 0.3f:
                SceneManager.LoadScene("Level_10_Tutorial");
                break;
            case 0.4f:
                SceneManager.LoadScene("Level_13_Tutorial");
                break;
            case 0.5f:
                SceneManager.LoadScene("Level_16_Tutorial");
                break;
            default:
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
}
