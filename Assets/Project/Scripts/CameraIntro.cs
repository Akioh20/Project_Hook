using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraIntro : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject CanvasLevel;
    public Image Fade;
    [Header("Position")]
    public Vector3 targetPosition;
    Vector3 startPosition;
    [Header("Size")]
    public float targetOrthoSize;
    float startOrthoSize;
    [Header("Camera")]
    public float waitTime = 3;
    public float lerpTime = 1;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = cam.transform.position;
        startOrthoSize = cam.orthographicSize;
        StartCoroutine(Intro());
    }

    IEnumerator Intro()
    {
        Time.timeScale = 0f;
        float value = 0f;
        bool start = false;
        cam.transform.position = targetPosition;
        while (value < 1f && !start)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, 1f);
            cam.orthographicSize = startOrthoSize + value * (targetOrthoSize - startOrthoSize);
            start = Input.anyKeyDown;
            Fade.color = new Color(0f, 0f, 0f, 1f-value);
            yield return null;
        }
        value = 0f;
        while (value < waitTime && !start){
            value = Mathf.Min(value + Time.unscaledDeltaTime, waitTime);
            start = Input.anyKeyDown;
            yield return null;
        }
        value = 0f;
        while (value < lerpTime && !start)
        {
            value = Mathf.Min(value + Time.unscaledDeltaTime, lerpTime);
            float t = value / lerpTime;
            t = t * t * (3f - 2f * t); // Smoothstep formula
            start = Input.anyKeyDown;
            cam.transform.position = Vector3.Lerp(targetPosition, startPosition, t);
            cam.orthographicSize = Mathf.Lerp(targetOrthoSize, startOrthoSize, t);
            yield return null;
        }
        Fade.color = Color.clear;
        cam.transform.position = startPosition;
        cam.orthographicSize = startOrthoSize;
        CanvasLevel.gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(0.3f);
        Time.timeScale = 1f;
    }
}
