using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    public DistanceJoint2D rope;
    public SpringJoint2D limitJoint;
    public Rigidbody2D rb;
    public bool isGrappling = false;
    public bool Energized = false;
    public LineRenderer line;
    public Collider2D collider;
    public TargetJoint2D targetJoint;
    #endregion

    #region Private Variables
    #endregion


    private void Start()
    {

    }

    private void Update()
    {
        // Detect mouse position
        // Habría que pensar si poner algun limite en la distancia a la que se puede tirar el gancho
        line.SetPosition(0, this.transform.position);
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (!isGrappling)
            {
                Collider2D collider = Physics2D.OverlapPoint(mousePos);

                if (collider != null)
                {
                    //GRAPPLE
                    targetJoint.enabled = true;
                    targetJoint.target = mousePos;

                    //Set line renderer
                    line.positionCount = 2;
                    line.SetPosition(0, this.transform.position);
                    line.SetPosition(1, mousePos);

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

        if (targetJoint.enabled)
            rb.AddForce(Vector2.down * targetJoint.maxForce * 0.05f, ForceMode2D.Force);

        Energized = Mathf.Abs(rb.velocity.x) >= 15;

        if (Energized)
            gameObject.layer = 6;
        else
            gameObject.layer = 0;
    }
}
