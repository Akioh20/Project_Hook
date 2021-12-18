using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCamera : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        this.transform.position = new Vector3(player.transform.position.x + 7.99f, this.transform.position.y, this.transform.position.z);
    }
}