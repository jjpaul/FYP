using UnityEngine;
using System.Collections;

public class ShowCaseUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    for(int i = 0; i < 8; i++)
        {
            transform.GetChild(i).GetComponent<SellingSlot>().index = i;
        }
	}

}
