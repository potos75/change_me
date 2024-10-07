using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragingitem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //gotowe funkcje unity z biblioteki "UnityEngine.EventSystems";
    //IBeginDragHandler - rozpoczęcie trzymanie 
    //IDragHandler - trzymanie
    //IEndDragHandler - zakończenie trzymania

    [HideInInspector] public Transform parentafterdrag;
    //hideininspector służy do nie pokazywania luki na włożenie danej w unity

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentafterdrag = transform.parent;
        //zapisujemy początkowego rodzica
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        //dawanie obiektu na najwyżej w hierarchi (zmienianie layer)
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        // przesuwanie pozycji
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentafterdrag);
        //ustawiamy początkowego rodzica 
    }
}
