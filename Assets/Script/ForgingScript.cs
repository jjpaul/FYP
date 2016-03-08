using UnityEngine;
using System.Collections;

public class ForgingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    for (int i = 0; i < 2; i++)
        {
            transform.GetChild(i).GetComponent<ForgingSlot>().index = i;
        }
	}
}
