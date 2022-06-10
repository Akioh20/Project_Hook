using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinCondition : MonoBehaviour
{
    #region Public Variables
    // Call to other scripts
    public Canvas WinCanvas;
    public Canvas RetryCanvas;
    public GameObject Range;

    // Variables
    [HideInInspector]
    public bool Won = false;
    [Header ("Stars Condition")]
    public int neededStars;
    #endregion

    #region Private Variables
    private GameObject player;
    private MenuManager menuManager;
    private UnlockLevels unlockScript;
    #endregion

    private void Start()
    {
        // Assign variables to their correspondent scripts
        menuManager = FindObjectOfType<MenuManager>();
        unlockScript = FindObjectOfType<UnlockLevels>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "WinCon")
        {
            // Change the contidion of "Won" to true, as if we collide with the finish line, would mean that we have already won
            Won = true;
            player = collision.gameObject;
            player.GetComponent<PlayerController>().EnterPortal();
            Range.gameObject.SetActive(false);
            this.GetComponent<CapsuleCollider2D>().enabled = false;
            StartCoroutine("FadePlayer");
        }
    }

    public void WinOrRetry()
    {
        if (menuManager.totalStars >= neededStars)
        {
            WinCanvas.gameObject.SetActive(true);
        }
        else if (menuManager.totalStars <= neededStars)
        {
            RetryCanvas.gameObject.SetActive(true);
        }
    }

    public void NextLevel()
    {
        PlayerPrefs.SetInt("Lock" + (SceneManager.GetActiveScene().buildIndex + 1), 1);
        int nextSceneIndex = (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }

    IEnumerator FadePlayer()
    {
        float value = 0f;
        while(value < 1f)
        {
            value += Time.deltaTime;
            player.GetComponent<Rigidbody2D>().AddTorque(1f, ForceMode2D.Force);
            yield return null;
        }

        value = 0f;
        float maxLerpTime = 1f;
        Vector3 startingScale = player.transform.localScale;
        while(value < maxLerpTime){
            value = Mathf.Min(value + Time.deltaTime, maxLerpTime);
            player.transform.localScale = startingScale * (1f - value);
            yield return null;
        }
        player.transform.localScale = Vector3.zero;
        Time.timeScale = 0f;
        //Part�cules!!
    }
}
