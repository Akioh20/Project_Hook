using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    #region Public Variables
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Canvas CanvasLevel;
    public Image ImageLevel;
    #endregion

    void Start()
    {
        StartCoroutine(StartLevel());
    }

    IEnumerator StartLevel()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(0.8f);
        CanvasLevel.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(0.3f);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
