using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IPointerDownHandler {

    public Item item;
    Image itemImage;
    public int slotNumber;
    ItemInventory itemInventory;
    ItemManager IM;
    CharacterAttributes character;

    // Use this for initialization
    void Start () {
        itemInventory = GameObject.FindGameObjectWithTag("ItemInventory").GetComponent<ItemInventory>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
        transform.GetChild(0).GetComponent<Image>().enabled = false;
        IM = GameObject.FindGameObjectWithTag("IM").GetComponent<ItemManager>();
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(itemInventory.Items[slotNumber].itemName != null)
        {
            item = itemInventory.Items[slotNumber];
            itemImage.enabled = true;
            itemImage.sprite = itemInventory.Items[slotNumber].itemIcon;
        }
	}

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("555");
        character.Asset -= item.itemCost;
        IM.add(item.itemID);
    }

}
