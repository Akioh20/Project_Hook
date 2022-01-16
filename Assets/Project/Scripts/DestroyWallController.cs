using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWallController : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
