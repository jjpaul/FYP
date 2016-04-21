using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

    public int[] itemID;
	// Use this for initialization
	void Start () {
        itemID = new int[20];
        for(int i = 0; i <itemID.Length; i++)
        {
            itemID[i] = 0;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void add(int id)
    {
        Debug.Log("add!");
        for(int i = 0; i<itemID.Length; i++)
        {
            Debug.Log("add2!");
            if (itemID[i] == 0)
            {
                Debug.Log(itemID[i]);
                itemID[i] = id;
                break;
            }
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
