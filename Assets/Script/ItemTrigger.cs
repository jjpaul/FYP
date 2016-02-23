using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ItemTrigger : MonoBehaviour {

    public GameObject place_01;
    public GameObject place_02;
    public GameObject place_03;
    public GameObject Item_01;
    public GameObject Item_02;
    public GameObject product;
    public GameObject product_2;
    static bool selected_Q;
    static bool selected_E;
    private bool selected;
    private bool chk;
    static bool rock;
    static bool grass;
    static bool wood;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	    if(selected && !selected_Q && Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("place_1 : " + this.gameObject.name);
            Item_01 = Instantiate(this, new Vector3(place_01.transform.position.x, place_01.transform.position.y, 0.0f), Quaternion.identity) as GameObject;
            if(this.tag == "rock")
            {
                rock = true;
            }else if(this.tag == "grass")
            {
                grass = true;
            }else if(this.tag == "wood")
            {
                wood = true;
            }
            selected_Q = true;
            
        }

        if (selected && !selected_E && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("place_2 : " + this.gameObject.name);
            Item_02 = Instantiate(this, new Vector3(place_02.transform.position.x, place_02.transform.position.y, 0.0f), Quaternion.identity) as GameObject;
            if (this.tag == "rock")
            {
                rock = true;
            }
            else if (this.tag == "grass")
            {
                grass = true;
            }
            else if (this.tag == "wood")
            {
                wood = true;
            }
            selected_E = true;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            selected_E = false;
            selected_Q = false;
            rock = false;
            grass = false;
            wood = false;
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (rock && wood)
            {
                GameObject productPf = Instantiate(product, new Vector3(place_03.transform.position.x, place_03.transform.position.y, 0.0f), Quaternion.identity) as GameObject;
            }
            if (wood && grass)
            {
                GameObject productPf = Instantiate(product_2, new Vector3(place_03.transform.position.x, place_03.transform.position.y, 0.0f), Quaternion.identity) as GameObject;
            }
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "selecting")
        {
            Debug.Log("hi from"  + this.gameObject.name);
            selected = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "selecting")
        {
            Debug.Log("bye");
            selected = false;
        }
    }
}
