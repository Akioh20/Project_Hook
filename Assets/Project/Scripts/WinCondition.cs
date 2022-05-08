using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    #region Public Variables
    public Canvas WinCanvas;
    public GameObject Range;
    public int totalStars;
    public bool Won = false;
    #endregion

    #region Private Variables
    private GameObject player;
    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "WinCon")
        {
            Won = true;
            player = collision.gameObject;
            player.GetComponent<PlayerController>().EnterPortal();
            WinCanvas.gameObject.SetActive(true);
            Range.gameObject.SetActive(false);
            this.GetComponent<CapsuleCollider2D>().enabled = false;
            StartCoroutine("FadePlayer");
        }
    }

    public void NextLevel()
    {
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
