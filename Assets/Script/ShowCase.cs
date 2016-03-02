using UnityEngine;
using System.Collections;

public class ShowCase : MonoBehaviour {

    public GameObject waiting;
    private GameObject waitingPrefab;
    public GameObject showCase;
    private GameObject showCasePf;

    public GameObject selecting;
    public GameObject selecting2;
    private GameObject selectingPf;
    private GameObject selecting2Pf;

    public GameObject weapon_1;
    public GameObject weapon_2;
    private GameObject weapon_1Pf;
    private GameObject weapon_2Pf;

    private bool called;
    private bool canCall;
    private bool weapon_set;
    private bool move;
    private bool weapon_1_Set;
    private bool weapon_2_Set;
    // Use this for initialization
    void Start () {
        called = false;
        canCall = false;
        move = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (canCall && !called && Input.GetKeyDown(KeyCode.K))
        {
            showCasePf = Instantiate(showCase);
            selectingPf = Instantiate(selecting);
            called = true;
            canCall = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && selectingPf.transform.position.x < 3 && move)
        {
            selectingPf.transform.position = new Vector3(selectingPf.transform.position.x + 2.3f, selectingPf.transform.position.y, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Q) && selectingPf.transform.position.x > -2 && move)
        {
            selectingPf.transform.position = new Vector3(selectingPf.transform.position.x - 2.3f, selectingPf.transform.position.y, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.J) && called && !weapon_set)
        {
            weapon_1Pf = Instantiate(weapon_1, selectingPf.transform.position, Quaternion.identity) as GameObject; 
            weapon_set = true;
            weapon_1_Set = true;
            weapon_2_Set = false;
            move = false;
        }
        if(Input.GetKeyDown(KeyCode.E) && weapon_set && !move )
        {
            if (weapon_1_Set)
            {
                Destroy(weapon_1Pf);
                weapon_2Pf = Instantiate(weapon_2, selectingPf.transform.position, Quaternion.identity) as GameObject;
                weapon_1_Set = false;
                weapon_2_Set = true;
            }else if (weapon_2_Set)
            {
                Destroy(weapon_2Pf);
                weapon_1Pf = Instantiate(weapon_1, selectingPf.transform.position, Quaternion.identity) as GameObject;
                weapon_1_Set = true;
                weapon_2_Set = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.K))
        {

                Destroy(weapon_1Pf);
                Destroy(weapon_2Pf);
        }

        if (Input.GetKeyDown(KeyCode.Q) && weapon_set)
        {
            weapon_set = false;
            move = true;
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
            Destroy(selectingPf);
            Destroy(weapon_1Pf);
            Destroy(weapon_2Pf);

        }
    }
}
