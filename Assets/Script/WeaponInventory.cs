﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class WeaponInventory : MonoBehaviour {

    public List<GameObject> Slots = new List<GameObject>();
    public List<Item> Items = new List<Item>();
    public GameObject slots;
    ItemDatabase database;

    public GameObject draggedItemGameObject;
    public bool draggingItem = false;
    public Item theDraggedItem;

    int x = -100;
    int y = 150;

    void Update()
    {
        if (draggingItem)
        {
            Vector3 position = (Input.mousePosition - GameObject.FindGameObjectWithTag("Canvas").GetComponent<RectTransform>().localPosition);
            draggedItemGameObject.GetComponent<RectTransform>().localPosition = new Vector3(position.x + 20, position.y - 20, position.z);
        }
    }

    public void showDraggedItem(Item item)
    {
        if(item.itemValue ==0)
        {
            draggingItem = false;
        }
        else
        {
            draggedItemGameObject.SetActive(true);
            theDraggedItem = item;
            draggingItem = true;
            draggedItemGameObject.GetComponent<Image>().sprite = item.itemIcon;
        }
        
    }

    public void closeDraggedItem()
    {
        draggingItem = false;
        draggedItemGameObject.SetActive(false);
    }

    // Use this for initialization
    void Start()
    {
        int slotamount = 0;

        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        for (int i = 1; i < 7; i++)
        {
            for (int j = 1; j < 5; j++)
            {
                GameObject slot = (GameObject)Instantiate(slots);
                slot.GetComponent<WeaponSlots>().slotNumber = slotamount;
                Slots.Add(slot);
                Items.Add(new Item());
                slot.transform.parent = this.gameObject.transform;
                slot.name = "Slot" + i + "." + j;
                slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
                x = x + 65;
                if (j == 4)
                {
                    x = -100;
                    y = y - 60;
                }
                slotamount++;
            }
        }

        //add Item
        for (int i = 201; i < 203; i++)
        {
            addItem(i);
        }
    }

    public void chkItemExist(int itemID, Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].itemID == itemID)
            {
                Items[i].itemValue = Items[i].itemValue + 1;
                break;
            }
            else if (i == Items.Count - 1)
            {
                addEmptySlot(item);
            }
        }
    }

    void addItem(int id)
    {
        for (int i = 0; i < database.items.Count; i++)
        {
            if (database.items[i].itemID == id)
            {
                Item item = database.items[i];

                if (database.items[i].itemType == Item.ItemType.Material || database.items[i].itemType == Item.ItemType.Consumable)
                {
                    chkItemExist(id, item);
                    break;
                }
                else
                {
                    addEmptySlot(item);
                }
            }
        }
    }

    void addEmptySlot(Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].itemName == null)
            {
                Items[i] = item;
                break;
            }
        }
    }
}