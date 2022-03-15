using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    #region Public Variables
    [Header ("Camera")]
    public GameObject cam;
    [Header ("Parallax Value (1 = static)")]
    public float parallaxEffect;
    #endregion

    #region Private Variables
    private float length;
    private float width;
    private float startPosX;
    private float startPosY;
    #endregion

    void Start()
    {
        startPosX = transform.position.x;
        startPosY = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
        width = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float tempX = (cam.transform.position.x * (1 - parallaxEffect));
        float tempY = (cam.transform.position.y * (1 - parallaxEffect));
        float distanceX = (cam.transform.position.x * parallaxEffect);
        float distanceY = (cam.transform.position.y * parallaxEffect);

        transform.position = new Vector2(startPosX + distanceX, startPosY + distanceY);

        if (tempX > startPosX + length) startPosX += length;
        else if (tempX < startPosX - length) startPosX -= length;

        if (tempY > startPosY + width) startPosY += width;
        else if (tempY < startPosY - width) startPosY -= width;
    }
}
