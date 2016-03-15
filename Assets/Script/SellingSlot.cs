using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SellingSlot : MonoBehaviour, IPointerDownHandler
{
    WeaponInventory inventory;
    public Item item;
    Sprite temp;

    TempSelling tempSelling;
    public int index;
    public bool soldOut;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<WeaponInventory>();
        tempSelling = GameObject.FindGameObjectWithTag("TempSell").GetComponent<TempSelling>();
        item = new Item();
        transform.GetChild(1).GetComponent<Image>().enabled = false;
    }

    void Update()
    {
        if (tempSelling.tempItem[index].itemName != null)
        {
            item = tempSelling.tempItem[index];
        }
        if (tempSelling.tempItem[index].itemName != null)
        {
            transform.GetChild(0).GetComponent<Image>().enabled = true;
            transform.GetChild(0).GetComponent<Image>().sprite = tempSelling.tempItem[index].itemIcon;
        }
        else
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

        if(item.itemValue <= 0 && item.itemName != null)
        {
            transform.GetChild(1).GetComponent<Image>().enabled = true;
         //   Debug.Log(item.itemName + "sold out");
        }
        else
        {
            soldOut = false;
        }

    }

    public void OnPointerDown(PointerEventData data)
    {
        if (inventory.draggingItem)
        {
            if (inventory.theDraggedItem.itemType == Item.ItemType.Weapon)
            {
                if (item.itemName == null )
                {
                    item = inventory.theDraggedItem;
                    tempSelling.tempItem[index] = item;
                 //   item.itemValue--;
                    inventory.closeDraggedItem();
                }
                else
                {
                  //  item.itemValue++;
                    item = inventory.theDraggedItem;
                    tempSelling.tempItem[index] = item;
                 //   item.itemValue--;
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
        this.tempSelling.tempItem[index] = new Item();
    }
}


