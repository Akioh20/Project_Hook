using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{
    #region Public Variables
    public Transform firePoint;
    public GameObject bullet;
    public float timeBullet;
    #endregion

    #region Private Variables
    private AudioSource cannonSound;
    #endregion

    void Start()
    {
        cannonSound = GetComponent<AudioSource>();
        StartCoroutine("WaitForStart");
    }

    IEnumerator WaitForStart()
    {
        yield return new WaitForSeconds(timeBullet);
        StartCoroutine("Shoot");
    }

    IEnumerator Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        cannonSound.pitch = Random.Range(0.8f, 1.3f);
        cannonSound.volume = Random.Range(0.3f, 0.4f);
        cannonSound.Play();
        yield return new WaitForSeconds(timeBullet);
        StartCoroutine("Shoot");
    }
}
