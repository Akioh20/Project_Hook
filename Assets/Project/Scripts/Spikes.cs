using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    #region Public Variables
    public RestartLevel restart;
    #endregion

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && gameObject.tag == "Spikes")
        {
            Time.timeScale = 0f;
            restart.Restart();
        }
    }
}
