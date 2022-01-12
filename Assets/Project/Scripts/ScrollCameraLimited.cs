using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCameraLimited : MonoBehaviour
{
    [InspectorName("Camera Target")]
    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    [InspectorName ("Smooth Value")]
    public float smoothTime;

    private Vector2 velocity;
    void FixedUpdate()
    {
        //I'll use the SmoothDamp, which is used to follow the character with the camera smoothly

        float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTime);

        transform.position = new Vector3(Mathf.Clamp(posX, minCamPos.x, maxCamPos.x), Mathf.Clamp(posY, minCamPos.y, maxCamPos.y), transform.position.z);
    }
}
