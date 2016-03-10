using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SellingSlot : MonoBehaviour, IPointerDownHandler
{

    WeaponInventory inventory;
    public Item item;
    Sprite temp;
   // public int index;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<WeaponInventory>();
        item = new Item();
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
            if (inventory.theDraggedItem.itemType == Item.ItemType.Weapon)
            {
                if (item.itemName == null)
                {
                    item = inventory.theDraggedItem;
                    item.itemValue--;
                    inventory.closeDraggedItem();
                }
                else
                {
                    item.itemValue++;
                    item = inventory.theDraggedItem;
                    item.itemValue--;
                    inventory.closeDraggedItem();
                }
            }
        }
    }

    public void init()
    {
        item.itemValue++;
        //   transform.GetComponent<Image>().sprite = item.itemDefaultIcon;
        this.item = new Item();
    }
}
