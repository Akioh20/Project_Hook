using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    SpringJoint2D rope;
    [HideInInspector] public bool checker = true;
    //[HideInInspector] public bool OnReach;
    #endregion

    private void Start()
    {
        gameObject.GetComponent<LineRenderer>();
        gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Detect mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Shot rope on mouse position
        if (Input.GetMouseButtonDown(0) && checker == true/* && OnReach == true*/)
        {
            rope = gameObject.AddComponent<SpringJoint2D>();
            rope.enableCollision = true;
            rope.connectedAnchor = mousePos;
            rope.distance = 5;
            //rope.frequency = 10;
            //rope.dampingRatio = 1;
            
            checker = false;
        }

        

        // Destroy rope
        else if (Input.GetMouseButtonDown(0))
        {
            DestroyImmediate(rope);

            checker = true;
        }
    }
}
