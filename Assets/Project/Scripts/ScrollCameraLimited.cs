using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollCameraLimited : MonoBehaviour
{
    #region Public Variables
    [InspectorName("Camera Target")]
    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    [InspectorName("Smooth Value")]
    public float smoothTime;
    public float ShakeMagnitude = 0.0f;
    #endregion

    #region Private Variables
    private Vector2 velocity;
    #endregion

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTime);

        Vector2 shake = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized * ShakeMagnitude;

        if (ShakeMagnitude > 0.05f)
            ShakeMagnitude = Mathf.Lerp(ShakeMagnitude, 0f, Time.fixedDeltaTime * 10f);
        else
            ShakeMagnitude = 0.0f;

        transform.position = new Vector3(Mathf.Clamp(posX + shake.x, minCamPos.x, maxCamPos.x), Mathf.Clamp(posY + shake.y, minCamPos.y, maxCamPos.y), transform.position.z);
    }
}