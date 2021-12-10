using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    DistanceJoint2D rope;
    [HideInInspector] public bool checker = true;
    #endregion

    //private bool Collider;

    private void Start()
    {
        gameObject.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Detect mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        /*
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics2D.OverlapCircle(mousePos, 0.05f) == GetComponent<BoxCollider2D>())
            {
                Collider = true;
                Debug.Log(":D");
            }
        }
        */

        // Shot rope on mouse position
        if (Input.GetMouseButtonDown(0) && checker == true && Vector2.Distance(new Vector2(mousePos.x, mousePos.y), new Vector2(gameObject.transform.position.x, gameObject.transform.position.y)) <= 10/* && Collider == true*/)
        {
            rope = gameObject.AddComponent<DistanceJoint2D>();
            rope.enableCollision = true;
            rope.connectedAnchor = mousePos;
            //rope.distance = Vector2.Distance(new Vector2(mousePos.x, mousePos.y), new Vector2(gameObject.transform.position.x, gameObject.transform.position.y));

            checker = false;
        }
        // Destroy rope
        else if (Input.GetMouseButtonDown(0))
        {
            Destroy(rope);

            checker = true;

            //Collider = false;
        }


    }
}
