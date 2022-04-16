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

    public void LoadLevels(int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene("Level_1");
                break;
            case 2:
                SceneManager.LoadScene("Level_2");
                break;
            case 3:
                SceneManager.LoadScene("Level_3");
                break;
            case 4:
                SceneManager.LoadScene("Level_4");
                break;
            case 5:
                SceneManager.LoadScene("Level_5");
                break;
            case 6:
                SceneManager.LoadScene("Level_6");
                break;
            case 7:
                SceneManager.LoadScene("Level_7");
                break;
            case 8:
                SceneManager.LoadScene("Level_8");
                break;
            case 9:
                SceneManager.LoadScene("Level_9");
                break;
            case 10:
                SceneManager.LoadScene("Level_10");
                break;
            case 11:
                SceneManager.LoadScene("Level_11");
                break;
            case 12:
                SceneManager.LoadScene("Level_12");
                break;
            case 13:
                SceneManager.LoadScene("Level_13");
                break;
            case 14:
                SceneManager.LoadScene("Level_14");
                break;
            case 15:
                SceneManager.LoadScene("Level_15");
                break;
            case 16:
                SceneManager.LoadScene("Level_16");
                break;
            case 17:
                SceneManager.LoadScene("Level_17");
                break;
            case 18:
                SceneManager.LoadScene("Level_18");
                break;
            case 19:
                SceneManager.LoadScene("Level_19");
                break;
            case 20:
                SceneManager.LoadScene("Level_20");
                break;
            case 21:
                SceneManager.LoadScene("Level_2_Tutorial");
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
