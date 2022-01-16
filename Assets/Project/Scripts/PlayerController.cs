using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    public DistanceJoint2D rope;
    public SpringJoint2D limitJoint;
    public Rigidbody2D rb;
    public LineRenderer line;
    public Collider2D collider;
    public TargetJoint2D targetJoint;
    [HideInInspector]
    public SpriteRenderer spr;

    public bool isGrappling = false;
    public bool Energized = false;
    //public int layerMask = 8;
    #endregion

    #region Private Variables
    bool holdControl = false;
    bool lastLeftMouseButtonState = false;
    #endregion

    private void Start()
    {
        holdControl = PlayerPrefs.GetInt("HoldControl?", 0) == 1;
        lastLeftMouseButtonState = Input.GetMouseButton(0);
    }

    private void Update()
    {
        // Detect mouse position
        // Habr�a que pensar si poner algun limite en la distancia a la que se puede tirar el gancho
        line.SetPosition(0, this.transform.position);

        //By default, this is controled by tap
        bool pressedHook = Input.GetMouseButtonDown(0);
        if (holdControl)
        {
            pressedHook = Input.GetMouseButton(0) != lastLeftMouseButtonState;
            lastLeftMouseButtonState = Input.GetMouseButton(0);
        }


        if (pressedHook)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (!isGrappling)
            {
                collider = Physics2D.OverlapPoint(mousePos);
                //RaycastHit2D hit = Physics2D.Raycast(transform.position, mousePos, 20.0f, layerMask);

                if (collider != null && Vector2.Distance(new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y), mousePos) <= 15/*hit.point !=null*/)
                {
                    //GRAPPLE
                    targetJoint.enabled = true;
                    targetJoint.target = mousePos;  //hit.point

                    //Set line renderer
                    line.positionCount = 2;
                    line.SetPosition(0, this.transform.position);
                    line.SetPosition(1, mousePos);  //hit.point

                    //Set bool
                    isGrappling = true;
                }
            }
            //RELEASE
            else
            {
                //Clear grapple joint and line renderer
                targetJoint.enabled = false;
                isGrappling = false;
                line.positionCount = 1;
            }
        }


        Energized = Mathf.Abs(rb.velocity.x) >= 25;

        /*if (Energized)
        {
            gameObject.layer = 7;
            spr.color = Color.red;
        }
        else
        {
            gameObject.layer = 8;
            spr.color = Color.red;
        }*/
    }

    private void FixedUpdate()
    {
        if (targetJoint.enabled)
            rb.AddForce(Vector2.down * targetJoint.maxForce * 0.05f * Time.fixedDeltaTime * 90f, ForceMode2D.Force);
    }

    private void OnBecameInvisible()
    {
        RestartLevel.Instance.Restart();
    }
}