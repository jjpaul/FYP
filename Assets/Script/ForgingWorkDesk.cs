using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ForgingWorkDesk : MonoBehaviour {


    public GameObject waiting;
    private GameObject waitingPrefab;
    private bool UIReady;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (UIReady && Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("forging UI");
            SceneManager.LoadScene(3);
            
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("hi");
            UIReady = true;
            waitingPrefab = Instantiate(waiting, new Vector2(this.gameObject.transform.position.x,this.gameObject.transform.position.y+1.5f), Quaternion.identity) as GameObject;
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
