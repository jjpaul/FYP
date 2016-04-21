using UnityEngine;
using System.Collections;

public class PickItem : MonoBehaviour {

    // Use this for initialization
    monsterMove monster;
    Bag bag;

	void Start () {
        monster = GameObject.FindGameObjectWithTag("enemy").GetComponent<monsterMove>();
        bag = GameObject.FindGameObjectWithTag("Bag").GetComponent<Bag>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "enemy")
        {
            if(monster.HP <= 0)
            {
                bag.addItem(monster.itemId);
                monster.Dead();
            }
        }
    }
}
