using UnityEngine;
using System.Collections;

public class TempSelling : MonoBehaviour {


    public Item[] tempItem = new Item[8];

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            tempItem[i] = new Item();
        }
    }
	// Use this for initialization
    void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

    }
}
