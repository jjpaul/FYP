using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Sprite itemIcon;
    public int itemValue;
    public int itemPower;
    public ItemType itemType;

    public enum ItemType
    {
        Weapon,
        Material,
        Consumable
    }

    public Item(string name, int id, string desc,int power, int value, ItemType type)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemValue = value;
        itemType = type;
        itemIcon = Resources.Load<Sprite>("" + name);
    }

    public Item()
    {

    }
}
