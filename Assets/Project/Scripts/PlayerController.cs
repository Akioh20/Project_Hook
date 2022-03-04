using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Public Variables
    [HideInInspector]
    public DistanceJoint2D rope;
    [HideInInspector]
    public SpringJoint2D limitJoint;
    [HideInInspector]
    public Rigidbody2D rb;
    [HideInInspector]
    public LineRenderer line;
    [HideInInspector]
    public TargetJoint2D targetJoint;
    [HideInInspector]
    public Collider2D col;
    SpriteRenderer spr;
    [HideInInspector]
    public bool isGrappling = false;
    [HideInInspector]
    public bool Energized = false;
    [Header ("Collision Layer")]
    public LayerMask raycastCollisionLayer;
    [Header ("Restart Level")]
    public RestartLevel restart;
    [Header("Particles")]
    public ParticleSystem PlayerParticles;
    #endregion

    #region Private Variables
    private Vector2 grappleNormal;
    #endregion

    private void Start()
    {
        spr = this.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Detect mouse position
        line.SetPosition(0, this.transform.position);

        //By default, this is controled by tap
        bool pressedHook = Input.GetKeyDown(KeyCode.Mouse0);
        bool releasedHook = Input.GetKeyUp(KeyCode.Mouse0);

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (pressedHook)
        {
            col = Physics2D.OverlapPoint(mousePos);
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
        else if(releasedHook)
        {
            //Clear grapple joint and line renderer
            targetJoint.enabled = false;
            isGrappling = false;
            line.positionCount = 1;
        }


        Energized = Mathf.Abs(rb.velocity.magnitude) >= 25;

        if (Energized)
        {
            //spr.color = Color.red;
            PlayerParticles.Play();

        }
        else
        {
            //spr.color = new  Color(0.5f, 0f, 1f);
            PlayerParticles.Stop();
        }
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