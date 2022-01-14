using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    public Canvas CanvasDeath;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "Spikes")
        {
            StartCoroutine(VisibleCanvas());
        }
    }

    IEnumerator VisibleCanvas()
    {
        CanvasDeath.gameObject.SetActive(true);
        yield return new WaitForSecondsRealtime(0.5f);
        int SceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(SceneNumber);
        yield return new WaitForSecondsRealtime(0.1f);
        CanvasDeath.gameObject.SetActive(false);
    }
}