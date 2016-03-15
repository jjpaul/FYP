using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WeaponForgeSlot : MonoBehaviour {

    public Item item;
    Inventory inventory;
    ItemDatabase database;
    CharacterAttributes character;
    public GameObject Material_1;
    public GameObject Material_2;
    public GameObject ForgingPanel;

    public bool M_1_OK;
    public bool M_2_OK;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        database = GameObject.FindGameObjectWithTag("ItemDatabase").GetComponent<ItemDatabase>();
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
    }

    void Update()
    {
        if(Material_1.transform.GetChild(0).GetComponent<Image>().enabled == false)
        {
            M_1_OK = false;
        }
        else
        {
            M_1_OK = true;
        }

        if (Material_2.transform.GetChild(0).GetComponent<Image>().enabled == false)
        {
            M_2_OK = false;
        }
        else
        {
            M_2_OK = true;
        }

        if (M_1_OK && M_2_OK)
        {
            ForgingPanel.transform.GetChild(3).GetComponent<Button>().enabled = true;
        }
        else
        {
            ForgingPanel.transform.GetChild(3).GetComponent<Button>().enabled = false;
        }

    }

    public void weaponForge()
    {
        if (M_1_OK && M_2_OK)
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
        else
        {
       //     ForgingPanel.transform.GetChild(4).GetComponent<Button>().enabled = false;
        }
    }
}
