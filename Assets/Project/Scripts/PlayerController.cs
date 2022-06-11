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
    private AudioSource HitSound;
    #endregion

    Vector2 offset;
    Transform hitObj;

    public Transform hand;

    public GameObject brokenArm;
    public PointToMouse armAim;

    private void Start()
    {
        spr = this.GetComponent<SpriteRenderer>();
        HitSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Detect mouse position
        line.SetPosition(0, hand.transform.position);

        //By default, this is controled by tap
        bool pressedHook = Input.GetKeyDown(KeyCode.Mouse0);
        bool releasedHook = Input.GetKeyUp(KeyCode.Mouse0);

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (pressedHook)
        {
            col = Physics2D.OverlapPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)hand.transform.position, (mousePos - (Vector2)hand.transform.position).normalized, 20f, raycastCollisionLayer);
            if (hit)
            {
                //GRAPPLE
                targetJoint.enabled = true;
                targetJoint.target = hit.point;
                //Play the hook sound whenever we hit something valid
                PlaySoundHook();

                if(hit.collider.gameObject.GetComponent<Rigidbody2D>())
                    hit.collider.gameObject.GetComponent<Rigidbody2D>().WakeUp();

                //Set line renderer
                line.positionCount = 2;
                line.SetPosition(0, this.transform.position);
                line.SetPosition(1, hit.point);
                //Store the hi element and the offset
                hitObj = hit.transform;
                offset = hit.point - (Vector2)hit.transform.position;
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
            PlayerParticles.Play();
        }
        else
        {
            PlayerParticles.Stop();
        }
    }

    private void FixedUpdate()
    {
        if (targetJoint.enabled)
        {
            Vector2 repulsiveForce = grappleNormal * targetJoint.maxForce * 0.05f;
            rb.AddForce(repulsiveForce * Time.fixedDeltaTime * 90f, ForceMode2D.Force);
            line.SetPosition(1, (Vector2)hitObj.transform.position + offset);
            targetJoint.target = (Vector2)hitObj.transform.position + offset;
        }
    }

    public void EnterPortal()
    {
        rb.gravityScale = 0f;
        rb.constraints = 0;
        armAim.enabled = false;
        Destroy(brokenArm.GetComponent<HingeJoint2D>());
        Destroy(brokenArm.GetComponent<Rigidbody2D>());
        rb.velocity = Vector2.zero;
    }

    private void OnBecameInvisible()
    {
        if(restart != null)
            restart.Restart();
    }

    private void PlaySoundHook()
    {
        HitSound.pitch = Random.Range(0.8f, 1.3f);
        HitSound.volume = Random.Range(0.7f, 1.1f);
        HitSound.Play();
    }
}