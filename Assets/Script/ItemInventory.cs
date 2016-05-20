using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ItemInventory : MonoBehaviour {

    public List<GameObject> Slots = new List<GameObject>();
    public List<Item> Items = new List<Item>();
    public GameObject slots;
    ItemDatabase database;

    int x = -130;
    int y = 0;

    // Use this for initialization
    void Start ()
    {
        int slotamount = 0;
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();

        for(int i = 1; i < 6; i++)
        {
            GameObject slot = (GameObject)Instantiate(slots);
            slot.GetComponent<ItemSlot>().slotNumber = slotamount;
            Slots.Add(slot);
            Items.Add(new Item());
            slot.transform.parent = this.gameObject.transform;
            slot.name = "Slot" + i;
            slot.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);

            x = x + 65;
            slotamount++;
        }

        for(int i = 301; i<303; i++)
        {
            addItem(i);
        }

    }

    // Update is called once per frame
    void Update () {
	
	}

    void addItem(int id)
    {
        for (int i = 0; i < database.items.Count; i++)
        {
            if(database.items[i].itemID == id)
            {
                Item item = database.items[i];

                database.items[i].itemValue++;
                addEmptySlot(item);
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
