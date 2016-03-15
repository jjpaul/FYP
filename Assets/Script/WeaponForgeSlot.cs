using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WeaponForgeSlot : MonoBehaviour {

    public Item item;
    Inventory inventory;
    ItemDatabase database;
    CharacterAttributes character;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
    }

    public void weaponForge()
    {
            for (int i = 0; i < database.items.Count; i++)
            {
                if (database.items[i].itemID == 201)
                {
                    item = database.items[i];
                    database.items[i].itemValue++;
                    character.ForgingExp = character.ForgingExp + 100;
                }
            }
            transform.GetChild(0).GetComponent<Image>().enabled = true;
            transform.GetChild(0).GetComponent<Image>().sprite = item.itemIcon;
            Debug.Log(this.item.itemValue);
        }
}
