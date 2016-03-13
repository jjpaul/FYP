using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();
	// Use this for initialization
	void Start () {
        //Material
        items.Add(new Item("Wood", 101, "wood for forging", 0, 1, Item.ItemType.Material, true));
        items.Add(new Item("Wood", 102, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Wood", 103, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Wood", 104, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Wood", 105, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Wood", 106, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Wood", 107, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Wood", 108, "wood for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 109, "rock for forging", 0, 1, Item.ItemType.Material, true));
        items.Add(new Item("Rock", 110, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 111, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 112, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 113, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 114, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 115, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Rock", 116, "rock for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 117, "grass for forging", 0, 9, Item.ItemType.Material, true));
        items.Add(new Item("Grass", 118, "grass for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 119, "grass for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 120, "grass for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 121, "grass for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 122, "grass for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 123, "grass for forging", 0, 0, Item.ItemType.Material, false));
        items.Add(new Item("Grass", 124, "grass for forging", 0, 0, Item.ItemType.Material, false));
        
        //Weapon
        items.Add(new Item("Weapon_1", 201, "weapon one for testing", 10, 1, Item.ItemType.Weapon, true));
        items.Add(new Item("Weapon_2", 202, "weapon two for testing", 10, 1, Item.ItemType.Weapon, true));
        items.Add(new Item("Weapon_2", 203, "weapon two for testing", 10, 1, Item.ItemType.Weapon, true));

        //Consumable    

    }

    void Awake()
    {
        DontDestroyOnLoad(this);

        if(FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
