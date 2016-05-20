using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();
	// Use this for initialization
	void Start () {
        //Material
        items.Add(new Item("wood_1", 101, "wood for forging", 0, 1, Item.ItemType.Material, true, 100));
        items.Add(new Item("wood_2", 102, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("wood_3", 103, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("wood_4", 104, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("wood_5", 105, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("wood_6", 106, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("wood_7", 107, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("wood_8", 108, "wood for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_1", 109, "rock for forging", 0, 1, Item.ItemType.Material, true, 100));
        items.Add(new Item("rock_2", 110, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_3", 111, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_4", 112, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_5", 113, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_6", 114, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_7", 115, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("rock_8", 116, "rock for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_1", 117, "grass for forging", 0, 9, Item.ItemType.Material, true, 100));
        items.Add(new Item("grass_2", 118, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_3", 119, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_4", 120, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_5", 121, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_6", 122, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_7", 123, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        items.Add(new Item("grass_8", 124, "grass for forging", 0, 0, Item.ItemType.Material, false, 0));
        
        //Weapon
        items.Add(new Item("Weapon_1", 201, "weapon one for testing", 10, 1, Item.ItemType.Weapon, true, 200));
        items.Add(new Item("Weapon_2", 202, "weapon two for testing", 10, 1, Item.ItemType.Weapon, true, 500));
        items.Add(new Item("Weapon_3", 203, "weapon two for testing", 10, 0, Item.ItemType.Weapon, true, 1200));
        items.Add(new Item("Weapon_4", 204, "weapon two for testing", 10, 0, Item.ItemType.Weapon, true, 3000));
        items.Add(new Item("Weapon_5", 205, "weapon two for testing", 10, 0, Item.ItemType.Weapon, true, 5600));
        items.Add(new Item("Weapon_6", 206, "weapon two for testing", 10, 0, Item.ItemType.Weapon, true, 8000));
        items.Add(new Item("Weapon_7", 207, "weapon two for testing", 10, 0, Item.ItemType.Weapon, true, 9999));

        //Consumable    
        items.Add(new Item("consumable_1", 301, "Medicine for HP recovery", 0, 0, Item.ItemType.Consumable, true, 250));
        items.Add(new Item("consumable_2", 302, "Medicine for AP recovery", 0, 0, Item.ItemType.Consumable, true, 300));
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
