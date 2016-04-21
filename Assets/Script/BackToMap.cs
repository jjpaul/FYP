using UnityEngine;
using System.Collections;

public class BackToMap : MonoBehaviour {

    UIControll UI;
    // Use this for initialization
    void Start () {
        UI = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControll>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            UI.showExitPanel();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            UI.closeExitPanel();
        }
    }
}
