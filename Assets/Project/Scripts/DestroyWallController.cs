using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallController : MonoBehaviour
{
    PlayerController player;
    public Collider2D col;
    public void Awake()
    {
        player = FindObjectOfType<PlayerController>();
    }
    public void Update()
    {
        if(col.isTrigger != player.Energized)
        {
            col.isTrigger = player.Energized;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>() != null)
        {
            Destroy(gameObject);
            Camera.main.transform.parent.GetComponent<ScrollCameraLimited>().ShakeMagnitude = 3f;
        }
    }
}
