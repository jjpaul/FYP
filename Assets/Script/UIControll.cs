using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIControll : MonoBehaviour {

    public GameObject StoreInfo;
    public GameObject FinancePanel;
    public GameObject ExitPanel;
    public GameObject AttriPanel;
    public GameObject BagPanel;

    CharacterAttributes character;
    CustomerController customer;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
   //     customer = GameObject.FindGameObjectWithTag("CustomerController").GetComponent<CustomerController>();
    }

    void Update()
    {
        //Attribute
        StoreInfo.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.ForgingLv.ToString();
        StoreInfo.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = character.ForgingExp.ToString() + "/" + character.FNeededExp.ToString();
        StoreInfo.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = character.StoreLv.ToString();
        StoreInfo.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = character.StoreExp.ToString() + "/" + character.SNeededExp.ToString();

        //Finance
        FinancePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.Asset.ToString();
   //     FinancePanel.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = customer.count.ToString();

        //Attribute
        AttriPanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.CharLv.ToString();
        AttriPanel.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = character.AdvenLv.ToString();
        AttriPanel.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = character.Str.ToString();
        AttriPanel.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = character.Vit.ToString();
        AttriPanel.transform.GetChild(4).GetChild(0).GetComponent<Text>().text = character.Agi.ToString();
        AttriPanel.transform.GetChild(5).GetChild(0).GetComponent<Text>().text = character.Tec.ToString();
        AttriPanel.transform.GetChild(6).GetChild(0).GetComponent<Text>().text = character.Luc.ToString();
        AttriPanel.transform.GetChild(7).GetChild(0).GetComponent<Text>().text = character.Point.ToString();
        AttriPanel.transform.GetChild(8).GetChild(0).GetComponent<Text>().text = character.HP.ToString();
        AttriPanel.transform.GetChild(9).GetChild(0).GetComponent<Text>().text = character.AP.ToString();
        AttriPanel.transform.GetChild(10).GetChild(0).GetComponent<Text>().text = character.Att.ToString();
        AttriPanel.transform.GetChild(11).GetChild(0).GetComponent<Text>().text = character.Def.ToString();
        AttriPanel.transform.GetChild(12).GetChild(0).GetComponent<Text>().text = "+ " + character.drop.ToString() + "%";
        AttriPanel.transform.GetChild(13).GetChild(0).GetComponent<Text>().text = "+ " + character.Flee.ToString() + "%";

    }


    public void showStoreInfoPanel()
    {
        StoreInfo.SetActive(true);
    }

    public void showFinPanel()
    {
        FinancePanel.SetActive(true);
   //     FinancePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.Asset.ToString();
    }

    public void closeStoreInfoPanel()
    {
        StoreInfo.SetActive(false);
    }

    public void closeFinPanel()
    {
        FinancePanel.SetActive(false);
    }

    public void showExitPanel()
    {
        ExitPanel.SetActive(true);
    }

    public void closeExitPanel()
    {
        ExitPanel.SetActive(false);
    }

    public void showAttPanel()
    {
        AttriPanel.SetActive(true);
    }

    public void closeAttPanel()
    {
        AttriPanel.SetActive(false);
    }

    public void showBagPanel()
    {
        BagPanel.SetActive(true);
    }

    public void closeBagPanel()
    {
        BagPanel.SetActive(false);
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
