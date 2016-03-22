using UnityEngine;
using System.Collections;


public class Door : MonoBehaviour {


    UIControll UI;
    FlagScript Flag;

    public bool showUI = false;
	// Use this for initialization
	void Start () {
        UI = GameObject.FindGameObjectWithTag("UIController").GetComponent<UIControll>();
        Flag = GameObject.FindGameObjectWithTag("Flag").GetComponent<FlagScript>();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player" && !Flag.IsOpen)
        {
            UI.showExitPanel();
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && !Flag.IsOpen)
        {
            UI.closeExitPanel();
        }
    }



}
