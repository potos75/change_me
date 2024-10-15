using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragingitem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //gotowe funkcje unity z biblioteki "UnityEngine.EventSystems";
    //IBeginDragHandler - rozpocz�cie trzymanie 
    //IDragHandler - trzymanie
    //IEndDragHandler - zako�czenie trzymania

    public Item item;

    public Image image;
    //zmienna do wy�aczania interakcji z myszk� poniewa� w inventory slot po upuszczeniu unity wybiera item zamiast slota

    [HideInInspector] public Transform parentafterdrag;
    //hideininspector s�u�y do nie pokazywania luki na w�o�enie danej w unity
    public void Start()
    {
        initiaslizeitem(item);
    }
    public void initiaslizeitem(Item newitem)
    {
        item = newitem;
        image.sprite = newitem.image;
    }
    //funkcja do przypisywania gotowego itemu do itemu 

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentafterdrag = transform.parent;
        //zapisujemy pocz�tkowego rodzica
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        //dawanie obiektu na najwy�ej w hierarchi (zmienianie layer)
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
        // przesuwanie pozycji
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentafterdrag);
        //ustawiamy pocz�tkowego rodzica 
        image.raycastTarget = true;
    }
}
