using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class Bag : MonoBehaviour {


    public List<GameObject> Slots = new List<GameObject>();
    public List<Item> Items = new List<Item>();
    public GameObject slots;
    ItemManager IM;
    ItemDatabase database;

    int x = -90;
    int y = 30;
	// Use this for initialization
	void Start ()
    {
        IM = GameObject.FindGameObjectWithTag("IM").GetComponent<ItemManager>();
        int slotamount = 0;
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        for(int i = 1; i < 6; i++)
        {
            for(int j = 1; j < 5; j++)
            {
                GameObject slot = (GameObject)Instantiate(slots);
                slot.GetComponent<BagSlot>().slotNumber = slotamount;
                Slots.Add(slot);
                Items.Add(new Item());
                slot.transform.parent = this.gameObject.transform;
                slot.name = "Slot" + i + "." + j;
                slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
                x = x + 60;
                if (j == 4)
                {
                    x = -90;
                    y = y - 55;
                }
                slotamount++;
            }
        }

        for (int i = 201; i < 203; i++)
        {
            addItem(i);
        }
    }
	
	// Update is called once per frame
	void Update () {
	    for(int i = 0; i < IM.itemID.Length; i++)
        {
            Debug.Log("add3!");
            if (IM.itemID[i] != 0)
            {
                Debug.Log("add4!");
                addItem(IM.itemID[i]);  
                IM.itemID[i] = 0;
                break;
            }
        }
	}

    public void chkItemExist(int itemID, Item item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].itemID == itemID)
            {
                Items[i].itemValue = Items[i].itemValue + 1;
            //    database.items[i].itemValue++;
                break;
            }
            else if (i == Items.Count - 1)
            {
           //     database.items[i].itemValue++;
                addEmptySlot(item);
            }
        }
    }

    public void addItem(int id)
    {
        for(int i = 0; i < database.items.Count; i++)
        {
            if(database.items[i].itemID == id)
            {
                Item item = database.items[i];
                if(database.items[i].itemDiscv != true)
                {
                    database.items[i].itemDiscv = true;
                }
                chkItemExist(id, item);
                if (database.items[i].itemValue < 1)
                {
                    database.items[i].itemValue++;
                }
               // addEmptySlot(item);

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
