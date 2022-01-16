using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTime : MonoBehaviour
{
    [Header("Time to Destroy")]
    public float seconds;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, seconds);
    }
}
