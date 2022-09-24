using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag_Drop : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    public static GameObject itemDragging;
    [Header("Posiciones")]
    Vector3 startPosition;
    Transform startParent;
    Transform dragParent;

    private void Start()
    {
        dragParent = GameObject.FindGameObjectWithTag("DragParent").transform;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        itemDragging = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        transform.SetParent(dragParent);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Debug.Log("Ondrag");
        transform.position = Input.mousePosition;

    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        itemDragging = null;
        if (transform.parent == dragParent) {
            transform.position = startPosition;
            transform.SetParent(startParent);
        }
        Debug.Log("OnEndDrag");
    }
}