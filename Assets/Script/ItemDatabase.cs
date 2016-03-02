using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDatabase : MonoBehaviour {

    public List<Item> items = new List<Item>();
	// Use this for initialization
	void Start () {

        items.Add(new Item("Wood", 1, "wood for forging", 0, 9, Item.ItemType.Material));
        items.Add(new Item("Rock", 2, "rock for forging", 0, 1, Item.ItemType.Material));
        items.Add(new Item("Grass", 3, "grass for forging", 0, 1, Item.ItemType.Consumable));
        items.Add(new Item("Weapon_1", 4, "weapon one for testing", 10, 1, Item.ItemType.Weapon));
        items.Add(new Item("Weapon_2", 5, "weapon two for testing", 10, 1, Item.ItemType.Weapon));
    }	
}
