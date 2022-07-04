using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    #region Private Variables
    private RestartLevel restart;
    #endregion

    private void Start()
    {
        restart = FindObjectOfType<RestartLevel>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "Spikes" || 
            collision.gameObject.CompareTag("Player") && gameObject.tag == "CannonBall")
        {
            Time.timeScale = 0f;
            restart.Restart();
        }
    }
}
