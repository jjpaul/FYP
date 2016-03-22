using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

    // Use this for initialization

    CharacterAttributes character;
    public GameObject characterAnim;
    CharacterController characterCon;

    public bool hit = true;
    public bool touch = false;

    void Start () {
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
        characterCon = characterAnim.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        if(touch && hit)
        {
            hit = false;
            character.HP -= 20;
            characterCon.IsHurt = true;
            StartCoroutine(waiting());
        }
    }    

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            touch = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            touch = false;
            characterCon.IsHurt = false;
        }
    }

    public IEnumerator waiting()
    {
        yield return new WaitForSeconds(2f);
        hit = true;
    }

}
