using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class inventoryslot : MonoBehaviour, IDropHandler
{
    //Idrophandler - funkcja do upuszczania na ten obiekt
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        dragingitem draggableItem = dropped.GetComponent<dragingitem>();

    }
}
