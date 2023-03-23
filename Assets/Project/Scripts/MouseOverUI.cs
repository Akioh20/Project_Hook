using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseOverUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler//, IPointerEnterHandler
{
    private Rigidbody2D rb2d;
    private Vector2 mouseFirstPos;
    private Vector2 mouseLastPos;
    private Vector2 mouseFinalPos;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        mouseFirstPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mouseLastPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mouseFinalPos = mouseLastPos - mouseFirstPos;

        mouseFinalPos *= 1000;

        rb2d.AddForce(mouseFinalPos);
    }
}