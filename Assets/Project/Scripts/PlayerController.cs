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
    public LayerMask raycastCollisionLayer;
    public RestartLevel restart;
    #endregion

    #region Private Variables
    bool holdControl = false;
    bool lastLeftMouseButtonState = false;
    private Vector2 grappleNormal;
    #endregion

    private void Start()
    {
        holdControl = PlayerPrefs.GetInt("HoldControl?", 0) == 1;
        lastLeftMouseButtonState = Input.GetMouseButton(0);
    }

    private void Update()
    {
        // Detect mouse position
        line.SetPosition(0, this.transform.position);

        //By default, this is controled by tap
        bool pressedHook = Input.GetMouseButtonDown(0);
        if (holdControl)
        {
            pressedHook = Input.GetMouseButton(0) != lastLeftMouseButtonState;
            lastLeftMouseButtonState = Input.GetMouseButton(0);
        }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (pressedHook)
        {
            if (!isGrappling)
            {
                collider = Physics2D.OverlapPoint(mousePos);
                RaycastHit2D hit = Physics2D.Raycast((Vector2)transform.position, (mousePos - (Vector2)transform.position).normalized, 20f, raycastCollisionLayer);
                if (hit)
                {
                    //GRAPPLE
                    targetJoint.enabled = true;
                    targetJoint.target = hit.point;

                    //Set line renderer
                    line.positionCount = 2;
                    line.SetPosition(0, this.transform.position);
                    line.SetPosition(1, hit.point);

                    //Set bool
                    isGrappling = true;

                    //Set normal
                    grappleNormal = hit.normal;
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
        {
            Vector2 repulsiveForce = grappleNormal * targetJoint.maxForce * 0.05f;
            //If grappled horizontally pump up the repulsive force
            //repulsiveForce *= 1f + Vector2.Dot(-grappleNormal, Vector2.right) * 3f;
            rb.AddForce(repulsiveForce * Time.fixedDeltaTime * 90f, ForceMode2D.Force);
        }
    }

    private void OnBecameInvisible()
    {
        if(restart != null)
            restart.Restart();
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(targetJoint.target, targetJoint.target + grappleNormal);
    }
}