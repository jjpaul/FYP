﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ForgingSlot : MonoBehaviour , IPointerDownHandler{

    public Item item;
    public int index;
    Inventory inventory;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        item = gameObject.AddComponent<Item>();
    }

    void Update()
    {
        if (item.itemType != Item.ItemType.None)
        {
            transform.GetChild(0).GetComponent<Image>().enabled = true;
            transform.GetChild(0).GetComponent<Image>().sprite = item.itemIcon;
        }
        else
        {
            transform.GetChild(0).GetComponent<Image>().enabled = false;
        }

    }

    public void OnPointerDown(PointerEventData data)
    {
        if (inventory.draggingItem)
        {
            if(inventory.theDraggedItem.itemType == Item.ItemType.Material)
            {
                 item = inventory.theDraggedItem;
                 inventory.closeDraggedItem();            
            }           
        }
    }
}