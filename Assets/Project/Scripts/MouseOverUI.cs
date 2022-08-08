using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverUI : MonoBehaviour, IPointerEnterHandler
{
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Debug.Log("Start");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Entered");
        rb2d.AddForce(new Vector2(Random.Range(-5000f, 5000f), Random.Range(-5000f, 5000f)));
    }
}