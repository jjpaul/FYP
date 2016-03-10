using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WeaponStorage : MonoBehaviour {

    public GameObject waiting;
    private GameObject waitingPrefab;
    private bool UIReady;

    public GameObject panel;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (UIReady && Input.GetMouseButtonDown(0))
        {
            panel.SetActive(true);
        }
        if (!UIReady || Input.GetMouseButtonDown(1))
        {
            panel.SetActive(false);
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
