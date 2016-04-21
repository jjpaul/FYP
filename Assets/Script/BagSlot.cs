using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BagSlot : MonoBehaviour, IPointerDownHandler
{

    public Item item;
    Image itemImage;
    public int slotNumber;
    Bag bag;
    Text itemAmount;



    // Use this for initialization
    void Start ()
    {
       // itemAmount = gameObject.transform.GetChild(1).GetComponent<Text>();
        bag = GameObject.FindGameObjectWithTag("Bag").GetComponent<Bag>();
        itemImage = gameObject.transform.GetChild(0).GetComponent<Image>();
        transform.GetChild(0).GetComponent<Image>().enabled = false;
      
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if(bag.Items[slotNumber].itemName != null)
        {
            item = bag.Items[slotNumber];
            itemImage.enabled = true;
            itemImage.sprite = bag.Items[slotNumber].itemIcon;
         //   itemAmount.enabled = true;
         //   itemAmount.text = "" + bag.Items[slotNumber].itemValue;
        }
	}

    public void OnPointerDown(PointerEventData data)
    {
        Debug.Log("555");
        
    }
}
