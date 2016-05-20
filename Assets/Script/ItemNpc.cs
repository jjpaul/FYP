using UnityEngine;
using System.Collections;

public class ItemNpc : MonoBehaviour {

    public GameObject waiting;
    private GameObject waitingPrefab;
    private bool UIReady;

    public GameObject ItemInventory;
    UIControll UI;

    // Use this for initialization
    void Start () {
        UI = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControll>();
    }
	
	// Update is called once per frame
	void Update () {
        if (UIReady && Input.GetMouseButtonDown(0))
        {
            ItemInventory.SetActive(true);
            UI.showBagPanel();
        }
        if (!UIReady || Input.GetMouseButtonDown(1))
        {
            ItemInventory.SetActive(false);
        //    UI.closeBagPanel();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hi");
            UIReady = true;
            waitingPrefab = Instantiate(waiting, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f), Quaternion.identity) as GameObject;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("bye");
            UIReady = false;
            Destroy(waitingPrefab);

        }
    }
}
