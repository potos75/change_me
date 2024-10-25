using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo_Script : MonoBehaviour
{
    public inventorymenager inventorymanager;
    public Item[] itemsToPickup;


    public void Pickupitem(int id)
    {
        bool result = inventorymanager.AddItem(itemsToPickup[id]);
        if(result == true)
        {
            Debug.Log("item added");
        }
        else
        {
            Debug.Log("Item not addedd");
        }
    }

    public void GetSelectedItem()
    {
        Item reciveditem = inventorymanager.Getselecteditem(false);
        if(reciveditem != null)
        {
            Debug.Log("recived item " + reciveditem);
        }
        else
        {
            Debug.Log("no item recived");
        }
    }
    public void useSelectedItem()
    {
        Item reciveditem = inventorymanager.Getselecteditem(true);
        if (reciveditem != null)
        {
            Debug.Log("used item " + reciveditem);
        }
        else
        {
            Debug.Log("no item used");
        }
    }
}
