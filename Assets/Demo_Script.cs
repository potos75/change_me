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
}
