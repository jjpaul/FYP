using UnityEngine;
using System.Collections;

public class UIControllforItemStore : MonoBehaviour {

    public GameObject buyInfo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void showbuyInfoPanel()
    {
        buyInfo.SetActive(true);
    }
}
