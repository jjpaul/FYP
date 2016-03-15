using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterAttributes : MonoBehaviour {

    public int StoreExp;
    public int ForgingExp;
    public int StoreLv;
    public int ForgingLv;

    public int SNeededExp;
    public int FNeededExp;

    public int Asset;

    void Start()
    {
        StoreExp = 0;
        ForgingExp = 0;
        StoreLv = 1;
        ForgingLv = 1;
        SNeededExp = 300;
        FNeededExp = 500;
        Asset = 5000;
    }

    void Update()
    {
        if(StoreExp >= SNeededExp)
        {
            StoreLv++;
            SNeededExp = SNeededExp * 3;
        }

        if(ForgingExp >= FNeededExp)
        {
            ForgingLv++;
            FNeededExp = FNeededExp * 2;
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
