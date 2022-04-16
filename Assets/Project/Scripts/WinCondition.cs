using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    public Canvas WinCanvas;
    public GameObject Range;
    //public SpringJoint2D joint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "WinCon")
        {
            WinCanvas.gameObject.SetActive(true);
            Time.timeScale = 0f;
            Range.gameObject.SetActive(false);
            //joint.gameObject.SetActive(true);
        }
    }

    public void NextLevel()
    {
        int nextSceneIndex = (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
