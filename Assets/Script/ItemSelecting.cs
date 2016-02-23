using UnityEngine;
using System.Collections;

public class ItemSelecting : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if(transform.position.x < 7f)
              transform.position = new Vector3(this.transform.position.x + 0.945f, this.transform.position.y, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x >= 4.2f)
                transform.position = new Vector3(this.transform.position.x - 0.945f, this.transform.position.y, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (transform.position.y < 17.7f)
                transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 0.95f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (transform.position.y > 9.5F)
                transform.position = new Vector3(this.transform.position.x, this.transform.position.y -0.95F, 0.0f);
        }
    }
}
