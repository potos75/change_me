using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class inventoryslot : MonoBehaviour, IDropHandler
{
    //Idrophandler - funkcja do upuszczania na ten obiekt
    public void OnDrop(PointerEventData eventData)
    {
        //if sprawdzaj�cy czy nie ma innego itema na danym slocie
        if(transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            //obiekt kt�ry jest upuszczony
            dragingitem draggableItem = dropped.GetComponent<dragingitem>();
            draggableItem.parentafterdrag = transform;
            //prziemieszczanie dziecka do innego rodzica po upuszczeniu
        }
    }
}