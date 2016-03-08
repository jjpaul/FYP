using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();
	// Use this for initialization
	void Start () {

        //Material
        items.Add(new Item("Wood", 101, "wood for forging", 0, 9, Item.ItemType.Material));
        items.Add(new Item("Rock", 102, "rock for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 103, "grass for forging", 0, 1, Item.ItemType.Material));
   /*     items.Add(new Item("Grass", 104, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 105, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 106, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 107, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 108, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 109, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 110, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 111, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 112, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 113, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 114, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 115, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 116, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 117, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 118, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 119, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 120, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 121, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 122, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 123, "grass for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 124, "grass for forging", 0, 1, Item.ItemType.Material));*/
        
        //Weapon
        items.Add(new Item("Weapon_1", 4, "weapon one for testing", 10, 1, Item.ItemType.Weapon));
        items.Add(new Item("Weapon_2", 5, "weapon two for testing", 10, 1, Item.ItemType.Weapon));

        //Consumable
    }	
}
