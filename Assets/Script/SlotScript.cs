﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlotScript : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler {

    public Item item;
    Image itemImage;
    public int slotNumber;
    Inventory inventory;

    Text itemAmount;


	// Use this for initialization
	void Start () {
        itemAmount = gameObject.transform.GetChild(1).GetComponent<Text>();
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(inventory.Items[slotNumber].itemName != null)
        {
            item = inventory.Items[slotNumber];
            itemImage.enabled = true;
            itemImage.sprite = inventory.Items[slotNumber].itemIcon;

            if(inventory.Items[slotNumber].itemType == Item.ItemType.Material || inventory.Items[slotNumber].itemType == Item.ItemType.Consumable)
            {
                itemAmount.enabled = true;
                itemAmount.text = "" + inventory.Items[slotNumber].itemValue;
            }

        }
        else
        {
            itemImage.enabled = false;
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        if (inventory.Items[slotNumber].itemType == Item.ItemType.Consumable)
        {
            inventory.Items[slotNumber].itemValue--;
            if (inventory.Items[slotNumber].itemValue == 0)
            {
                inventory.Items[slotNumber] = new Item();
                itemAmount.enabled = false;
                inventory.tooltip.SetActive(false);
            }
        }
    }

    public void OnPointerEnter(PointerEventData data)
    {
        if (inventory.Items[slotNumber].itemName != null)
        {
            inventory.showTooltip(inventory.Slots[slotNumber].GetComponent<RectTransform>().localPosition, inventory.Items[slotNumber]);
        }
    }

    public void OnPointerExit(PointerEventData data)
    {
        if (inventory.Items[slotNumber].itemName != null)
        {
            inventory.closeTooltip();
        }
    }
}
