using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventorymenager : MonoBehaviour
{
    //scrypt do odbierania nowych itemów i przypisywania ich do wolnego slotu

    public int Maxstackitem = 64;
    public inventoryslot[] Inventoryslots;
    public GameObject inventoryitemprefab;
    //tablica na ka¿dy obiekt slot


    public bool AddItem(Item item)
    {
        //find if any slot has the same item with count lower than max
        for (int i = 0; i < Inventoryslots.Length; i++)
        {
            inventoryslot slot = Inventoryslots[i];
            dragingitem ItemInSlot = slot.GetComponentInChildren<dragingitem>();
            if (ItemInSlot != null && ItemInSlot.item == item && ItemInSlot.Count < Maxstackitem && ItemInSlot.item.stackable == true)
            {
                ItemInSlot.Count++;
                ItemInSlot.RefreshCount();
                return true;
            }
            //sprawdza czy dany slot ma coœ w sobie
        }
        //find any empty slot
        for (int i = 0; i < Inventoryslots.Length; i++)
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