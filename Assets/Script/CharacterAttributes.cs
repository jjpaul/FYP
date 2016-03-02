using UnityEngine;
using System.Collections;

public class CharacterAttributes : MonoBehaviour {

    public int forgingExp ;
    private int preForgingExp = 1;
    static int forgingLevel = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void Update () {
	    if(forgingExp == preForgingExp * 100)
        {
            forgingLevel++;
            preForgingExp = forgingExp;
            Debug.Log("forging level: " + forgingLevel);
        }
	}

    public void setForgingExp(int forgingExp)
    {
        this.forgingExp += forgingExp;
        Debug.Log("exp add:" + forgingExp);
    }
}
