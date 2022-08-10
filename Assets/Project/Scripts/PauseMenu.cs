using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    #region Public Variables
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject soundMenuUI;
    #endregion

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused && !soundMenuUI.activeInHierarchy)
            {
                Resume();
            }
            else if (GameIsPaused && soundMenuUI.activeInHierarchy)
            {
                soundMenuUI.SetActive(false);
                pauseMenuUI.SetActive(true);
            }
            else if (!GameIsPaused)
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
