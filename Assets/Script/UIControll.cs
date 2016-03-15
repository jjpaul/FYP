using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIControll : MonoBehaviour {

    public GameObject AttributePanel;

    public GameObject FinancePanel;

    CharacterAttributes character;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("CharacterAttribute").GetComponent<CharacterAttributes>();
    }

    void Update()
    {
        //Attribute
        AttributePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.ForgingLv.ToString();
        AttributePanel.transform.GetChild(1).GetChild(0).GetComponent<Text>().text = character.ForgingExp.ToString() + "/" + character.FNeededExp.ToString();
        AttributePanel.transform.GetChild(2).GetChild(0).GetComponent<Text>().text = character.StoreLv.ToString();
        AttributePanel.transform.GetChild(3).GetChild(0).GetComponent<Text>().text = character.StoreExp.ToString() + "/" + character.SNeededExp.ToString();

        //Finance
        FinancePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.Asset.ToString();
    }


    public void showAttPanel()
    {
        AttributePanel.SetActive(true);
    }

    public void showFinPanel()
    {
        FinancePanel.SetActive(true);
   //     FinancePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = character.Asset.ToString();
    }

    public void closeAttPanel()
    {
        AttributePanel.SetActive(false);
    }

    public void closeFinPanel()
    {
        FinancePanel.SetActive(false);
    }
}
