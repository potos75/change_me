using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorymenager : MonoBehaviour
{
    //scrypt do odbierania nowych itemów i przypisywania ich do wolnego slotu

    public inventoryslot[] Inventoryslots;
    public GameObject inventoryitemprefab;
    //tablica na ka¿dy obiekt slot
    public bool AddItem(Item item)
    {
        //find any empty slot
        for(int i = 0; i < Inventoryslots.Length; i++)
        {
            inventoryslot slot = Inventoryslots[i];
            dragingitem ItemInSlot = slot.GetComponentInChildren<dragingitem>();
            if(ItemInSlot == null)
            {
                SpanwNewItem(item, slot);
                return true;
            }
            //sprawdza czy dany slot ma coœ w sobie
        }
        return false;
    }

    void SpanwNewItem(Item item, inventoryslot slot)
    {
        GameObject newItemGo = Instantiate(inventoryitemprefab, slot.transform);
        //Instantiate() - creat new game object
        dragingitem inventoryitem = newItemGo.GetComponent<dragingitem>();
        //przypisanie skryptu do nowego obiektu
        inventoryitem.initiaslizeitem(item);
    }
}