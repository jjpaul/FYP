using UnityEngine;
using System.Collections;

public class ShowCase : MonoBehaviour {

    public GameObject waiting;
    private GameObject waitingPrefab;
    public GameObject showCase;
    private GameObject showCasePf;

    private bool called;
    private bool canCall;
    // Use this for initialization
    void Start () {
        called = false;
        canCall = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (canCall && !called && Input.GetKeyDown(KeyCode.K))
        {
            showCasePf = Instantiate(showCase);
            called = true;
            canCall = false;
        }
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hi");
            waitingPrefab = Instantiate(waiting, new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f), Quaternion.identity) as GameObject;
            canCall = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("bye");
            Destroy(waitingPrefab);
            called = false;
            Destroy(showCasePf);

        }
    }
}
