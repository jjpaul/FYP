using UnityEngine;
using System.Collections;

public class Item {

    public string itemName;
    public int itemID;
    public string itemDesc;
    public Sprite itemIcon;
    public Sprite itemDefaultIcon;
    public int itemValue;
    public int itemPower;
    public ItemType itemType;
    public bool itemDiscv;

    public enum ItemType
    {
        None,
        Weapon,
        Material,
        Consumable
    }

    public Item(string name, int id, string desc,int power, int value, ItemType type , bool discv)
    {
        itemName = name;
        itemID = id;
        itemDesc = desc;
        itemPower = power;
        itemValue = value;
        itemType = type;
        itemDefaultIcon = Resources.Load<Sprite>("Unknown");
        itemIcon = Resources.Load<Sprite>("" + name);
        itemDiscv = discv;
    }

    public Item()
    {

    }
}
