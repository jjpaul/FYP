using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterAttributes : MonoBehaviour {

    //store
    public int StoreExp;
    public int ForgingExp;
    public int StoreLv;
    public int ForgingLv;

    public int SNeededExp;
    public int FNeededExp;

    public int Asset;

    //adventurer
    public int CharLv;
    public int BattleExp;
    public int CNeededExp;

    public int AdvenLv;
    public int AdvenEXP;
    public int ANeededExp;

    public int HP;
    public int AP;
    public int Str;
    public int Vit;
    public int Tec;
    public int Agi;
    public int Luc;

    public int Att;
    public int Def;
    public int Flee;
    public int drop;

    public int Point;

    void Start()
    {
        StoreExp = 0;
        ForgingExp = 0;
        StoreLv = 1;
        ForgingLv = 1;
        SNeededExp = 300;
        FNeededExp = 500;
        Asset = 5000;

        CharLv = 1;
        BattleExp = 0;
        CNeededExp = 5000;

        AdvenLv = 1;
        AdvenEXP = 0;
        AdvenEXP = 2000;


        HP = 1000;
        AP = 350;
        Str = 1;
        Vit = 1;
        Tec = 1;
        Agi = 1;
        Luc = 1;
        Point = 99;
        Att = 100;
        Def = 20;
        Flee = 0;
        drop = 0;
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

        if(BattleExp > CNeededExp)
        {
            CharLv++;
            CNeededExp = CNeededExp * 3;
        }

        if(AdvenEXP > ANeededExp)
        {
            AdvenLv++;
            ANeededExp = ANeededExp * 2;
        }
    }

    public void StrAdd()
    {
        if (Point > 0)
        {
            Str++;
            Point--;
            Att = 100 + Str * 20;
        }
    }

    public void VitAdd()
    {
        if (Point > 0)
        {
            Vit++;
            Point--;
            HP = 1000 + Vit * 100;
        }
    }

    public void AgiAdd()
    {
        if (Point > 0)
        {
            Agi++;
            Point--;
            Flee = Agi / 5;
        }
    }

    public void TecAdd()
    {
        if (Point > 0)
        {
            Tec++;
            Point--;
            AP = 350 + Tec * 40;
        }
    }

    public void LucAdd()
    {
        if (Point > 0)
        {
            Luc++;
            Point--;
            drop = Luc / 9;
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
