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

    int selectedSlot = -1;
    private void Start()
    {
        ChangeSelectedSlot(0);
    }
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            int changeslot = selectedSlot + 1;
            ChangeSelectedSlot(changeslot);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int changeslot2 = selectedSlot - 1;
            ChangeSelectedSlot(changeslot2);
        }
    }

    void ChangeSelectedSlot(int newValue)
    {
        if(selectedSlot >= 0)
        {
            Inventoryslots[selectedSlot].diselect();
        }
        Inventoryslots[newValue].Select();
        selectedSlot = newValue;

    }
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

    public Item Getselecteditem(bool use)
    {
        inventoryslot slot = Inventoryslots[selectedSlot];
        dragingitem itemInSlot = slot.GetComponentInChildren<dragingitem>();
        if(itemInSlot != null)
        {
            Item item = itemInSlot.item;
            if(use == true)
            {
                itemInSlot.Count--;
                if(itemInSlot.Count <= 0)
                {
                    Destroy(itemInSlot.gameObject);
                }
                else
                {
                    itemInSlot.RefreshCount();
                }
            }
            return item;
        }
        return null;
    }
}