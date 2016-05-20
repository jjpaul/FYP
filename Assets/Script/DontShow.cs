using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DontShow : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
        //    this.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
