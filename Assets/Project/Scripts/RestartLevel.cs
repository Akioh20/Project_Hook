using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    #region Public Variables
    public Canvas CanvasDeath;
    public RectTransform deathImage;
    #endregion

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void Restart()
    {
        StartCoroutine(VisibleCanvas());
    }

    IEnumerator VisibleCanvas()
    {
        CanvasDeath.gameObject.SetActive(true);
        //SCALE IMAGE TO 25
        float value = 0f;
        float duration = 0.5f;
        while (value < duration)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, duration);
            deathImage.localScale = Vector2.one * 25f * (Mathf.Sqrt(value / duration));
            yield return null;
        }
        yield return new WaitForSecondsRealtime(0.5f);
        int SceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneNumber);
        //Get a ref to the pause menu
        Time.timeScale = 1f;
    }
}