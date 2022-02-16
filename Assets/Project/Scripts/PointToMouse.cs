using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToMouse : MonoBehaviour
{
    [SerializeField]
    Transform target;
    Camera mainCamera;
    private void Awake()
    {
        if (target == null)
            target = transform;

        if (mainCamera == null)
            mainCamera = Camera.main;
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        Vector2 lookAtDirection = mousePos - target.position;
        target.right = lookAtDirection;
    }
}
