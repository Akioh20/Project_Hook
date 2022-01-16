using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Canvas WinCanvas;
    private int AmountOfLevels = 9;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "WinCon")
        {
            WinCanvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            if (currentSceneIndex == AmountOfLevels)
            {
                SceneManager.LoadScene("Menu");
            }
            else
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }
}
