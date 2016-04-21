using UnityEngine;
using System.Collections;

public class particleMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemy")
        {
            destroyPf();
            Debug.Log("hitted");
        }
    }

    void destroyPf()
    {
        Destroy(this);
    }
}
