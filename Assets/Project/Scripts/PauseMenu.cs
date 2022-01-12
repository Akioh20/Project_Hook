using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Canvas CanvasLevel;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartLevel());
    }

    IEnumerator StartLevel()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(0.5f);
        CanvasLevel.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(0.2f);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
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
