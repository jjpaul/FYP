using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FlagScript : MonoBehaviour {


    public Sprite Open;
    public Sprite Close;

    CustomerController customer;

    public bool IsOpen;
	// Use this for initialization
	void Start () {
        customer = GameObject.FindGameObjectWithTag("CustomerController").GetComponent<CustomerController>();
        GetComponent<SpriteRenderer>().sprite = Close;
        IsOpen = false;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
        if (hit != null && hit.collider != null && Input.GetMouseButtonDown(0))
        {
            if(hit.collider.name == "Flag_Close")
            {
                StoreOpen();
                Debug.Log("I'm hitting " + hit.collider.name);
            }
            Debug.Log("I'm hitting " + hit.collider.name);
        }
    }

    public void StoreOpen()
    {
        if (IsOpen)
        {
            GetComponent<SpriteRenderer>().sprite = Close;
            IsOpen = false;
        }else if (!IsOpen)
        {
            GetComponent<SpriteRenderer>().sprite = Open;
            IsOpen = true;
        }
    }

    //void onMouseDown()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        StoreOpen();
    //    }
    //}
}
