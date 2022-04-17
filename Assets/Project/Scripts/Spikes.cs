using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public RestartLevel restart;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "Spikes")
        {
            Time.timeScale = 0f;
            restart.Restart();
            //StartCoroutine(Restart());
        }
    }

    /*IEnumerator Restart()
    {
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(0.5f);
        restart.Restart();
    }*/
}
