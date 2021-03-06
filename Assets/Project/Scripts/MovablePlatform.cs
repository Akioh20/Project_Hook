using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePlatform : MonoBehaviour
{
    #region Public Variables
    [Header("Moving towards to")]
    public Transform target;
    [Header ("Parameters")]
    public float speed;
    //public int stopTime;
    public LineRenderer line;
    #endregion

    #region Private Variables
    private Vector3 start, end;
    #endregion

    void Start()
    {
        if (target != null)
        {
            target.parent = null;
            start = transform.position;
            end = target.position;
        }
        line.SetPosition(0, this.transform.position);
        line.SetPosition(1, target.transform.position);
    }

    void FixedUpdate()
    {
        if (target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }

        if (transform.position == target.position)
        {
            target.position = (target.position == start) ? end : start;
        }
    }
}