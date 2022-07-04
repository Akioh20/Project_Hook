using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    #region Public Variables
    public float speed;
    public float deathTime;
    public ParticleSystem hitParticle;
    #endregion

    #region Private Variables
    private Rigidbody2D rb;
    private AudioSource cannonAudio;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine("Shooted");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            cannonAudio = hitParticle.GetComponent<AudioSource>();
            cannonAudio.pitch = Random.Range(0.7f, 1.3f);
            cannonAudio.volume = Random.Range(0.4f, 0.7f);
            Instantiate(hitParticle, new Vector3(gameObject.transform.position.x,
                                                 gameObject.transform.position.y,
                                                 gameObject.transform.position.z),
                                                 Quaternion.identity);
        }
        Destroy(gameObject);
    }

    IEnumerator Shooted()
    {
        rb.velocity = transform.right * speed;
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }
}
